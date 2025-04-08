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

    public void SwitchState<T>()
    {   Node newState = null;    
        previousState = currentState;
        foreach (Node state in states)
        {
            if (state is T)
            {
                newState = state;
                //break;
            }
        }

        if (newState == null)
        {
            GD.PrintErr("State not found");
            return;
        }
        
        currentState.Notification(5002); 

        currentState = newState;

        //previousState.Notification(5002);
        currentState.Notification(5001);
    }

}
