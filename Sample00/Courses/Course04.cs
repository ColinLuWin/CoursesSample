namespace Sample00.Courses.C4;

//extension
internal class Course4 : AbsCourse
{
    public override void Run()
    {
        var d = new DateTime(2024, 9, 19);
        Console.WriteLine(d);

        var s = d.ToYYYYMMDD();
        Console.WriteLine(s);

        var d2 = s.ToDateTime();
        Console.WriteLine(d2);
    }
}

public static class MyExtension
{
    public static string ToYYYYMMDD(this DateTime d)
    {
        return d.ToString("yyyyMMdd");
    }

    public static DateTime? ToDateTime(this string s)
    {
        var valid = DateTime.TryParseExact(s, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime d);
        if (!valid)
        {
            return null;
        }

        return d;
    }
}