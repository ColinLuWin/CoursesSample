var course = new Sample00.Courses.LINQ.C03.Course();

Console.WriteLine($"==== course[{course.Name}] start ====");
Console.WriteLine();

course.Run();

Console.WriteLine();
Console.WriteLine($"==== course[{course.Name}] end ====");
Console.ReadKey();