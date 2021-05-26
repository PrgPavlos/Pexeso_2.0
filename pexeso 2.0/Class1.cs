using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pexeso_2._0
{
    class Hra
    {

        public int x1;
        public int y1;
        public int x2;
        public int y2;


        public string[,] pexesoSkryte = {
            { "X", "X", "X", "X" },
            { "X", "X", "X", "X" },
            { "X", "X", "X", "X" },
            { "X", "X", "X", "X" }
        };

        public string[,] pexesoOdkryte = {
                { "A", "A", "B", "B" },
                { "C", "C", "D", "D" },
                { "E", "E", "F", "F"},
                { "G", "G", "H", "H" }
        };

        
        public void VýpisHRY()
        {
            for (int j = 0; j < pexesoOdkryte.GetLength(1); j++)
            {
                for (int i = 0; i < pexesoOdkryte.GetLength(0); i++)
                {
                    Console.Write(pexesoSkryte[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void Zamichani()
        {
            int opakovani = 4;
            int opakovani_ = 0;
            
            string[] karty = { "A", "B", "C", "D", "E", "F", "G", "H", "A", "B", "C", "D", "E", "F", "G", "H" };
            List<int> pozice_list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                while (opakovani_ < 4)
                {
                    for (int l = 0; l < opakovani; l++)
                    {
                        int pozice = random.Next(0, 16);
                        if (!(pozice_list.Contains(pozice)))
                        {

                            pozice_list.Add(pozice);
                            pexesoOdkryte[i, opakovani_] = karty[pozice];
                            opakovani_++;


                        }
                        else
                        {
                            opakovani++;
                        }
                    }
                }

            }
        }

        



    }
}
