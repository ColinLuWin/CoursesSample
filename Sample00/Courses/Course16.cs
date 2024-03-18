namespace Sample00.Courses.C16;

//try-catch-finally
public class Course : AbsCourse
{
    public override void Run()
    {
        WithFinally();
    }

    public void WithoutFinally()
    {
        var mgr = new DbManager();
        try
        {
            mgr.Work();
            var a = 0;
            var b = 1 / a;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error:\t\t{ex.Message}");
        }

        var mgr2 = new DbManager();
        mgr2.Work();
    }

    public void WithFinally()
    {
        var mgr = new DbManager();
        try
        {
            mgr.Work();
            var a = 0;
            var b = 1 / a;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error:\t\t{ex.Message}");
        }
        finally
        {
            mgr.Release();
        }

        var mgr2 = new DbManager();
        mgr2.Work();
    }
}

public class DbManager
{
    private static bool isRunning = false;

    public DbManager()
    {
        if (isRunning)
            throw new InvalidOperationException("Db is running!");

        isRunning = true;
    }

    public void Work()
    {
        Console.WriteLine($"{GetHashCode()}\twork...");
    }

    public void Release()
    {
        isRunning = false;
    }
}

