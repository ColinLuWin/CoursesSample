namespace Sample00.Courses.C9;

//delegate: has return value
public delegate int MyHandler(string msg);

public class Course09 : AbsCourse
{
    public override void Run()
    {
        A.Do(MyWork);
    }

    public int MyWork(string msg)
    {
        return msg.Length;
    }
}

public static class A
{
    //public delegate float TaxCalculator(int income);

    public static void Do(MyHandler handler)
    {
        var source = "Hello World";
        var n = handler(source);
        Console.WriteLine($"[{source}] length: {n}");
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