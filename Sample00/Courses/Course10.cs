namespace Sample00.Courses.C10;

//delegate: multi parameters
public delegate int MyHandler(int a, int b);

public class Course : AbsCourse
{
    public override void Run()
    {
        A.Do(3, 6, MyWork);
        A.Do(2, 4, (x, y) => 
        { 
            return x * y; 
        });
    }

    public int MyWork(int x, int y)
    {
        return (int)Math.Pow(x, y);
    }
}

public static class A
{
    //public delegate float TaxCalculator(int income);

    public static void Do(int a, int b, MyHandler handler)
    {
        var result = handler(a, b);
        Console.WriteLine($"handler({a}, {b}) = {result}");
    }

    //public static float CalculateTax(int income, TaxCalculator calculator)
    //{
    //    return calculator(income);
    //}
}

//public static class TaxJapan
//{
//    public static float Calculate(int income)
//    {
//        return income * 0.03f;
//    }
//}

//public static class TaxTaiwan
//{
//    public static float Calculate(int income)
//    {
//        return income * 0.06f;
//    }
//}