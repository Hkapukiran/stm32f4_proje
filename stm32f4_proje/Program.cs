using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace stm32f4_proje
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [DllImport("PaketIslemleri.dll")] 
        public static extern void  UINT32_ayir  (byte[] p_veriler_u8,   ref byte  p_paket_sayaci_u8, ref uint  d_gelen_veri_u32);
        
        static void Main()
        {
            //baslangic

            uint a = 254565;
            byte sayac = 0;
            byte[] veriler = new byte[256];

            UINT32_ayir(veriler,ref  sayac,ref  a);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
