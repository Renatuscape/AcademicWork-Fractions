namespace AW_Fractions.UnitTesting
{
    public class Fraction_Method_Testing
    {
        [Test]
        public void Add_TwoFractioins_ReturnCorrectResult()
        {
            //Arrange
            Fraction fractionA = new(2, 4);
            Fraction fractionB = new(1, 2);
            Fraction expected = new(8, 8);

            //ACT
            Fraction actual = Fraction.Add(fractionA, fractionB);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Multiply_TwoFractions_ReturnCorrectResult()
        {
            //Arrange
            Fraction fractionA = new(1, 2);
            Fraction fractionB = new(2, 4);
            Fraction expected = new(2, 8);

            //ACT
            Fraction actual = Fraction.Multiply(fractionA, fractionB);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Equals_CompareTwoFractions_ReturnCorrectResult()
        {
            //Arrange
            Fraction fractionA = new(2, 4);
            Fraction fractionB = new(2, 4);

            //ACT
            bool actual = Fraction.Equals(fractionA, fractionB);

            //Assert
            Assert.That(actual, Is.True);
        }
    }
}