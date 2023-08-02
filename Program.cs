namespace myapp1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter 4 digit number");
        int a = Convert.ToInt32(Console.ReadLine());
        int d = 0;
        int zerocount = 0;
        int oddcount = 0;
        int evencount = 0;
        //arnav raju
        for (int j = 0; j < 4; j++)
        {
            d = a % 10;
            if (d == 0)
            {
                zerocount++;
            }
            else if ((d % 2) == 0)
            {
                evencount++;
            }
            else
            {
                oddcount++;
            }
            a = a / 10;
        }
        Console.WriteLine("zeros:"+zerocount+" even numbers:"+evencount+" odd numbers:"+oddcount);
    }
}

