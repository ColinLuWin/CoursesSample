namespace Sample00.Courses.C21;

//practice
public class Course : AbsCourse
{
    public override void Run()
    {
        string msg = "";

        while (true)
        {
            Console.Clear();
            Console.WriteLine(msg);

            Console.WriteLine("username:");
            var username = Console.ReadLine();
            if (string.IsNullOrEmpty(username))
                continue;

            if (username == "exit")
                break;

            Console.WriteLine("password:");
            var password = Console.ReadLine();
            if (string.IsNullOrEmpty(password))
                continue;

            var repo = new UserRepo();
            var loginService = new LoginService(repo);
            //using var loginService = new LoginService(repo);
            var logger = new Logger(loginService);

            var loginResult = loginService.Login(username, password);
            if (!loginResult.OK)
            {
                msg = loginResult.Message;
                continue;
            }

            Console.WriteLine(loginResult.Message);
            break;
        }

        Console.WriteLine("leave loop");
    }
}

public class UserRepo
{
    private const int InstancesLimit = 1;
    private static int CurrentInstancesCount = 0;

    public UserRepo()
    {
        if (CurrentInstancesCount >= InstancesLimit)
        {
            throw new InvalidOperationException("over limit...");
        }

        ++CurrentInstancesCount;
    }

    public Dictionary<string, string> GetUsers()
    {
        return new Dictionary<string, string>
        {
            {"joy", "111"},
            {"admin", "5566"},
        };
    }

    public void Release()
    {
        --CurrentInstancesCount;
    }
}

public delegate void UserLoginHandler(string username);

public class LoginResult
{
    public string UserName { get; set; }
    public bool OK { get; set; }
    public string Message { get; set; }
}

public class LoginService : IDisposable
{
    public UserLoginHandler OnUserLogin;

    public readonly UserRepo _repo;

    public LoginService(UserRepo repo)
    {
        _repo = repo;
    }

    public LoginResult Login(string username, string password)
    {
        username = username.Trim();
        password = password.Trim();

        OnUserLogin?.Invoke(username);

        var result = new LoginResult { UserName = username, OK = false, Message = "" };

        if (string.IsNullOrEmpty(username))
        {
            result.Message = "username is empty";
            return result;
        }

        if (string.IsNullOrEmpty(password))
        {
            result.Message = "password is empty";
            return result;
        }

        var users = _repo.GetUsers();

        var isUserExists = users.TryGetValue(username, out string pswd);
        if (!isUserExists)
        {
            result.Message = $"user[{username}] not found!";
            return result;
        }

        if (password != pswd)
        {
            result.Message = $"password is incorrect!";
            return result;
        }

        result.Message = $"hi! [{username}]";
        result.OK = true;
        return result;
    }

    public void Dispose()
    {
        _repo.Release();
    }
}

public class Logger
{
    public Logger(LoginService loginService)
    {
        loginService.OnUserLogin += Save;
    }
    public void Save(string username)
    {
        Console.WriteLine($"user [username] login");
    }
}

