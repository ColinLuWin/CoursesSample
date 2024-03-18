namespace Sample00.Courses;

//static class
internal class Course6 : AbsCourse
{
    public override void Run()
    {
        //var f = new Foo(); //compile error
    }
}

public static class Foo
{
    //public void Show() //compile error
    //{
    //}
}