using System;
using System.Runtime.InteropServices;

namespace DuvyGuard_Firewall
{
    internal static class BlockIP
    {
        [DllImport("Iphlpapi", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SetTcpEntry(IntPtr pTcprow);

        [DllImport("Iphlpapi", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int SetUdpEntry(IntPtr pTcprow);

        [DllImport("WSOCK32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int htons(int netshort);

        public static void FinalizarConexionTCP(string locIP, string locPort, string remIP, string remPort)
        {
            try
            {
                string[] strArray1 = locIP.Split('.');
                string[] strArray2 = remIP.Split('.');
                byte[] numArray1 = new byte[4]
                {
                    byte.Parse(strArray1[0]),
                    byte.Parse(strArray1[1]),
                    byte.Parse(strArray1[2]),
                    byte.Parse(strArray1[3])
                };
                byte[] numArray2 = new byte[4]
                {
                    byte.Parse(strArray2[0]),
                    byte.Parse(strArray2[1]),
                    byte.Parse(strArray2[2]),
                    byte.Parse(strArray2[3])
                };
                TcpInfo structure = new TcpInfo
                {
                    cnxLocAdr = BitConverter.ToInt32(numArray1, 0),
                    cnxLocPort = htons(int.Parse(locPort)),
                    cnxRemAdr = BitConverter.ToInt32(numArray2, 0),
                    cnxRemPort = htons(int.Parse(remPort)),
                    cnxState = 12
                };
                IntPtr num = Marshal.AllocCoTaskMem(Marshal.SizeOf(structure));
                Marshal.StructureToPtr(structure, num, false);
                SetTcpEntry(num);
                Marshal.FreeHGlobal(num);
            }
            catch (Exception ex)
            {
                // Manejar la excepción de una manera adecuada a tu aplicación
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private struct TcpInfo
        {
            public int cnxState;
            public int cnxLocAdr;
            public int cnxLocPort;
            public int cnxRemAdr;
            public int cnxRemPort;
        }
    }
}
