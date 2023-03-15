using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4
{
    // 3-i.Terdapat class dengan nama KodeBuah[max 5 pts]
    public class KodeBuah
    {
        // 3-ii. Terdapat enum/struct yang menampung nama-nama buah lengkap[max 5 pts]
        public enum Buah
        {
            Apel,
            Aprikot,
            Alpukat,
            Pisang,
            Paprika,
            Blackberry,
            Ceri,
            Kelapa,
            Jagung,
            Kurma,
            Durian,
            Anggur,
            Melon,
            Semangka
        }

        // 3-iii. Terdapat sebuah method dengan nama getKodeBuah dan input berupa enum [max 5 pts]
        public static String getKodeBuah(Buah namaBuah)
        {
            // 3-iv. Terdapat array yang menampung semua kode pos untuk output di dalam method[max 10 pts]
            String[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };

            // 3-v. Terdapat return value dengan mengakses array dengan index dari hasil konversi enum/struct input ke integer[max 10 pts]
            return kodeBuah[(int)namaBuah];
        }
    }

}
