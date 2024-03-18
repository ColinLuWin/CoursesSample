namespace Sample00.Courses.C17;

//catch flow
public class Course : AbsCourse
{
    public override void Run()
    {
        try
        {
            Foo();
            Console.WriteLine("execute success without error happen");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Run catch");
        }
    }

    private void Foo()
    {
        try
        {
            throw new InvalidOperationException("original error message");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Foo catch");
            //throw;
        }
    }
}

