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

// Please refer to https://en.wikipedia.org/wiki/Body_mass_index#/media/File:BMI_chart.png on how I am setting the range.
// An adult's height is constant say 1.9m, s his overweight range is from 92 to 108 kgs.
// Range for normal of a person of height 1.6m is between ~ 48-64, edges are 47, 48, 49 and 63, 64, 65
public class BmiTestsData
{
    // height in cms and weight in grams
    public static object[] bmiNos =
    {
        new object[] { 179, 69_000, 0, Scale.Normal },
        new object[] { 179, 55_000, 0, Scale.UnderWeight },
        new object[] { 179, 89_000, 0, Scale.OverWeight },
        new object[] { 179, 109_000, 0, Scale.Obese },
        // new object[] { new Random().Next(141, 200), new Random().Next(35, 132), 0, Scale.Obese }
        new object[] { 150, new Random().Next(46, 52) * 1000, 0, Scale.Normal },
        new object[] { 190, new Random().Next(68, 90) * 1000, 0, Scale.Normal },
        new object[] { 190, new Random().Next(92, 108) * 1000, 0, Scale.OverWeight },

        new object[] { 160, 47 * 1000, 0, Scale.UnderWeight },
        new object[] { 160, 48 * 1000, 0, Scale.UnderWeight },
        new object[] { 160, 49 * 1000, 0, Scale.Normal },
        new object[] { 160, 63 * 1000, 0, Scale.Normal },
        new object[] { 160, 64 * 1000, 0, Scale.Normal },// will give unknown - Rounding Error*
        new object[] { 160, 65 * 1000, 0, Scale.OverWeight },
    };
}