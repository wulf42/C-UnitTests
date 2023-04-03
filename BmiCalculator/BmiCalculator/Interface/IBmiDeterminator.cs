using BmiCalculator.Model;

namespace BmiCalculator.Interface
{
    public interface IBmiDeterminator
    {
        BmiClassification DetermineBmi(double bmi);
    }
}
