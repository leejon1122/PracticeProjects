using System;

class triangleJeff
{
    static void Main()
    {
        int triangle = 1;
        int width;
        int num;
        

        Console.Write("Geef cijfer: ");
        num = Convert.ToInt32(Console.ReadLine());
        //string karakter = Console.ReadLine();

        Console.Write("Geef grootte: ");
        width = Convert.ToInt32(Console.ReadLine());

        int height = width;

        for (int i = 0; i < width; i++)
        {

            for (int j = 0; j < triangle; j++)
            {
                Console.Write(num);
            }

            Console.WriteLine();
            triangle--;
        }

        Console.ReadLine();
    }
}
