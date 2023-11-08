namespace AW_Fractions
{
    public class Fraction
    {
        #region Fields & Properties
        int Numerator { get; set; }
        int Denominator { get; set; }
        #endregion

        #region Constructors
        public Fraction(int numerator = 0, int denominator = 1)
        {
            Denominator = denominator;
            Numerator = numerator;

        }
        #endregion

        #region Public Methods

        public static Fraction Add(Fraction fractionA, Fraction fractionB)
        {
            var numerator = (fractionA.Numerator * fractionB.Denominator) + (fractionB.Denominator * fractionA.Numerator);
            int denomonator = fractionA.Denominator * fractionB.Denominator;
            return new(numerator, denomonator);
        }

        public static Fraction Multiply(Fraction fractionA, Fraction fractionB)
        {
            var numerator = fractionA.Numerator * fractionB.Numerator;
            var denominator = fractionA.Denominator * fractionB.Denominator;

            return new(numerator, denominator);
        }

        public static bool Equals(Fraction fractionA, Fraction fractionB)
        {
            if (fractionA.Numerator == fractionB.Numerator && fractionA.Denominator == fractionB.Denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Fraction GetGreater(Fraction fractalA, Fraction fractalB)
        {
            double decimalA = (double)fractalA.Numerator / (double)fractalA.Denominator;
            double decimalB = (double)fractalB.Numerator / (double)fractalB.Denominator;

            if (decimalA > decimalB)
            {
                return fractalA;
            }
            else
            {
                return fractalB;
            }
        }
        #endregion

        #region Overrides
        public bool Equals(Fraction other)
        {
            return Numerator == other.Numerator && Denominator == other.Denominator;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Fraction other)
            {
                return Equals(other);
            }

            else
            {
                return false;
            }

        }
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
        #endregion
    }
}