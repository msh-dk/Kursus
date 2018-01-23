namespace Module03_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt32 = 10;
            myInt32 += 1;


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
