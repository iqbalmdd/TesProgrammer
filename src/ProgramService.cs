namespace TesProgrammer.src
{
    public static class ProgramService
    {
        public static void No1() {
            Console.WriteLine("\n====No. 1=====");
            Console.Write("Masukan Angka Pertama : ");
            int init = int.Parse(Console.ReadLine());
            Console.Write("Masukan Angka Terakhir : ");
            int final = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = init; i < final+1; i++)
            {

                if (i % 3 == 0 && i % 4 == 0)
                {
                    Console.Write("OKYES ");
                    continue;
                } else if (i % 4 == 0)
                {
                    Console.Write("YES ");
                    continue;
                } else if (i % 3 == 0)
                {
                    Console.Write("OK ");
                    continue;
                } else {
                    Console.Write($"{i} ");
                }
            }
        }

        public static void No2a() {
            Console.WriteLine("\n====No. 2a=====");
            Console.Write("Masukan Angka : ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i < input+1; i++) {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public static void No2b() {
            Console.WriteLine("\n====No. 2b=====");
            Console.Write("Masukan Angka : ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i < input+1; i++) {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i-j);
                }
                Console.WriteLine();
            }
        }

        public static void No2c() {
            Console.WriteLine("\n====No. 2c=====");
            Console.Write("Masukan Angka : ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int k = 1;
            bool flag = false;
            for (int i = 1; i < input+1; i++) {
                for (int j = 0; j < i; j++)
                {
                    if (k == input || k == 1) {
                        flag = !flag;
                    }
                    if (flag == true )
                    {
                        Console.Write(k);
                        k++;
                        
                    }
                    if (flag == false)
                    {
                        Console.Write(k);
                        k--;
                        
                    }
                }
                Console.WriteLine();
            }
        }

        public static void No2d() {
            Console.WriteLine("\n====No. 2d=====");
            Console.Write("Masukan Angka : ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int k = 1;
            for (int i = 1; i < input+1; i++) {
                for (int j = 0; j < input; j++)
                {
                    if (j % 2 == 0) // 0 2 4
                    {
                        Console.Write($"{(input * j) + i} ");
                    }
                    if (j % 2 != 0) // 1 3
                    {
                        Console.Write($"{input * (j + 1) - (i-1)} ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static int[] No3(int[] input) {
            Console.WriteLine("\n====No. 3=====");
            List<int> outputList = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 3 != 0)
                {
                    outputList.Add(input[i]);
                    
                }
            }
            int[] output = outputList.ToArray();
            Array.Sort(output);
            return output;
        }
    }
}