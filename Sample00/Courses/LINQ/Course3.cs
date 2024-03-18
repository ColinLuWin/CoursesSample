namespace Sample00.Courses.LINQ.C03;

//linq: select + where practice
public class Course : AbsLinqCourse
{
    //取得在特定時間前建立且Name長度在N以下的帳號 
    //並回傳PlayerInfo
    public override void Run()
    {
        var d = new DateTime(2024, 1, 1);
        var len = 5;

        var players = new List<Player>
        {
            new Player { Id = 101, CreateTime = new DateTime(2023, 3, 2), Name = "ben" },
            new Player { Id = 102, CreateTime = new DateTime(2024, 1, 2), Name = "anderson" },
            new Player { Id = 103, CreateTime = new DateTime(2024, 2, 25), Name = "hill" },
            new Player { Id = 104, CreateTime = new DateTime(2024, 2, 25), Name = "cindy" },
        };

        var result = players
            .Where(p => p.CreateTime > d && p.Name.Length <= len)
            .Select(p => new PlayerInfo
            {
                Id = p.Id.ToString().PadLeft(8, '0'),
                Password = $"#{p.Id*10+3}_{p.Name}%"
            })
            .ToList();

        Show(result);
    }
}

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreateTime { get; set; }
}

public class PlayerInfo
{
    public string Id { get; set; }
    public string Password { get; set; }
}