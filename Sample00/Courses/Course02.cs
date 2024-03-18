namespace Sample00.Courses.C2;

//static variable, method, constructor
internal class Course2 : AbsCourse
{
    public override void Run()
    {
        var f1 = new Foo("ben", 2);
        var f2 = new Foo("cindy", 3);

        f1.Show();
        f2.Show();

        f1.DoAdd(10);
        f1.Show();
        f2.Show();

        f2.DoAdd(20);
        f1.Show();
        f2.Show();


        var h = Foo.MarsAdd(1, 2);
        Console.WriteLine(h);
    }
}

public class Foo
{
    private string Name;
    private int Value;

    public static int StaticValue;

    public Foo(string name, int v)
    {
        Name = name;
        Value = v;
    }

    public void DoAdd(int c)
    {
        Console.WriteLine($"{Name} DoAdd by {c}");
        Value += c;
        StaticValue += c;
    }

    public void Show()
    {
        Console.WriteLine($"{Name}\tValue: {Value}\tStatic Value: {StaticValue}");
    }

    static Foo()
    {
        Console.WriteLine("static constructor");
        StaticValue = 100;
        Console.WriteLine("Static Value: " + StaticValue);
    }

    public static int MarsAdd(int a, int b)
    {
        return a + b * 3;
    }
}
