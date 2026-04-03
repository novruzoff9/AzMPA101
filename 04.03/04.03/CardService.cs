namespace _04._03;

internal class CardService : ICardService
{
    static Card[] cards = [];
    public void AddCard(Card card)
    {
        foreach (var item in cards)
        {
            if (item.CardNumber == card.CardNumber)
            {
                Console.WriteLine("bu kart daxil edilibdir");
                return;
            }
        }
        Array.Resize(ref cards, cards.Length + 1);
        cards[cards.Length - 1] = card;
        
    }

    public Card GetCardByNumber(string cardNumber)
    {
        foreach (var item in cards)
        {
            if (item.CardNumber == cardNumber)
            {
                return item;
            } 
        }
        Console.WriteLine("kartiniz yoxdur");
        return null;
    }
}
