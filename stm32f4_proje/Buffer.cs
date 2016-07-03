using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stm32f4_proje
{
    class Buffer
    {
        
        public char[] cevrel_buffer = new char [1024];
        public int bas;
        public int son;

        public void verileri_cevrel_buffera_ekle(char[]okunan_veriler_dizisi,int okunan_bayt_sayisi)
        {
            int sayac = 0;
            for (sayac = 0; sayac < okunan_bayt_sayisi; sayac++)
            {
                if (bas >= 1024)
                {
                    bas = 0;
                }
                cevrel_buffer[bas] = okunan_veriler_dizisi[sayac];
                bas++;
            }


        }

        public int okunan_bayt(ref char[] okunan_veriler )
        {
            int sonuc = bas - son;

            if (sonuc > 0)
            {
                for (int i = 0; i < sonuc; i++)
                {
                    okunan_veriler[i] = cevrel_buffer[son];
                    son++;
                }
            }

            if (sonuc < 0)
            {
                sonuc = 1024 - son;
                sonuc = sonuc + bas;

                for (int i = 0; i < sonuc; i++)
                {
                    if (son > 1023)
                    {
                        son = 0;
                    }
                    okunan_veriler[i] = cevrel_buffer[son];
                    son++;
                }


            }

            return sonuc;
        }
    };
}
