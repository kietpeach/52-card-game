using Godot;
using System;

public class Card : TextureButton
{

    public int suit;
    public int value;
    public string face;
    public string back;
    public bool xi;
    public Card cardChoosed;


    public override void _Ready()
    {

        SizeFlagsHorizontal = (int)SizeFlags.ExpandFill;
        SizeFlagsVertical = (int)SizeFlags.ExpandFill;
        Expand = true;
        StretchMode = StretchModeEnum.KeepAspectCentered;
    }
    public Card(int s, int v, bool x)
    {
        xi = x;
        suit = s;
        value = v;
        var face = GD.Load("res://Assets/cards/card-" + suit + "-" + value + ".png") as Texture;
        var back = GD.Load("res://Assets/cards/cardBack_red2.png") as Texture;
        //ngửa bài
        if (x == true)
        {
            TextureNormal = face;
        }
        //úp bài
        else
        {
            TextureNormal = back;
        }
    }

    public void _pressed()
    {
        Choose(this);
    }
    public void Choose(Card c)
    {
        if (this.RectPosition.y == 0)
        {
            cardChoosed = c;
            GD.Print(cardChoosed);
            GD.Print("Card ban chon la:"+cardChoosed.value+"-"+cardChoosed.suit);
            this.RectPosition = this.RectPosition + new Vector2(0, -20);
        }
        else
        {
            this.RectPosition = this.RectPosition + new Vector2(0, 20);
            cardChoosed = null;
            GD.Print(cardChoosed);
        }

    }
  
}
