namespace Sample00.Courses.C20;

//using with try-catch
public class Course : AbsCourse
{
    public override void Run()
    {
        try
        {
            var db = new DbManager();
            //using var db = new DbManager();

            throw new InvalidOperationException("error");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("done");
    }
}

public class DbManager : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("dispose");
    }
}