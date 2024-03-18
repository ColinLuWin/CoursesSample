namespace Sample00.Courses;

public abstract class AbsLinqCourse : AbsCourse
{
    protected static void Show<T>(List<T> ls)
    {
        foreach (var item in ls)
        {
            if (item == null)
                continue;

            var type = item.GetType();
            var properties = type.GetProperties();
            foreach(var property in properties)
            {
                var value = property.GetValue(item);
                if (value != null)
                {

                    Console.Write($"{property.Name}: {value}\t");
                }
            }
            Console.WriteLine();
        }
    }
}
