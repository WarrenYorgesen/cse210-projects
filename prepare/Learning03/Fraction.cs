
using System.Dynamic;
using System.Globalization;
using System.Runtime.CompilerServices;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int wholenumber)
    {
        _numerator = wholenumber;
        _denominator = 1;
    }
    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public int GetTop()
    {
        return _numerator;
    }
    public void SetTop(int number)
    {
        _numerator = number;
    }

    public int GetBottom()
    {
        return _denominator;
    }
    public void SetBottom(int number)
    {
        _denominator = number;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public double GetDecimalValue()
    {
        return (double) _numerator / _denominator;
    }
}