using Godot;
using System;

public class Back : Button
{

    public override void _Ready()
    {
        
    }
    public void _on_Back_pressed(){
        GetTree().ChangeScene("res://Lobby.tscn");
    }


}
