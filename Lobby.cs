using Godot;
using System;

public class Lobby : Control
{
    Button Join;
    VBoxContainer LobbyList;

    public override void _Ready()
    {
        Join = GetNode("JoinButton") as Button;
        LobbyList = GetChild(6).GetChild(0).GetChild(3).GetNode("LobbyList") as VBoxContainer;

    }
    private void JoinGame()
    {
        GetTree().ChangeScene("res://Game.tscn");
    }
    private void _on_JoinButton_pressed()
    {
        GD.Print("popup");
        Popup popup = GetNode<Popup>("PopupPanel");
        popup.Popup_();
        //
        var LobbyName = "Kiet";
        var LobbyMember = 4;
        var LobbyButton = new Button();
        LobbyButton.Text = "LobbyName:"+LobbyName+"     "+"Member:"+LobbyMember;
        LobbyButton.Connect("pressed",this,"JoinGame");
        LobbyList.AddChild(LobbyButton);
    }

    private void _on_CloseButton_pressed()
    {
        GD.Print("hide");
        Popup popup = GetNode<Popup>("PopupPanel");
        popup.Hide();
    }
    private void _on_Refresh_pressed()
    {
        GD.Print("Refresh lobby list");
        //TODO
    }


}
