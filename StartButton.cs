using Godot;
using System;

public class StartButton : Button
{
   
    public override void _Ready()
    {
        
    }
    public void _on_StartButton_pressed(){
        GetTree().ChangeScene("res://Game.tscn");
    }

}
