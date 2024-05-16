using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SinemaUygulamasi
{
    internal class Sinema
    {
        public string FilmAdi { get; }
        public int Kapasite{ get;  }
        public int TamBiletFiyati{ get;  }
        public int YarimBiletFiyati{ get; }
        public int ToplamTamBiletAdeti{ get; private set; }
        public int ToplamYarimBiletAdeti{ get; private set; }
        public float Ciro
        {
            get
            {
                return (this.ToplamTamBiletAdeti * this.TamBiletFiyati) + (this.ToplamYarimBiletAdeti * this.YarimBiletFiyati);
            }
        }


        public Sinema(string filmAdi, int kapasite, int tam, int yarim)
        {
            this.FilmAdi = filmAdi;
            this.Kapasite = kapasite;
            this.TamBiletFiyati = tam;
            this.YarimBiletFiyati = yarim;
        }

        public void BiletSatisi(int tamBiletAdeti, int yarimBiletAdeti)
        {
            if (tamBiletAdeti + yarimBiletAdeti <= BosKoltukAdetiGetir()  )
            {
                this.ToplamTamBiletAdeti += tamBiletAdeti;
                this.ToplamYarimBiletAdeti += yarimBiletAdeti;

                

                Console.WriteLine("İşlem gerçekleşti.");

            }
            else
            {
                Console.WriteLine(BosKoltukAdetiGetir()  + " adet boş koltuk olduğundan işlem gerçekleşmedi.");
            }
        }

        public void BiletIadesi(int tamBiletAdeti, int yarimBiletAdeti)
        {
            if ( tamBiletAdeti <= this.ToplamTamBiletAdeti && yarimBiletAdeti <= this.ToplamYarimBiletAdeti  )
            {
                this.ToplamTamBiletAdeti -= tamBiletAdeti;
                this.ToplamYarimBiletAdeti -= yarimBiletAdeti;


                Console.WriteLine("İşlem gerçekleşti.");
            }
            else
            {
                Console.WriteLine("Satılmış olan bilet sayısından fazla iade yapılamaz.");
            }
           
        }

      

        public int BosKoltukAdetiGetir()
        {
            return this.Kapasite - this.ToplamTamBiletAdeti - this.ToplamYarimBiletAdeti;
        }

    }
}
