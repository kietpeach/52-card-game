using Godot;
using System;

public class Login : Control
{
    LineEdit UserName;
    public override void _Ready()
    {
        UserName = GetNode("./NinePatchRect/VBoxContainer/UserName") as LineEdit;

    }
    private void _on_LoginButton_pressed()
    {
        if (UserName.Text != "")
        {
            GD.Print(UserName.Text);
            GetTree().ChangeScene("res://Lobby.tscn");
        }

    }


}
