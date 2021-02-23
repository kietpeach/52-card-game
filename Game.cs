using Godot;
using System;

public class Game : Control
{
    Godot.Collections.Array<Card> hand1 = new Godot.Collections.Array<Card>();
    public override void _Ready()
    {
        fillHand1();
        dealHand1();
    }
    public static void Shuffle(int[] deck, int n)
    {
        Random random = new Random();
        for (int i = n - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            int temp = deck[i];
            deck[i] = deck[j];
            deck[j] = temp;
        }
    }
    public void fillHand1()
    {
        var deck = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 23, 24, 25, 26, 27, 28, 29, 31, 32, 33, 34, 35, 36, 37, 38, 39, 41, 42, 43, 44, 45, 46, 47, 48, 49, 110, 111, 112, 113, 210, 211, 212, 213, 310, 311, 312, 313, 410, 411, 412, 413 };
        int n = deck.Length;
        Shuffle(deck, n);
        for (int i = 0; i < n; i++)
        {
            GD.Print(deck[i]);
        }
        bool x = true;

        for (int i = 0; i < 13; i++)
        {
            hand1.Add(new Card(deck[i], x));
        }
    }
    public void dealHand1()
    {
        var c = 0;
        for (c = 0; c < 13; c++)
        {
            this.GetNode("player1").AddChild(hand1[c]);
        }

    }

}
