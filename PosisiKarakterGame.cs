using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4
{
    public class PosisiKarakterGame
    {
        // 5-i. Terdapat definisi state dan transisi(trigger) sebagai enum/struct [max 3 pts]
        public enum PosisiState { Berdiri, Jongkok, Tengkurap, Terbang }
        public enum TriggerPosisi { TombolW, TombolS, TombolX }

        // 5-ii. Terdapat struktur data yang mencatat state awal, transisi, dan state akhirnya[max 4 pts]
        public class PerubahanPosisi
        {
            public PosisiState prevState;
            public PosisiState nextState;
            public TriggerPosisi tombol;

            public PerubahanPosisi(PosisiState prevState, PosisiState nextState, TriggerPosisi tombol)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.tombol = tombol;
            }
        }

        // 5-iii. Terdapat peta transisi antar state [max 4 pts]
        PerubahanPosisi[] listPerubahanPosisi = {
            new PerubahanPosisi(PosisiState.Berdiri, PosisiState.Jongkok, TriggerPosisi.TombolS),
            new PerubahanPosisi(PosisiState.Berdiri, PosisiState.Terbang, TriggerPosisi.TombolW),
            new PerubahanPosisi(PosisiState.Terbang, PosisiState.Jongkok, TriggerPosisi.TombolS),
            new PerubahanPosisi(PosisiState.Terbang, PosisiState.Jongkok, TriggerPosisi.TombolX),
            new PerubahanPosisi(PosisiState.Jongkok, PosisiState.Berdiri, TriggerPosisi.TombolW),
            new PerubahanPosisi(PosisiState.Jongkok, PosisiState.Tengkurap, TriggerPosisi.TombolS),
            new PerubahanPosisi(PosisiState.Tengkurap, PosisiState.Jongkok, TriggerPosisi.TombolW)
        };

        // 5-iv. Terdapat atribut yang menyimpan state saat ini dan atribut tersebut di-set ke state awal yang diasumsikan [max 2 pts]
        public PosisiState currentState = PosisiState.Berdiri;

        // 5-v. Terdapat method/fungsi yang mencari state berikutnya [max 5 pts]
        public PosisiState getNextState(PosisiState prevState, TriggerPosisi tombol)
        {
            PosisiState nextState = prevState;

            for (int i = 0; i < listPerubahanPosisi.Length; i++)
            {
                PosisiState posisiKeI = listPerubahanPosisi[i].prevState;
                TriggerPosisi tombolKeI = listPerubahanPosisi[i].tombol;

                if (posisiKeI == prevState && tombolKeI == tombol)
                {
                    nextState = listPerubahanPosisi[i].nextState;
                }
            }

            return nextState;
        }

        // 5-vi. Terdapat method/fungsi yang mengganti state saat ini ke state berikutnya [max 3 pts]
        public void tekanTombol(TriggerPosisi tombol)
        {
            currentState = getNextState(currentState, tombol);

            // 5-vii. Terdapat baris kode yang mengeluarkan output yang sesuai dengan instruksi [max 4 pts]
            // contoh jawaban untuk NIM % 3 == 1
            if (currentState == PosisiState.Berdiri)
            {
                Console.WriteLine("posisi standby");
            }
            else if (currentState == PosisiState.Tengkurap)
            {
                Console.WriteLine("posisi istirahat");
            }
        }
    }

}
