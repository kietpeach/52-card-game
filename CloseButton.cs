using Godot;
using System;

public class CloseButton : Button
{
    public override void _Ready()
    {

    }
    public void _on_CloseButton_pressed()
    {
        GD.Print("hide");
        Popup popup = GetParent().GetParent<Popup>();
        popup.Hide();
    }


}
