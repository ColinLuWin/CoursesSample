namespace Sample00.Courses.C14;

//delegate: with event
public class Course : AbsCourse
{
    public override void Run()
    {
        var cardReader = new CardReader();

        var displayer = new Displayer();
        cardReader.OnReadCardNumber += displayer.ShowCardNumber;

        //add event by inject instance in constructor
        var recorder = new Recorder(cardReader);

        cardReader.OnReadCardNumber += cardNumber =>
        {
            Console.WriteLine("[Lambda]\t: " + cardNumber);
        };

        cardReader.ReadCard("uk3320");

        cardReader.OnReadCardNumber -= recorder.Save;

        cardReader.ReadCard("ud7777");
    }
}

public class CardReader
{
    public delegate void ReadCardNumberHandler(string cardNumber);
    public event ReadCardNumberHandler? OnReadCardNumber;

    public void ReadCard(string cardNumber)
    {
        if (string.IsNullOrEmpty(cardNumber))
            return;

        Console.WriteLine("[CardReader]\t: " + cardNumber);
        OnReadCardNumber?.Invoke(cardNumber);
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
    public Recorder(CardReader cardReader)
    {
        cardReader.OnReadCardNumber += Save;
    }

    public void Save(string cardNumber)
    {
        Console.WriteLine("[Recorder]\t: " + cardNumber);
    }
}