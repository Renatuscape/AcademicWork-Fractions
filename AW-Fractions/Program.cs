namespace AW_Fractions
{
    public  class Program
    {
        static void Main()
        {
            Fraction fractionA = new(1, 3);
            Fraction fractionB = new(2, 4);

            Fraction other = Fraction.Add(fractionA, fractionB);
            Console.WriteLine(other);
            Console.WriteLine(Fraction.GetGreater(fractionA, fractionB));
        }
    }
}