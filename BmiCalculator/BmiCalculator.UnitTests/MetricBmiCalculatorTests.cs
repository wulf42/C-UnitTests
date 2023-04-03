using BmiCalculator.Calculator;
using NUnit.Framework;

namespace BmiCalculator.UnitTests
{
    public class MetricBmiCalculatorTests
    {
        [Test]
        //Weight, Height, Bmi
        [TestCase(100, 170, 34.6)]
        [TestCase(73.5, 180, 22.69)]
        [TestCase(60, 180, 18.52)]
        [TestCase(250, 165, 91.83)]

        public void CalculateBmi_ForGivenCorrectWeightAndHeight_ReturnsCorrectBmi(double weight, double height, double bmiResult)
        {
            //Arange
            MetricBmiCalculator metricBmiCalculator = new MetricBmiCalculator();

            //Act
            var result = metricBmiCalculator.CalculateBmi(weight, height);

            //Assert
            Assert.That(result, Is.EqualTo(bmiResult));

        }
    }
}
