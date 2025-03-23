using System;
using System.Security.Cryptography;

public class Deck
{
    private List<Card> _deck = new List<Card>();
    private int suitsCount = 4;
    private int rankCount = 13;
    public List<Card> Cards
    {
        get { return _deck; }
    }
    public Deck()
    {
        // Initialize a standard deck of 52 playing cards

        List<Card> deck = new List<Card>();
        for (int s = 0; s < suitsCount; s++)
        {
            for (int r = 0; r < rankCount; r++)
            {
                _deck.Add(new Card(s, r));
            }
        }
    }

    // Shuffle the deck of cards using a simple algorithm
    public void Shuffle()
    {
        // Simple shuffle algorithm: swap each card with a random card
        int cardCount = suitsCount * rankCount;
        int x = 0;
        long seed = DateTime.Now.Ticks; //uses the current time as a seed for randomness
        //Random rand = new Random(52); //alkways gives the same order of random numbers
        Random rand = new Random((int)(seed & 0xFFFFFFFF)); // Use the lower 32 bits of the seed
        for (int i = 0; i < suitsCount * rankCount; i++)
        {
            ;
            x = rand.Next(cardCount);
            Card drawCard = _deck[x];
            Card currentCard = _deck[i];
            Card tmpCard = currentCard;
            _deck[i] = drawCard; // swap the current card with a random card
            _deck[x] = tmpCard; // swap the random card with the current card
        }
    }
}
