using System;

namespace ConsoleApp1
{
    class Data_class
    {
        public int a, b, c, d, e;
        public int[][] f;
        public Random rand = new Random();

        public Data_class(int n)
        {
            (a, b, c, d, e) = (rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10));
            f = new int[n][];
            for (int i=0; i < n; i++)
            {
                f[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                   f[i][j] = rand.Next(1, 10);
                }
            }
        }
        public int this[int i, int j]
        {
            set
            {
                f[i][j] = value;
            }
            get
            {
                return f[i][j];
            }
        } 
        public int this[string index]
        {
            get
            {
                if (index == "e")
                {
                    return e;
                }
                if (index == "min")
                {
                    return Min();
                }
                if (index == "max")
                {
                    return Max();
                }
                if (index == "avg_par")
                {
                    return Avg_par();
                }
                else
                {
                    return 0;
                }

            }
        }

        public int this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return a;
                }
                if (index == 1)
                {
                    return b;
                }
                if (index == 2)
                {
                    return c;
                }
                if (index == 3)
                {
                    return d;
                }
                else
                {
                    return 0;
                }

            }
        }

        public int Min()
        {
            int min = f[0][0];
            for (int i=0; i< f.Length; i++)
            {
                for (int j=0; j < f.Length; j++)
                {
                    if (f[i][j] < min)
                    {
                        min = f[i][j];
                    }
                }
            }
            return min;
        }
        public int Max()
        {
            int max = f[0][0];
            for (int i = 0; i < f.Length; i++)
            {
                for (int j = 0; j < f.Length; j++)
                {
                    if (f[i][j] > max)
                    {
                        max = f[i][j];
                    }
                }
            }
            return max;
        }
        public int Avg_par()
        {
            return (a+b+c+d+e)/2;
        }
        public double Avg_arr()
        {
            for (int i = 0; i < f.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < f.Length; j++)
                {
                    sum += f[i][j];
                }
                
            }
            return (a + b + c + d + e) / 2;
        }
        public double Avg_Row(int n)
        {
           
            int sum = 0;
            for (int j = 0; j < f.Length; j++)
            {
                sum += f[n][j];
            }
            return sum / f.Length;
        }
        public double Avg_Row_line()
        {
            string line = "";
            for (int i = 0; i < f.Length; i++)
            {
                line +=  
            }
        }
        public double Avg_Col(int n)
        {

            int sum = 0;
            for (int i = 0; i < f.Length; i++)
            {
                sum += f[i][n];
            }
            return sum / f.Length;
        }

        public void Print()
        {
            Console.WriteLine(a+" "+b+" "+c+" "+d+" "+e);
            Console.WriteLine(Min() + " " + Max() + " " + Avg_par());
            for (int i = 0; i < f.Length; i++)
            {
                string line = " ";
                for (int j = 0; j < f.Length; j++)
                {
                    line += f[i][j] + new string(' ', (3 - Convert.ToString(f[i][j]).Length));
                }
                Console.WriteLine(line);
            }
        }
    }
    class Program
    {
        static Data_class CreateDataClass() 
        {
            Console.WriteLine("Enter Length of the array ");
            int n = Convert.ToInt32(Console.ReadLine());
            return new Data_class(n);
        }
        
        static void Cmp(Data_class cur, int index, string jndex)
        {
            if (cur[index] < cur[jndex])
            {
                Console.WriteLine(index + "(" + cur[index] + ")" + "<" + jndex + "(" + cur[jndex] + ")");
            }
            else
            {
                Console.WriteLine(index + "(" + cur[index] + ")" + ">" + jndex + "(" + cur[jndex] + ")");
            }
        }
        static void Cmp(Data_class cur, string index, string jndex)
        {
            if (cur[index] < cur[jndex])
            {
                Console.WriteLine(index + "(" + cur[index] + ")" + "<" + jndex + "(" + cur[jndex] + ")");
            }
            else
            {
                Console.WriteLine(index + "(" + cur[index] + ")" + ">" + jndex + "(" + cur[jndex] + ")");
            }
        }
        static void Cmp(Data_class cur, int index, int jndex)
        {
            if (cur[index] < cur[jndex])
            {
                Console.WriteLine(index + "(" + cur[index] + ")" + "<" + jndex + "(" + cur[jndex] + ")");
            }
            else
            {
                Console.WriteLine(index + "(" + cur[index] + ")" + ">" + jndex + "(" + cur[jndex] + ")");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Data_class cur = new Data_class(0);
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter Commands");
                string[] words = Console.ReadLine().Split(new Char[] { ' ' });

                if (words[0] == "create")
                {
                   cur = CreateDataClass();
                }
                else if (words[0] == "cmp")
                {
                    Cmp(cur, Convert.ToInt32(words[1]), Convert.ToString(words[2]));
                }
                else if (words[0] == "avg")
                {
                    Console.WriteLine("Average parameter value:" + cur.Avg_par());
                }
                else if (words[1] == "print")
                {
                    cur.Print();
                }
            }
        }
    }
}
