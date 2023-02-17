using System;

namespace uppgiftett_Enivå
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in A för rektanglen, alltså bredd");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("skriv in B för rektanglen, alltså höjd");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Arean för rektanglen är{AREAA(A,B)}");

        }
        static int AREAA (int A, int B)
        {
           int AREA = A * B;
           return AREA;
        }
    }
}