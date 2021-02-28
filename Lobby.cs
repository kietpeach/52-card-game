using Godot;
using System;

public class Lobby : Control
{
    //Button Start;

    public override void _Ready()
    {
        //Start = GetNode("StartButton") as Button;
    }
    private void _on_StartButton_pressed()
    {
        GetTree().ChangeScene("res://Game.tscn");
    }
    private void _on_JointButton_pressed()
    {
        GD.Print("popup");
        Popup popup = GetNode<Popup>("PopupPanel");
        popup.Popup_();
    }
    private void _on_CloseButton_pressed()
    {
        GD.Print("hide");
        Popup popup = GetNode<Popup>("PopupPanel");
        popup.Hide();
    }


}
