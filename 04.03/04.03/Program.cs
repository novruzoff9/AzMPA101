using _04._03;

Card card1 = new Card() { 
    Bank = Bank.Abb, 
    Balance = 1000, 
    Bonus = 100, 
    CardNumber = "1234567890123456" 
};
Card card2 = new Card() { 
    Bank = Bank.Abb, 
    Balance = 2000, 
    Bonus = 200, 
    CardNumber = "1234567890123457" 
};

CardService cardservic= new();
Console.WriteLine(card2.MaskCardNumber()); 


cardservic.AddCard(card2);
cardservic.GetCardByNumber("1234567890123457");



