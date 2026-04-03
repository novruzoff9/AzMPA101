namespace _04._03;

public class Card
{
    static int count = 0;
    private string cardNumber;
    public int Id { get; set; }
    public decimal Balance { get; set; }
    public decimal Bonus { get; set; }
    public string CardNumber
    {
        get
        {
             return cardNumber;
        }
        set 
        {
            if (value.Length == 16)
            {
                cardNumber = value;
            }
        }
    }
    public Bank Bank { get; set; }

    public Card()
    {
        Id=++count;

    }

    public bool WithDraw(int amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}
