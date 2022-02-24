namespace Memory_Usage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_delayTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkbx_log = new System.Windows.Forms.CheckBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_output = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreePhysicalMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeSpaceInPagingFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeVirtualMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeStoredInPagingFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVirtualMemorySize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVisibleMemorySize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfProcesses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 543);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 3);
            this.panel2.Controls.Add(this.dgv_output);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 477);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(622, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 54);
            this.panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(68, 7);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(125, 41);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtbox_delayTime);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(268, 486);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 54);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "s";
            // 
            // txtbox_delayTime
            // 
            this.txtbox_delayTime.Location = new System.Drawing.Point(168, 16);
            this.txtbox_delayTime.Name = "txtbox_delayTime";
            this.txtbox_delayTime.Size = new System.Drawing.Size(95, 22);
            this.txtbox_delayTime.TabIndex = 1;
            this.txtbox_delayTime.Text = "300";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logging delay";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chkbx_log);
            this.panel4.Controls.Add(this.btn_save);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 486);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 54);
            this.panel4.TabIndex = 3;
            // 
            // chkbx_log
            // 
            this.chkbx_log.AutoSize = true;
            this.chkbx_log.Location = new System.Drawing.Point(161, 18);
            this.chkbx_log.Name = "chkbx_log";
            this.chkbx_log.Size = new System.Drawing.Size(54, 21);
            this.chkbx_log.TabIndex = 2;
            this.chkbx_log.Text = "Log";
            this.chkbx_log.UseVisualStyleBackColor = true;
            this.chkbx_log.CheckedChanged += new System.EventHandler(this.chkbx_log_CheckedChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(43, 7);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 41);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save Log";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_output
            // 
            this.dgv_output.AllowUserToAddRows = false;
            this.dgv_output.AllowUserToDeleteRows = false;
            this.dgv_output.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Time,
            this.FreePhysicalMemory,
            this.FreeSpaceInPagingFiles,
            this.FreeVirtualMemory,
            this.SizeStoredInPagingFiles,
            this.TotalVirtualMemorySize,
            this.TotalVisibleMemorySize,
            this.NumberOfProcesses});
            this.dgv_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_output.Location = new System.Drawing.Point(0, 0);
            this.dgv_output.Name = "dgv_output";
            this.dgv_output.RowHeadersWidth = 51;
            this.dgv_output.RowTemplate.Height = 24;
            this.dgv_output.Size = new System.Drawing.Size(880, 477);
            this.dgv_output.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            // 
            // FreePhysicalMemory
            // 
            this.FreePhysicalMemory.HeaderText = "Free Physical Memory";
            this.FreePhysicalMemory.MinimumWidth = 6;
            this.FreePhysicalMemory.Name = "FreePhysicalMemory";
            // 
            // FreeSpaceInPagingFiles
            // 
            this.FreeSpaceInPagingFiles.HeaderText = "Free Space In Paging Files";
            this.FreeSpaceInPagingFiles.MinimumWidth = 6;
            this.FreeSpaceInPagingFiles.Name = "FreeSpaceInPagingFiles";
            // 
            // FreeVirtualMemory
            // 
            this.FreeVirtualMemory.HeaderText = "Free Virtual Memory";
            this.FreeVirtualMemory.MinimumWidth = 6;
            this.FreeVirtualMemory.Name = "FreeVirtualMemory";
            // 
            // SizeStoredInPagingFiles
            // 
            this.SizeStoredInPagingFiles.HeaderText = "Size Stored In Paging Files";
            this.SizeStoredInPagingFiles.MinimumWidth = 6;
            this.SizeStoredInPagingFiles.Name = "SizeStoredInPagingFiles";
            // 
            // TotalVirtualMemorySize
            // 
            this.TotalVirtualMemorySize.HeaderText = "Total Virtual Memory Size";
            this.TotalVirtualMemorySize.MinimumWidth = 6;
            this.TotalVirtualMemorySize.Name = "TotalVirtualMemorySize";
            // 
            // TotalVisibleMemorySize
            // 
            this.TotalVisibleMemorySize.HeaderText = "Total Visible Memory Size";
            this.TotalVisibleMemorySize.MinimumWidth = 6;
            this.TotalVisibleMemorySize.Name = "TotalVisibleMemorySize";
            // 
            // NumberOfProcesses
            // 
            this.NumberOfProcesses.HeaderText = "Number Of Processes";
            this.NumberOfProcesses.MinimumWidth = 6;
            this.NumberOfProcesses.Name = "NumberOfProcesses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 543);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Memory Usage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_delayTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.CheckBox chkbx_log;
        private System.Windows.Forms.DataGridView dgv_output;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreePhysicalMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeSpaceInPagingFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeVirtualMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeStoredInPagingFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVirtualMemorySize;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVisibleMemorySize;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfProcesses;
    }
}

