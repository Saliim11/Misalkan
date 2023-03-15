using System;

namespace Modul4
{
    class Program
    {
        static void Main()
        {
            // 3-vi. Terdapat bagian dari method utama / main yang memanggil class dan method yang dibuat sebelumnya[max 5 pts]
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Apel));
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Semangka));

            // 5-viii. Terdapat method utama/main yang memanggil dan mencoba semua state [max 5 pts]
            // tidak harus semua state dicoba, yang penting output yang diminta di soal dicoba
            PosisiKarakterGame posisiChar = new PosisiKarakterGame();
            Console.WriteLine(posisiChar.currentState);
            // ubah ke terbang
            posisiChar.tekanTombol(PosisiKarakterGame.TriggerPosisi.TombolW);
            Console.WriteLine(posisiChar.currentState);
            // ubah ke jongkok
            posisiChar.tekanTombol(PosisiKarakterGame.TriggerPosisi.TombolX);
            Console.WriteLine(posisiChar.currentState);
            // ubah ke tengkurap -> output keluar posisi istirahat
            posisiChar.tekanTombol(PosisiKarakterGame.TriggerPosisi.TombolS);
            Console.WriteLine(posisiChar.currentState);
            // ubah ke jongkok kemudian berdiri -> output keluar posisi standby
            posisiChar.tekanTombol(PosisiKarakterGame.TriggerPosisi.TombolW);
            posisiChar.tekanTombol(PosisiKarakterGame.TriggerPosisi.TombolW);
            Console.WriteLine(posisiChar.currentState);
        }
    }
}