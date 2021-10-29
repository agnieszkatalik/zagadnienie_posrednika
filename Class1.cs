using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zag_pos
{
    class Calculations
    {
       // public Form1 form = new Form1();
        public int m = Form1.rowCount; // m dostawcy
        public int n = Form1.columnCount; // n odbiorcy

        public int[] podaz;
        public int[] popyt;
        public int[] kZ; // kZ koszt zakupu
        public int[] c; // c cena sprzedazy
        public int[][] kT; // kT koszt transportu
        public int[][] zC; // zC zysk calkowity = cena sprzedazy - koszt zakupu - koszt transportu

        public int suma_podaz = 0;
        public int suma_popyt = 0;

        public void calculator(int n, int m)
        {
            podaz = new int[m + 1];
            popyt = new int[n + 1];
            kZ = new int[m];
            c = new int[n];
            kT= new int[n][]; // kT koszt transportu
            zC = new int[m+1][];

        }

        public void calculate()
        {

        }
    }

}
