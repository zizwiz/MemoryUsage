using System.Text;
using System.Runtime.InteropServices;

namespace Memory_Usage
{
    public static class NumberExtensions
    {
        [DllImport("Shlwapi.dll", CharSet = CharSet.Auto)]
        public static extern int StrFormatByteSize(
            long fileSize,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder buffer,
            int bufferSize);

        // Return a file size created by the StrFormatByteSize API function.
        public static string ToFileSizeApi(this ulong file_size)
        {
            StringBuilder sb = new StringBuilder(20);
            StrFormatByteSize((long)file_size, sb, 20);
            return sb.ToString();
        }
    }
}
