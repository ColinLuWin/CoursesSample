namespace Sample00.Courses.C11;

//delegate: tax calculator example
public delegate float TaxCalculator(int income);

public class Course : AbsCourse
{
    public override void Run()
    {
        A.CalculateTax(1000000, TaxTaiwan.Calculate);
        A.CalculateTax(1000000, TaxJapan.Calculate);
    }
}

public static class A
{
    public static void CalculateTax(int income, TaxCalculator calculator)
    {
        var tax = calculator(income);
        if (tax > 50000)
        {
            tax += 100;
        }

        Console.WriteLine($"final tax: {tax}");
    }
}

public static class TaxTaiwan
{
    public static float Calculate(int income)
    {
        return income * 0.06f;
    }
}

public static class TaxJapan
{
    public static float Calculate(int income)
    {
        return income * 0.03f;
    }
}

