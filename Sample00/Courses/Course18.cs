namespace Sample00.Courses.C18;

//stacktrace diff
public class Course : AbsCourse
{
    public override void Run()
    {
        try
        {
            foo1();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
    }

    private void foo1()
    {
        foo2();
    }

    private void foo2()
    {
        foo3();
    }

    private void foo3()
    {
        try
        {
            foo4();
        }
        catch (Exception ex)
        {
            //keep stacktrace
            throw;

            //re-throw exception. reset stacktrace from here
            //throw ex;

            //loss all info.
            //throw new Exception("throw by foo3 catch");
        }
    }

    private void foo4()
    {
        foo5();
    }

    private void foo5()
    {
        //origin error from here
        throw new InvalidOperationException("original error message");
    }
}

