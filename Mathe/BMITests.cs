using System;
using Xunit;
namespace UnitTests.Mathe;

public class BMITests
{
    [Theory]
    [MemberData(nameof(BmiTestsData.bmiNos), MemberType = typeof(BmiTestsData))]
    public void CheckBMI(float height, float weight, float bmi, Scale scale)
    {
        var bmi_ = new BMI(height, weight);
        var scale_ = bmi_.GetScale();

        Assert.Equal(scale, scale_);
    }
}

public class BmiTestsData
{
    // height in cms and weight in grams
    public static object[] bmiNos =
    {
        new object[] { 179, 69_000, 0, Scale.Normal },
        new object[] { 179, 55_000, 0, Scale.UnderWeight },
        new object[] { 179, 89_000, 0, Scale.OverWeight },
        new object[] { 179, 109_000, 0, Scale.Obese }
        // new object[] { new Random().Next(141, 200), new Random().Next(35, 132), 0, Scale.Obese }
    };
}