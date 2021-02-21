using Godot;
using System;

public class JointButton : Button
{
    
    public override void _Ready()
    {
        
    }
    public void _on_JointButton_pressed()
    {
        GD.Print("popup");
        Popup popup = GetParent().GetNode<Popup>("PopupPanel");
        popup.Popup_();

    }


}
