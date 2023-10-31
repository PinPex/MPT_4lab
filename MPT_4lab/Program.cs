using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPT_4lab
{
        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Matrix a = new Matrix(3, 3);
                    Matrix b = new Matrix(3, 3);
                    Matrix c;
                    for (int i = 0; i < a.I; i++)
                    {
                        for (int j = 0; j < a.J; j++)
                        {
                            a[i, j] = a.J * i + j;
                        }
                    }
                    Console.WriteLine("Matrix a:\n");
                    a.Show();
                    for (int i = 0; i < a.I; i++)
                    {
                        for (int j = 0; j < a.J; j++)
                        {
                            b[i, j] = a.J * i + j;
                        }
                    }
                    Console.WriteLine("Matrix b:\n");
                    b.Show();

                    Console.WriteLine("a + b:\n");
                    c = a + b;
                    c.Show();
                    Console.WriteLine("\n");

                    Console.WriteLine("a - b:\n");
                    c = a - b;
                    c.Show();
                    Console.WriteLine("\n");

                    Console.WriteLine("a * b:\n");
                    c = a * b;
                    c.Show();
                    Console.WriteLine("\n\n");

                    Console.WriteLine("a == b:\n");
                    bool res = a == b;
                    Console.WriteLine(res + "\n\n");

                    Console.WriteLine("Transpose a:\n");
                    a.Show();
                    c = a;
                    c.Transp();
                    c.Show();
                    Console.WriteLine("\n");

                    Console.WriteLine("Minimum a:\n");
                    a.Show();
                    int m = a.Min();
                    Console.WriteLine("Min a = " + m + "\n\n");

                    Console.WriteLine("ToString a:\n");
                    a.Show();
                    string str = a.Matrix_str();
                    Console.WriteLine("a = " + str + "\n\n");

                    Console.WriteLine("Take elem a[1, 2]:\n");
                    int elem = a.Take_elem(1, 2);
                    Console.WriteLine("a[1, 2] = " + elem + "\n\n");

                    Console.WriteLine("Write elem a[1, 1] = 7:\n");
                    a.Show();
                    c = a;
                    c.Write_elem(2, 0, 7);
                    c.Show();
                    //Console.WriteLine(c + "\n\n");
                }
                catch (MyException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
        }
}