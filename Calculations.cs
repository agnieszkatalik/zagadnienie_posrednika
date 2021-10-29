using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace zag_pos
{
    class Calculations
    {
        public Form1 form = new Form1();
        public int m; // m dostawcy
        public int n; // n odbiorcy

        public int[] podaz;
        public int[] popyt;
        public int[] kZ; // kZ koszt zakupu
        public int[] c; // c cena sprzedazy
        public int[][] kT; // kT koszt transportu
        public int[][] zC; // zC zysk calkowity = cena sprzedazy - koszt zakupu - koszt transportu

        public int suma_podaz = 0;
        public int suma_popyt = 0;

        public static int[] alpha;
        public static int[] beta;
        public int[] alpha1;
        public int[] beta1;

        private int[][] tablicaLiczb;// tablica pomocnicza

        public void calculator(int n, int m)
        {
            this.m = m;
            this.n = n;
            podaz = new int[m + 1];
            popyt = new int[n + 1];
            kZ = new int[m];
            c = new int[n];
            kT = new int[m][];/////tu
            zC = new int[m + 1][];

            alpha = new int[m + 1];
            beta = new int[n + 1];
            alpha1 = new int[m + 1];
            beta1 = new int[n + 1];

        }

        public void calculate()
        {
            int tmp=(Form1.dataCounter)-m;  // działa
            for (int i = 0; i < m; i++)
            {
                podaz[i] = Form1.dataArr[i];
                suma_podaz += podaz[i];

                kZ[i] = Form1.dataArr[tmp];
                tmp++;
            }

            tmp = m;
            for (int i = 0; i < n; i++) // działa
            {
                popyt[i] = Form1.dataArr[tmp];
                suma_popyt += popyt[i];
                c[i] = Form1.dataArr[tmp + m + 1];

                tmp = tmp + m + 2;
            }

            tmp = m+1;
            for (int i = 0; i < m; i++) // koszty transportu dla poszczególnych tras
            {
                kT[i] = new int[n]; // działa
                for (int j = 0; j < n; j++)
                {
                   kT[i][j] = Form1.dataArr[tmp];
                    int ttttt = Form1.dataArr[tmp];
                    tmp += m + 2;
                }

                tmp = m+i+2;
            }

        }

        public void zyskCalkowity()
        {
            if (suma_popyt == suma_podaz)
            {
                zC = new int[m][]; // zC zysk calkowity = cena sprzedazy - koszt zakupu - koszt transportu

                for (int i = 0; i < m; i++)
                {
                    zC[i] = new int[n];
                    for (int j = 0; j < n; j++)
                    {
                        zC[i][j] = c[j] - (kZ[i] + kT[i][j]);
                    }
                }
            }
        }

        public void funkcja()
        {
            if (suma_popyt == suma_podaz)
            {
                zC = new int[m][]; // zC zysk calkowity = cena sprzedazy - koszt zakupu - koszt transportu
                for (int i = 0; i < m; i++)
                {
                    zC[i] = new int[n];
                    for (int j = 0; j < n; j++)
                    {
                        zC[i][j] = c[j] - (kZ[i] + kT[i][j]);
                    }
                }
            }
            else
            {

                podaz[m] = suma_popyt;
                popyt[n] = suma_podaz;

                zC = new int[m + 1][]; // zC zysk calkowity = cena sprzedazy - koszt zakupu - koszt transportu

                for (int i = 0; i < m + 1; i++)
                {
                    zC[i] = new int[n + 1];
                    for (int j = 0; j < n + 1; j++)
                    {
                        zC[i][j] = 0;
                    }
                }

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        zC[i][j] = c[j] - (kZ[i] + kT[i][j]);
                    }
                }

                int max = zC[0][0];
                int min = zC[0][0];

                int[] podaz1 = new int[m + 1];
                int[] popyt1 = new int[n + 1];

                for (int i = 0; i < n + 1; i++)
                {
                    popyt1[i] = popyt[i];
                }

                for (int i = 0; i < m + 1; i++)
                {
                    podaz1[i] = podaz[i];
                }

                tablicaLiczb = new int[m + 1][]; // tablica pomocnicza


                for (int i = 0; i < m + 1; i++)
                {
                    tablicaLiczb[i] = new int[n + 1];
                    for (int j = 0; j < n + 1; j++)
                    {
                        tablicaLiczb[i][j] = -1;
                    }
                }

                for (int i = 0; i < m + 1; i++)
                {
                    for (int j = 0; j < n + 1; j++)
                    {

                        if (min > zC[i][j])
                        {
                            min = zC[i][j];
                        }

                    }
                }

                //szukamy od maksymalnej wartosci z macierzy do minimalnej, i wg tego obslugujemy 

                int licznik = m * n;
                int ii = 0;
                int jj = 0;

                while (licznik != 0)
                {
                    max = min - 1;

                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (max < zC[i][j] && tablicaLiczb[i][j] < 0)
                            {
                                max = zC[i][j];
                                ii = i;
                                jj = j;
                            }
                        }
                    }

                    // sprawdzamy czy w ogole jest popyt dla tej pozycji
                    // juz widze blad opisujac, ze nie uwzglednilam co jesli podaz nie jest wystarczajaca, zeby zaspokoic popyt :( 
                    // tablica liczb przyjmuje 3 wersje: liczba > 0 jesli dokonalismy przekazania towaru dostawcy (liczba wskazuje ile), 0 jesli popyt w tym miejscu jest juz zerowy, i -1 jesli w ogole tam nie bylismy

                    if (popyt[jj] != 0)
                    {

                        if (podaz1[ii] > popyt1[jj])
                        {
                            podaz1[ii] = podaz1[ii] - popyt1[jj];
                            tablicaLiczb[ii][jj] = popyt1[jj];
                            popyt1[jj] = 0;
                        }
                        else if (podaz1[ii] < popyt1[jj])
                        {
                            popyt1[jj] = popyt1[jj] - podaz1[ii];
                            tablicaLiczb[ii][jj] = podaz1[ii];
                            podaz1[ii] = 0;

                        }
                        else
                        {
                            tablicaLiczb[ii][jj] = podaz1[ii];
                            podaz1[ii] = 0;
                            popyt[jj] = 0;

                        }
                    }
                    else
                        tablicaLiczb[ii][jj] = 0;

                    licznik--;
                }

                // tutaj obsluga fikcyjnego dostawcy i odbiorcy 

                for (int i = 0; i < n; i++)
                {
                    if (popyt1[i] != 0)
                    {
                        podaz1[m] = podaz1[m] - popyt1[i];
                        tablicaLiczb[m][i] = popyt1[i];
                        popyt1[i] = 0;
                    }
                }

                for (int i = 0; i < m; i++)
                {
                    if (podaz1[i] != 0)
                    {
                        popyt1[n] = popyt1[n] - popyt1[i];
                        tablicaLiczb[i][n] = podaz1[i];
                        podaz1[i] = 0;
                    }
                }

                if (popyt1[n] != 0)
                {
                    popyt1[n] -= podaz1[m];
                    tablicaLiczb[m][n] = podaz1[m];
                    podaz1[m] = 0;

                }

                if (podaz1[m] != 0)
                {
                    podaz[m] -= popyt1[n];
                    tablicaLiczb[m][n] = popyt1[n];
                    popyt1[n] = 0;
                }

                

            }

        }

        public void alphaBeta()
            {
                // zmienne dualne
                for (int i = 0; i < m + 1; i++)
                {
                    alpha[i] = 0;
                    alpha1[i] = 0;
                    for (int j = 0; j < n + 1; j++)
                    {
                        beta[j] = 0;
                        beta1[j] = 0;
                    }
                }

                int x = m;
                int y = n + 1;

                alpha[m] = 0;
                alpha1[m] = 1;

            // obliczanie alpha i beta

            while (y > 0 || x > 0)
            {
                for (int i = m; i != -1; i--)
                {
                    for (int j = n; j != -1; j--)
                    {
                        if (i == m && tablicaLiczb[i][j] > 0)
                        {
                            if (beta1[j] != 1)
                            {
                                beta[j] = zC[i][j] - alpha[i];
                                beta1[j] = 1;
                                y--;
                            }
                        }
                        else
                        {
                            if (alpha1[i] == 1 && tablicaLiczb[i][j] > 0)
                            {
                                if (beta1[j] != 1)
                                {
                                    beta[j] = zC[i][j] - alpha[i];
                                    beta1[j] = 1;
                                    y--;
                                }
                            }
                            if (beta1[j] == 1 && tablicaLiczb[i][j] > 0)
                            {
                                if (alpha1[i] != 1)
                                {
                                    alpha[i] = zC[i][j] - beta[j];
                                    alpha1[i] = 1;
                                    x--;
                                }
                            }
                        }
                    }
                }
            }

            // form.alp(alpha);
            // form.bet(beta);
        }
    }

}
