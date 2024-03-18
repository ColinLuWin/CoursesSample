namespace Sample00.Courses.C3;

//singleton
internal class Course3 : AbsCourse
{
    public override void Run()
    {
        var foo = Foo.GetInstance();
        foo.Show();

        var foo2 = Foo.GetInstance();
        foo2.Show();

        var momo = new Momo();
        momo.Show();

        var momo2 = new Momo();
        momo2.Show();
    }
}

public class Foo
{
    public static Foo GetInstance()
    {
        instance ??= new Foo();
        return instance;
    }
    private static Foo instance;

    private Foo()
    {
    }

    public void Show()
    {
        Console.WriteLine("I'm Foo!, My hashcode: " + GetHashCode());
    }
}

public class Momo
{
    public void Show()
    {
        Console.WriteLine("I'm Mono!, My hashcode: " + GetHashCode());
    }
}