public class BMI
{
    // height in centimetres
    private readonly float _height;

    // weight in grams
    private readonly float _weight;

    public BMI(float height, float weight)
    {
        _height = height;
        _weight = weight;
    }

    // bmi is kgs / metre square
    public float GetBMI()
    {
        // conv to kgs and metres
        return ( _weight / 1000 ) / ( (_height/100) * (_height/100) );
    }

    public Scale GetScale()
    {
        var getBMI= GetBMI();
        switch (getBMI)
        {
            case <= 18.4f:
                return Scale.UnderWeight;
                break;
                
            case >= 18.5f when getBMI <= 24.9f:
                return Scale.Normal;
                break;

            case >= 25.0f when getBMI <= 29.9f:
                return Scale.OverWeight;
                break;

            case >= 30.0f:
                return Scale.Obese;
                break;

            default:
                return Scale.Unknown;
                break;
        }
    }
}

public enum Scale
{
    UnderWeight,
    Normal,
    OverWeight,
    Obese,
    Unknown
}