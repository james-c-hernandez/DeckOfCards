// See https://aka.ms/new-console-template for more information

//build card deck
//shuffle card deck
//display card deck

using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Collections.Generic;


class App
{
    static void Main(string[] args)
    {
        // Create a new deck of cards
        Deck deck = new Deck();

        // Shuffle the deck
        deck.Shuffle();

        // Display the shuffled deck
        Console.WriteLine("Shuffled Deck:");
        foreach (var card in deck.Cards)
        {
            Console.WriteLine(card);
        }
    }
}

