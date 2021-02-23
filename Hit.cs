using Godot;
using System;

public class Hit : Button
{

    public override void _Ready()
    {

    }
    public void _on_Hit_pressed()
    {
        var i = 0;
        var j = 0;
        for (i = 0; i < 13; i++,j+=30)
        {
            Card card = this.GetParent().GetNode("player1").GetChild<Card>(i);
            if (card.cardChoosed != null)
            {
                card.RectPosition = new Vector2(400, -200);
                GD.Print(card.cardChoosed);
                card.RectScale = new Vector2((float)0.8,(float)0.8);
                card.cardChoosed.Disabled = true;
            }
        }

    }



}
