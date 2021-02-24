using Godot;
using System;

public class Hit : Button
{

    public override void _Ready()
    {

    }
    public void _on_Hit_pressed()
    {
        // Godot.Collections.Array<Card> array = new Godot.Collections.Array<Card>();
        var i = 0;
        var arr = new int[]{0,30,-30,0,30,-30,0,30,-30,0,30,-30,0};
        for (i = 0; i < 13; i++)
        {
            Card card = this.GetParent().GetNode("player1").GetChild<Card>(i);
            if (card.cardChoosed != null)
            {
                card.RectPosition = new Vector2(400+arr[i], -200+arr[i]);
                GD.Print("card ban da danh la"+card.cardChoosed);
                card.RectScale = new Vector2((float)0.8,(float)0.8);       
                card.cardChoosed.Hide();
                // array.Add(new Card(card.cardChoosed.cardID,true));
                // this.GetParent().GetNode("Board").AddChild(array[0]);
            }
        }
        
        

    }



}
