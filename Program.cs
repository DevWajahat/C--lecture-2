internal class Program
{
    private static void Main(string[] args)
    {
        /* arthemetic operator */
        int num1 = 10;
        int num2 = 2;
        int total;

        total = num1 % num2;

        Console.WriteLine("remainder = "+ total);

        int num3 = 10;
        int num4 = 2;
        int product;

        product = num3 *  num4;
        Console.WriteLine("product = " + product);


        int num5 = 10;
        int num6 = 2;
        int differencetotal;

        differencetotal = num3 - num4;
        Console.WriteLine("differencetotal = " + differencetotal);

        int num7 = 10;
        int num8 = 2;
        int sumtotal;

        sumtotal = num3 + num4;
        Console.WriteLine("total = " + sumtotal);

        /*  comparision operator */

        int a = 4;
        int b = 3;

        if(a == 4)
        {
            Console.WriteLine( "a " + a + "="+ 4 );
        }
        else
        {
            Console.WriteLine( "a " + a +" != 4");
        }

       
       

        if (b == 4)
        {
            Console.WriteLine( "b "+ b + "=" + 4);
        }
        else
        {
            Console.WriteLine( "b " + b + " != 4");
        }

        int c = 4;

        if (c != 4)
        {
            Console.WriteLine("c " + c + "=" + 4);
        }
        else
        {
            Console.WriteLine("c " + c + " != 4");
        }

        int d = 7;

        if(d > 7)
        {
            Console.WriteLine("d " + d +">" + 7);
        }
        else
        {
            Console.WriteLine("d " + d + " <=" + 7);
        }


        int e = 8;

        if (e < 8)
        {
            Console.WriteLine("e " + e + "<" + 8);
        }
        else
        {
            Console.WriteLine("e " + e + " <=" + 8);
        }
        Console.ReadKey();


        /*   */
    }
}