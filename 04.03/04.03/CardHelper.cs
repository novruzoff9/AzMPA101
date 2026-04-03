namespace _04._03;

internal static class CardHelper
{
    public static string MaskCardNumber(this Card card)
    {
        return card.CardNumber.Substring(0, 4) + new string('*', 8) + card.CardNumber.Substring(12, 4);
    }
  
}
