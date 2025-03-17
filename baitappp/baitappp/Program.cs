using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitappp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tong = 0;
            int[] mang = new int[5];
            mang[0]= 4;
            mang[1]= 14;
            mang[2]= 2;
            mang[3]= 6;
            mang[4]= 1;

            for (int i = 0; i < mang.Length; i++) 
            { 
                Console.WriteLine(mang[i]);
            }
            for (int i = 0; i < mang.Length; i++) 
            {
                
                 tong = tong + mang[i];
               
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Tong:"+tong);
        }

    }
}
