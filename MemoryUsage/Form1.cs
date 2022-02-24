using System;
using System.IO;
using System.Windows.Forms;
using System.Management;
using System.Reflection;
using System.Threading;

namespace Memory_Usage
{
    public partial class Form1 : Form
    {
        private bool flag;
        private string currentOpenFileName = "";
        private Thread _loggingThread;

        public Form1()
        {
            InitializeComponent();
        }

        // Prepare the ListView and display values.
        private void Form1_Load(object sender, EventArgs e)
        {
            chkbx_log.Visible = false;
            chkbx_log.Checked = false; 
            
            //Change the title of the window to add in the version number and file name
            Text = "Memory Usage : v" + Assembly.GetExecutingAssembly().GetName().Version;
           
        }

        
        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1; //Choose the extension to use
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentOpenFileName = saveFileDialog1.FileName;
                File.AppendAllText(currentOpenFileName, 
                "Date,Time,Free Physical Memory,Free Space In Paging Files,Free Virtual Memory,Size Stored In Paging Files," +
                "Total Virtual Memory Size,Total Visible Memory Size,Number Of Processes\r");

                chkbx_log.Visible = true;
                chkbx_log.Checked = false;
            }
        }

        private void chkbx_log_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_log.Checked)
            {
                Text = "Memory Usage : v" + Assembly.GetExecutingAssembly().GetName().Version + " : Logging to File = " + Path.GetFileNameWithoutExtension(currentOpenFileName);
                _loggingThread = new Thread(LogData);
                _loggingThread.IsBackground = true;
                _loggingThread.Start();
            }
            else
            {
                Text = "Memory Usage : v" + Assembly.GetExecutingAssembly().GetName().Version;
                _loggingThread.Abort();
            }

        }


        void LogData()
        {
            flag = chkbx_log.Checked;
            int index = 0;
            string _date = "";
            string _time = "";
            string _freePhysicalMemory = "";
            string _freeSpaceInPagingFiles = "";
            string _freeVirtualMemory = "";
            string _sizeStoredInPagingFiles = "";
            string _totalVirtualMemorySize = "";
            string _totalVisibleMemorySize = "";
            string _numberOfProcesses = "";

            do
            {
                 Invoke(new Action(() =>
                {
                    index = dgv_output.Rows.Add(); 
                    dgv_output.Rows[index].HeaderCell.Value = (index + 1).ToString();
                    dgv_output.FirstDisplayedScrollingRowIndex = dgv_output.Rows.Count - 1;
                }));



                ManagementObjectSearcher os_searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                foreach (ManagementObject mobj in os_searcher.Get())
                {
                    _date = DateTime.Now.ToString("dd-MM-yyyy");
                    _time = DateTime.Now.ToString("HH:mm:ss");
                    _freePhysicalMemory = GetInfo(mobj, "FreePhysicalMemory");
                    _freeSpaceInPagingFiles = GetInfo(mobj, "FreeSpaceInPagingFiles");
                    _freeVirtualMemory = GetInfo(mobj, "FreeVirtualMemory");
                    _sizeStoredInPagingFiles = GetInfo(mobj, "SizeStoredInPagingFiles");
                    _totalVirtualMemorySize = GetInfo(mobj, "TotalVirtualMemorySize");
                    _totalVisibleMemorySize = GetInfo(mobj, "TotalVisibleMemorySize");
                    _numberOfProcesses = GetInfo(mobj, "NumberOfProcesses");


                   Invoke(new Action(() => {
                        dgv_output.Rows[index].Cells["Date"].Value = _date;
                        dgv_output.Rows[index].Cells["Time"].Value = _time;
                        dgv_output.Rows[index].Cells["FreePhysicalMemory"].Value = _freePhysicalMemory;
                        dgv_output.Rows[index].Cells["FreeSpaceInPagingFiles"].Value = _freeSpaceInPagingFiles;
                       dgv_output.Rows[index].Cells["FreeVirtualMemory"].Value = _freeVirtualMemory;
                       dgv_output.Rows[index].Cells["SizeStoredInPagingFiles"].Value = _sizeStoredInPagingFiles;
                       dgv_output.Rows[index].Cells["TotalVirtualMemorySize"].Value = _totalVirtualMemorySize;
                       dgv_output.Rows[index].Cells["TotalVisibleMemorySize"].Value = _totalVisibleMemorySize;
                       dgv_output.Rows[index].Cells["NumberOfProcesses"].Value = _numberOfProcesses;
                   }));
                }
                
                File.AppendAllText(currentOpenFileName, _date + "," + _time + "," + _freePhysicalMemory + "," + 
                                                        _freeSpaceInPagingFiles + "," + _freeVirtualMemory + "," + 
                                                        _sizeStoredInPagingFiles + "," + _totalVirtualMemorySize + "," +
                                                        _totalVisibleMemorySize + "," + _numberOfProcesses + "\r");
                
               
                
                Thread.Sleep(int.Parse(txtbox_delayTime.Text)*1000); //delay in ms

            } while (flag);
        }

        private string GetInfo(ManagementObject mobj, string property_name)
        {
            object property_obj = mobj[property_name];
            
            if (property_name == "NumberOfProcesses")
            {
                return property_obj.ToString();
            }

            if (property_obj == null)
            {
               return "???";
            }

            //if we get here we have a value so work it out
            ulong property_value = (ulong)property_obj * 1024; 
            return property_value.ToFileSizeApi();
        }
    }
}
