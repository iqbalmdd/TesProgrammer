using System;
using TesProgrammer.src;

class Program {
    public static void Main() {
        // No.1
        ProgramService.No1();
        Console.WriteLine();

        // No.2a
        ProgramService.No2a();
        Console.WriteLine();

        // No.2b
        ProgramService.No2b();
        Console.WriteLine();

        // No.2c
        ProgramService.No2c();
        Console.WriteLine();

        // No.2d
        ProgramService.No2d();
        Console.WriteLine();

        // No.3
        int[] n = [12,9,13,6,10,4,7,2];
        int[] result = ProgramService.No3(n);
        foreach (var number in result)
        {
            Console.Write($"{number} ");
        }

        // No.4
        // .src/no4.sql
    }
}
