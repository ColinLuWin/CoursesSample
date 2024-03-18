namespace Sample00.Courses.C12;

//2024.03.04上到這

//delegate: list sort example
public class Course : AbsCourse
{
    public override void Run()
    {
        var ls = new List<int> { 1, 2, 3, 4, 8, 7, 6, 5 };
        //var rnd = new Random();
        //var ls = new List<int>();
        //for(var idx=0; idx<10; ++idx)
        //{
        //    ls.Add(rnd.Next(0, 31));
        //}

        Console.Write("origin: ");
        Show(ls);

        ls.Sort((a, b) =>
        {
            //Console.WriteLine($"[{a}, {b}]");
            if (a % 2 == 0 && b % 2 != 0)
                return -1;

            if (b % 2 == 0 && a % 2 != 0)
                return 1;

            return a.CompareTo(b);
        });

        Console.Write("sorted: ");
        Show(ls);
    }

    private static void Show(List<int> ls)
    {
        var result = string.Join(',', ls);
        Console.Write($"[{result}]");
        Console.WriteLine();
    }
}