using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pexeso_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Hra pexeso = new Hra();


            string PrvniKarta = "0";
            string DruhaKarta = "0";



          



            while (1 > 0)
            {
                for (int i = 0; i < 1; i++)
                {

                    Console.Write("Zadejte první souřadnici X: ");
                    pexeso.x1 = Convert.ToInt32(Console.ReadLine());

                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("Zadejte druhou souřadnici Y:");
                        pexeso.y1 = Convert.ToInt32(Console.ReadLine());

                        pexeso.pexesoSkryte[pexeso.x1 - 1, pexeso.y1 - 1] = pexeso.pexesoOdkryte[pexeso.x1 - 1, pexeso.y1 - 1];
                        Console.Clear();
                        pexeso.VýpisHRY();

                        PrvniKarta = pexeso.pexesoOdkryte[pexeso.x1 - 1, pexeso.y1 - 1];


                    }
                }
                for (int i = 0; i < 1; i++)
                {
                    Console.Write("Zadejte první souřadnici X: ");
                    pexeso.x2 = Convert.ToInt32(Console.ReadLine());

                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("Zadejte druhou souřadnici Y:");
                        pexeso.y2 = Convert.ToInt32(Console.ReadLine());

                        pexeso.pexesoSkryte[pexeso.x2 - 1, pexeso.y2 - 1] = pexeso.pexesoOdkryte[pexeso.x2 - 1, pexeso.y2 - 1];
                        Console.Clear();
                        pexeso.VýpisHRY();

                        DruhaKarta = pexeso.pexesoOdkryte[pexeso.x2 - 1, pexeso.y2 - 1];

                    }

                }
                Console.ReadKey();


                if (!(PrvniKarta == DruhaKarta))
                {
                    pexeso.pexesoSkryte[pexeso.x1 - 1, pexeso.y1 - 1] = "X";
                    pexeso.pexesoSkryte[pexeso.x2 - 1, pexeso.y2 - 1] = "X";
                    Console.Clear();
                    pexeso.VýpisHRY();


                }
            }

            Console.ReadKey();
                
            
        }
    }
}
