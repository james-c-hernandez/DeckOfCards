using System;
using System.Net.Security;
using Microsoft.VisualBasic;

public class Card
{
	public int Suit { get; set; }
    public int Rank { get; set; }
    public Card(int Suit, int Rank)
	{
        this.Suit = Suit;
        this.Rank = Rank;
    }


    //enum Ranks
    //{
    //    Two = 0,
    //    Three = 1,
    //    Four = 2,
    //    Five = 3,
    //    Six = 4,
    //    Seven = 5,
    //    Eight = 6,
    //    Nine = 7,
    //    Ten = 8,
    //    Jack = 9,
    //    Queen = 10,
    //    King = 11,
    //    Ace = 12
    //}
    public override string ToString()
    {
        Suits suit = (Suits)Suit;
        Ranks rank = (Ranks)Rank;
        string suitName = Enum.GetName(typeof(Suits), suit);
        string rankName = Enum.GetName(typeof(Ranks), rank);
        return suitName + " " + rankName;
    }
}
