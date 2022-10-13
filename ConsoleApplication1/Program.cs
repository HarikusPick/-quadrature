using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac, sayac2 ,sayi;
            sayac = 0;
            sayac2 = 0;
            const string a = "\n";
            const string b = "*";
            string yildiz;
            yildiz = "";

            Console.Write("SAYI :");
            sayi = Convert.ToInt16(Console.ReadLine());
            line:
            yildiz = yildiz + b;
            sayac = sayac + 1;
            if (sayac < sayi)
            {
                goto line;
            }
            if (sayac == sayi)
            {
                sayac = 0;
                yildiz = yildiz + a;
                
                if (sayac2 == (sayi - 1))
                {
                    goto xxx;
                }
                sayac2 = sayac2 + 1;
                    goto line;
            }
            xxx:
            Console.Write(yildiz);





            Console.ReadLine();

            


        }
    }
}
