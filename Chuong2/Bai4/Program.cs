    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] M = new int[n, n];
            
            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    M[i, j] = int.Parse(inputLine[j]);
                }
            }
            
            int[] dln = DLN(n, M);
            int[] tnht = TNHT(n, M);
            int[] kttn = KTTN(n, M);

            Console.WriteLine(string.Join(" ", dln));
            Console.WriteLine(string.Join(" ", tnht));
            Console.WriteLine(string.Join(" ", kttn));
        }
        
        static int[] DLN(int n, int[,] M)
        {
            int maxdiem = 0;
            int[] dln = new int[n];
            int slmaxdiem = 0;

            for (int i = 0; i < n; i++)
            {
                int diemcuadoi = 0;
                for (int j = 0; j < n; j++)
                {
                    if (M[i, j] == 3)
                        diemcuadoi += 3;
                    else if (M[i, j] == 1)
                        diemcuadoi += 1;
                }

                if (diemcuadoi > maxdiem)
                {
                    maxdiem = diemcuadoi;
                    dln[0] = i + 1;
                    slmaxdiem = 1;
                }
                else if (diemcuadoi == maxdiem)
                {
                    dln[slmaxdiem] = i + 1;
                    slmaxdiem++;
                }
            }
            int[] kqa = new int[slmaxdiem];
            Array.Copy(dln, kqa, slmaxdiem);
            return kqa;
        }
        
        static int[] TNHT(int n, int[,] M)
        {
            int[] tnht = new int[n];
            int slthang = 0;

            for (int i = 0; i < n; i++)
            {
                int thang = 0;
                int thua = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        if (M[i, j] == 3)
                            thang++;
                        else if (M[i, j] == 0)
                            thua++;
                    }
                }
                if (thang > thua)
                {
                    tnht[slthang] = i + 1;
                    slthang++;
                }
            }
            int[] kqb = new int[slthang];
            Array.Copy(tnht, kqb, slthang);
            return kqb;
        }
        
        static int[] KTTN(int n, int[,] M)
        {
            int[] kttn = new int[n];
            int slkttn = 0;

            for (int i = 0; i < n; i++)
            {
                bool thang = true;
                for (int j = 0; j < n; j++)
                {
                    if (i != j && M[i, j] == 0)
                    {
                        thang = false;
                        break;
                    }
                }
                if (thang)
                {
                    kttn[slkttn] = i + 1;
                    slkttn++;
                }
            }
            int[] kqc = new int[slkttn];
            Array.Copy(kttn, kqc, slkttn);
            return kqc;
        }
    }
