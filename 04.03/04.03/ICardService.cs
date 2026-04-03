namespace _04._03;

public interface ICardService
{
    Card GetCardByNumber(string cardNumber);
    void AddCard(Card card);
}
