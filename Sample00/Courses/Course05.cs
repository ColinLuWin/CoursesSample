namespace Sample00.Courses.C5;

//static new()
internal class Course5 : AbsCourse
{
    public override void Run()
    {
        A.Show();
        B.Show();

        A reference = new B();
    }
}

public class A
{
    public static void Show()
    {
        Console.WriteLine("A Show");
    }
}

public class B : A
{
    public static new void Show()
    {
        Console.WriteLine("B Show");
    }
}
