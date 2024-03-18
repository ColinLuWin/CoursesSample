namespace Sample00.Courses.C7;

//delegate: no parameters
public delegate void MyHandler();

public class Course7 : AbsCourse
{
    public override void Run()
    {
        //1. by instance function
        A.Do(MyWork);

        //2. by static function
        A.Do(StaticMyWork);

        //3. by lambda
        A.Do(() => 
        {
            Console.WriteLine("I am Lambda");
        });
    }

    public void MyWork()
    {
        Console.WriteLine("I am instance function");
    }

    public static void StaticMyWork()
    {
        Console.WriteLine("I am static function");
    }
}

public static class A
{
    public static void Do(MyHandler handler)
    {
        handler();
    }
}