namespace ComputeDemo12
{
    internal class ComputeDemo
    {
        static void Main(string[] args)
        {
            int dividend = 7,divisor = 6;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();

        }
    }
}