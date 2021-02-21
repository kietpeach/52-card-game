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
    public void fillHand1()
    {
        bool x = true;
        var s = 1;
        var v = 1;
        for (v=1; v < 14; v++)
        {
            hand1.Add(new Card(s, v, x));
        }
    }
    public void dealHand1()
    {
        var c = 0;
        for (c=0;c < 13;c++)
        {
            this.GetNode("player1").AddChild(hand1[c]);
        }

    }

}
