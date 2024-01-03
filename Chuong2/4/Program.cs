﻿namespace sodongian
{
    class programm
    {
        static void Main(string[] args)
        {
            int n,s=0,kq=0;
            n=int.Parse(Console.ReadLine());
            while (n>0)
            {
                s += n%10;
                n=n/10;
            }
            while (s>0)
            {   
                kq+=s%10;
                s =s/10;
            }
            Console.WriteLine(kq);
        }
    }
}