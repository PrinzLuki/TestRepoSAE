public class MyMathf
{
    public static float ClampValue(float value, float min, float max)
    {
        if (value < min) return min;
        if (value > max) return max;
        return value;
    }
}
