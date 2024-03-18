namespace Sample00.Courses.C8;

//delegate: one parameter
public delegate void MyHandler(string msg);

public class Course08 : AbsCourse
{
    public override void Run()
    {
        A.Do(MyWork);
    }

    public void MyWork(string msg)
    {
        Console.WriteLine("I am Course8! message: " + msg);
    }
}

public static class A
{
    public static void Do(MyHandler handler)
    {
        handler("Hello World");
    }
}