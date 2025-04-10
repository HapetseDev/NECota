using Godot;
using System;

public abstract partial class PlayerState : Node
{
    protected Player characterNode;
     public override void _Ready()
    {
        characterNode = GetOwner<Player>();
        SetPhysicsProcess(false);
        SetProcessInput(false);
    }

    public override void _Notification(int what)
    {
        base._Notification(what);
        if (what == GameConstants.NOTIFICATION_ENTER_STATE)
        {
            EnterState();
           SetPhysicsProcess(true);
           SetProcessInput(true);

        }
        else if (what == GameConstants.NOTIFICATION_EXIT_STATE)
        {
            // Called every time the node is removed from the scene.
            //characterNode.animPlayerNode.Stop();
            SetPhysicsProcess(false);
        }
    }

    protected virtual void EnterState(){
        
    }
}
