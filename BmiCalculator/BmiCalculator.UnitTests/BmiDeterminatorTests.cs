using BmiCalculator.Model;
using NUnit.Framework;

namespace BmiCalculator.UnitTests
{
    public class BmiDeterminatorTests
    {
        [Test]
        [TestCase(1.0, BmiClassification.Underweight)]
        [TestCase(15.0, BmiClassification.Underweight)]
        [TestCase(10.0, BmiClassification.Underweight)]
        [TestCase(18.4, BmiClassification.Underweight)]
        [TestCase(18.5, BmiClassification.Normal)]
        [TestCase(21.0, BmiClassification.Normal)]
        [TestCase(23.9, BmiClassification.Normal)]
        [TestCase(24.8, BmiClassification.Normal)]
        [TestCase(24.9, BmiClassification.Overweight)]
        [TestCase(25, BmiClassification.Overweight)]
        [TestCase(28, BmiClassification.Overweight)]
        [TestCase(30, BmiClassification.Obesity)]
        [TestCase(32.9, BmiClassification.Obesity)]
        [TestCase(35, BmiClassification.ExtremeObesity)]
        [TestCase(40, BmiClassification.ExtremeObesity)]
        public void DetermineBmi_ForBmiGivenReturnsCorrectClassification(double bmi, BmiClassification classification)
        {
            //Arrange
            BmiDeterminator bmiDeterminator = new BmiDeterminator();


            //Act
            BmiClassification result = bmiDeterminator.DetermineBmi(bmi);

            //Assert
            Assert.That(result, Is.EqualTo(classification));
        }
    }
}
