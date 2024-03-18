namespace Sample00.Courses;

public abstract class AbsCourse
{
    public string Name 
    {
        get
        {
            return GetType().FullName;
        }
    }

    public abstract void Run();
}
