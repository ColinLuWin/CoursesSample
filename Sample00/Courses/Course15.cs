namespace Sample00.Courses.C15;

//try-catch
public class Course : AbsCourse
{
    public override void Run()
    {
        try
        {
            int b = 0;
            int c = 1 / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("catch 1");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("catch 2");
            Console.WriteLine(ex.GetType());
            Console.WriteLine(ex.Message);
            if (ex.InnerException != null)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("catch 1");
        //    Console.WriteLine(ex.Message);
        //}
    }
}

