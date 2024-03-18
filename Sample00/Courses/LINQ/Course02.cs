namespace Sample00.Courses.LINQ.C02;

//linq: where
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

        WithoutLinq(orders);
        ByLinq(orders);
    }

    private void WithoutLinq(List<Order> orders)
    {
        var targets = new List<Order>();
        foreach (var order in orders)
        {
            if (order.UserId == "u101")
            {
                targets.Add(order);
            }
        }

        Show(targets);
    }

    private void ByLinq(List<Order> orders)
    {
        var targets = orders.Where(o => o.UserId == "u101").ToList();
        Show(targets);
    }
}