namespace Sample00.Courses.C1;

//operator
internal class Course1 : AbsCourse
{
    public override void Run()
    {
        var s0 = new Student { Name = "Jason", Score = 50 };
        s0.Show();

        var s1 = new Student { Name = "Joe", Score = 60 };
        s1.Show();

        var s2 = s0 + s1;
        s2.Show();
    }

    public class Student
    {
        public string Name { get; set; } = string.Empty;
        public int Score { get; set; }

        public static Student operator +(Student a, Student b)
        {
            var student = new Student
            {
                Name = $"{a.Name} {b.Name}",
                Score = a.Score + b.Score,
            };

            return student;
        }

        public void Show()
        {
            Console.WriteLine($"Name:{Name}\tScore:{Score}");
        }
    }
}
