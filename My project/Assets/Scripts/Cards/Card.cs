using UnityEngine;

public enum Suit
{
    Hearts, Diamonds, Clubs, Spades
}

public enum Rank
{
    Two = 2,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
    Ace
}

public class Card
{
    public int Rank Rank { get; set; }
    public string Suit Suit { get; set; }

        public Card(Suit suit, Rank rank)
    {
        this.Suit = suit;
        this.Rank = rank;
    }

public override string ToString()
{
    return $"{Rank} of {Suit}";
}
}

