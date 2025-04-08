using Godot;
using System;

public partial class StateMachine : Node
{
    [Export] private Node currentState;
    [Export] private Node[] states;
    [Export] private Node previousState;

    public override void _Ready()
    {
        currentState.Notification(GameConstants.NOTIFICATION_ENTER_STATE);
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
        
        currentState.Notification(GameConstants.NOTIFICATION_EXIT_STATE); 

        currentState = newState;

        //previousState.Notification(NOTIFICATION_EXIT_STATE);
        currentState.Notification(GameConstants.NOTIFICATION_ENTER_STATE);
    }

}
