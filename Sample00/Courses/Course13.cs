namespace Sample00.Courses.C13;

//delegate: without event
public class Course : AbsCourse
{
    public override void Run()
    {
        var displayer = new Displayer();
        var recorder = new Recorder();
        var cardReader = new CardReader(displayer, recorder);

        cardReader.ReadCard("rk1124");
    }
}

public class CardReader
{
    private readonly Displayer displayer;
    private readonly Recorder recorder;

    public CardReader(Displayer displayer, Recorder recorder)
    {
        this.displayer = displayer;
        this.recorder = recorder;
    }

    public void ReadCard(string cardNumber)
    {
        if (string.IsNullOrEmpty(cardNumber)) 
            return;

        Console.WriteLine("[CardReader]\t: " + cardNumber);

        displayer.ShowCardNumber(cardNumber);
        recorder.Save(cardNumber);
    }
}

public class Displayer
{
    public void ShowCardNumber(string cardNumber)
    {
        Console.WriteLine("[Displayer]\t: " + cardNumber);
    }
}

public class Recorder
{
    public void Save(string cardNumber)
    {
        Console.WriteLine("[Recorder]\t: " + cardNumber);
    }
}