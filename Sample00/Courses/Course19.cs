namespace Sample00.Courses.C19;

//using dispose timing
public class Course : AbsCourse
{
    public override void Run()
    {
        if (true)
        {
            using var db1 = new DbManager(1);
            Console.WriteLine("inside if");
        }

        using(var db2 = new  DbManager(2))
        {
            Console.WriteLine("inside using");
        }

        using var db3 = new DbManager(3);

        Console.WriteLine("Run end");
    }
}

public class DbManager : IDisposable
{
    private readonly int _id;
    public DbManager(int id)
    {
        _id = id;
    }

    public void Dispose()
    {
        Console.WriteLine($"{_id} dispose");
    }
}