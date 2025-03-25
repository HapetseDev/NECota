using Godot;
using System;

public partial class StateMachine : Node
{
    [Export] private Node currentState;
    [Export] private Node[] states;
    [Export] private Node previousState;

    public override void _Ready()
    {
        currentState.Notification(5001);
    }

}
