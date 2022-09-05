using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int size = 8;
            int z = 2;
            for (int i = 0; i <= size; i++)
            {
                for (int j = size; j > i; j--)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                if (i > 0)
                {
                    for (int k = 1; k <= z; k++)
                    {
                        Console.Write(" ");
                    }
                    z += 2;
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            z -= 4;

            for (int i = 0; i <= size - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (int k = 1; k <= z; k++)
                {
                    Console.Write(" ");
                }
                z -= 2;

                if (i != size - 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

    */

            /*

            int number = 7;
            for (int i = 0; i < number; i++)
            {
                if (i == 0 || i == 6)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                if (i >= 1 && i <= 5)
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (j == 0 || j == 6)
                        {
                            Console.Write("A");
                        }
                        else if (j >= 1 && j <= 5)
                        {
                            Console.Write("Z");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();

*/
            /*int k1;
            for (k1 = 1; k1 < 5; k1++)
            {
                for (int k2 = 1; k2 < 7; k2++)
                {
                    Console.Write(k1 * k2 + "\t");
                    Console.WriteLine("soy un numero");
                }
                Console.WriteLine();
            }*/

            /*
             //Comparamos for con foreach
             string[] matriz = { "rojo", "verde", "azul", "blanco" };
             int contador;
             for (contador = 0; contador < matriz.Length; contador++)
             {
                 Console.WriteLine(matriz[contador]);
             }

             foreach (string s in matriz)
             {
                 //Console.WriteLine(s);
             }
             */
            /*

           System.Console.WriteLine("Introduce un numero y pintare una piramide");
           int numero = Convert.ToInt32(Console.ReadLine());

           for (int contador = 1; contador <= numero; contador++)
           {
               for (int asteriscos = 1; asteriscos <= contador; asteriscos++)
               {
                   Console.Write("*");
               }
               Console.Write(Environment.NewLine);

               for (int asteriscos = 1; asteriscos <= contador; asteriscos++)
               {
                   Console.Write("$");
               }
               Console.Write(Environment.NewLine);



           }


           for (int contador = 10; contador <= numero; contador++)
           {
               for (int asteriscos = 10; asteriscos <= contador; asteriscos++)
               {
                   Console.Write("#");
               }
               Console.Write(Environment.NewLine);
           }
           */


            int number = 20;

            for (int i = 0; i < number; i++)

            {
                if (i == 0 || i == 6)

                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write("$");
                    }

                    Console.WriteLine();
                }

                if (i >= 1 && i <= 5)
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (j == 0 || j == 6)

                        {
                            Console.Write("%");
                        }

                        else if (j >= 1 && j <= 5)
                        {
                            Console.Write(" ");
                        }

                        if (j == 12)
                        {
                            Console.Write("a");
                        }

                        else if (j >= 7 && j <= 11)
                        {
                            Console.Write(" ");
                        }

                        if (j == 19)
                        {
                            Console.Write("b");
                        }

                        else if (j >= 13 && j <= 18)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }

                /*
                if (i >= 6 && i <= 11)
                {
                    for (int j = 6; j < number; j++)
                    {
                        if (j == 6 || j == 11)
                        {
                            Console.Write("D");
                        }
                        else if (j >= 6 && j <= 11)
                        {
                            Console.Write("");
                        }
                    }

                    //Console.Write();
                }
                */

            }

            /*

            for (int i = 6; i < number; i++)
            {
                if (i >= 6 && i <= 11)
                {
                    for (int j = 6; j < number; j++)
                    {
                        if(j == 6 || j == 11)
                    {
                            Console.Write("D");
                        }
                        else if (j >= 6 && j <= 11)
                        {
                            Console.Write("");
                        }
                    }
                    //Console.Write();
                }

            }
            */


           /* int base1, altura, x, y;
            Console.WriteLine("Ingresar la base del rectangulo:" );
            base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar la altura del rectangulo: ");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            for (x = 1; x <= altura; x++)
            {
                for (y = 1; y <= base1; y++)
                {
                    Console.Write("* ", y);
                }
                Console.WriteLine(" ");
            }*/



            Console.ReadLine();


            // void Program.Print3By3MatrixTranspose();
            Program m = new Program();
            //m.Print3By3MatrixTranspose();

        }


        /*
        public void Print3By3MatrixTranspose()
        {
            // The transpose of a matrix is a new matrix whose rows are the columns of the original.             
            int[,] pos = new int[3, 3]; // declare multidimensional array which accepts 3 rows by 3 columns  
            int rows, cols; // initialize rows and columns  
            Console.WriteLine("Enter value for Matrix:");
            for (rows = 0; rows < 3; rows++)
            {
                for (cols = 0; cols < 3; cols++)
                {
                    pos[rows, cols] = Convert.ToInt32(Console.ReadLine()); // read the 9 digit in the matrix  
                }
            }
            Console.WriteLine("Original Matrix:");
            for (rows = 0; rows < 3; rows++)
            {
                for (cols = 0; cols < 3; cols++)
                {
                    Console.Write(pos[rows, cols] + "\t"); // print the original matrix  
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Transpose of  Matrix:");
            for (rows = 0; rows < 3; rows++)
            {
                for (cols = 0; cols < 3; cols++)
                {
                    Console.Write(pos[cols, rows] + "\t");  // change the row to column   
                }
                Console.WriteLine("");
            }

            Console.ReadLine();

        }
        */







    }
}
