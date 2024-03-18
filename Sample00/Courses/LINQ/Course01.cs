namespace Sample00.Courses.LINQ.C01;

//linq: select
public class Course : AbsLinqCourse
{
    public override void Run()
    {
        var orders = new List<Order>
        {
            new Order { OrderId = 101, UserId = "u101" },
            new Order { OrderId = 102, UserId = "u102" },
            new Order { OrderId = 103, UserId = "u101" },
        };

        //WithoutLinq(orders);
        ByLinq(orders);
    }

    private void WithoutLinq(List<Order> orders)
    {
        var result = new List<Order2>();
        foreach (var order in orders)
        {
            result.Add(new Order2
            {
                OrderId = order.OrderId,
                UserId = "@" + order.UserId,
            });
        }

        Show(result);
    }

    private void ByLinq(List<Order> orders)
    {
        var targets = orders
            .Select(o => new Order2
            {
                OrderId = o.OrderId,
                UserId = "@" + o.UserId,
            })
            .ToList();

        Show(targets);
    }
}

public class Order2
{
    public int OrderId { get; set; }
    public string UserId { get; set; }
}