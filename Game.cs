using Godot;
using System;

public class Game : Control
{
    Godot.Collections.Array<Card> hand1 = new Godot.Collections.Array<Card>();
    Godot.Collections.Array<int> hand1coppy = new Godot.Collections.Array<int>();
    Godot.Collections.Array<Card> hand2 = new Godot.Collections.Array<Card>();
    Godot.Collections.Array<Card> hand3 = new Godot.Collections.Array<Card>();
    Godot.Collections.Array<Card> hand4 = new Godot.Collections.Array<Card>();
    public override void _Ready()
    {
        fillHand();
        dealHand();
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
    public static void SortArr(Godot.Collections.Array<int> arr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] > arr[j])
                {
                    // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
    // public void SortCard()
    // {
    //     hand1.Clear();
    //     for (int i = 0; i < 13; i++) { hand1.Add(new Card(hand1coppy[i], true)); }
    // }
    public void fillHand()
    {
        var deck = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 23, 24, 25, 26, 27, 28, 29, 31, 32, 33, 34, 35, 36, 37, 38, 39, 41, 42, 43, 44, 45, 46, 47, 48, 49, 110, 111, 112, 113, 210, 211, 212, 213, 310, 311, 312, 313, 410, 411, 412, 413 };
        int n = deck.Length;
        Shuffle(deck, n);
        //for (int i = 0; i < n; i++){GD.Print(deck[i]);}
        //Add 13 lá bài vào array
        for (int i = 0; i < 13; i++) { hand1.Add(new Card(deck[i], true)); hand1coppy.Add(hand1[i].cardID); }
        GD.Print(hand1coppy);
        SortArr(hand1coppy, 13);
        GD.Print(hand1coppy);
        //_on_Sort_pressed();
        for (int i = 13; i < 26; i++) { hand2.Add(new Card(deck[i], false)); }
        for (int i = 26; i < 39; i++) { hand3.Add(new Card(deck[i], false)); }
        for (int i = 39; i < 52; i++) { hand4.Add(new Card(deck[i], false)); }
    }
    public void dealHand()
    {
        //Add array 13 lá bài vào Node 
        var c = 0;
        for (c = 0; c < 13; c++)
        {
            this.GetNode("player1").AddChild(hand1[c]);
            this.GetNode("player2").AddChild(hand2[c]);
            this.GetNode("player3").AddChild(hand3[c]);
            this.GetNode("player4").AddChild(hand4[c]);
        }

    }
    public void _on_Sort_pressed(){
        GD.Print("aaa");
        // hand1.Clear();
        // for (int i = 0; i < 13; i++) { hand1.Add(new Card(hand1coppy[i], true)); }
    }

}
