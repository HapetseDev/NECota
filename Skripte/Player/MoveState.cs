using Godot;
using System;

public partial class MoveState : Node
{
    private Player characterNode;
    public override void _Ready()
    {
        characterNode = GetOwner<Player>();
        SetPhysicsProcess(false);
    }

    public override void _PhysicsProcess(double delta)
    {
        GD.Print("MoveState physicis process");
        if (characterNode.direction == Vector2.Zero) {
            characterNode.stateMachineNode.SwitchState<IdleState>();
         }
    }

    public override void _Notification(int what)
    {
        base._Notification(what);
        if (what == 5001)
        {
           // Called every time the node is added to the scene.
            // Mit GetOwner<Player>() wird der Player-Knoten geholt
            characterNode.animPlayerNode.Play(GameConstants.ANIM_MOVE);
            SetPhysicsProcess(true);
        }
        else if (what == 5002)
        {
            // Called every time the node is removed from the scene.
            //characterNode.animPlayerNode.Stop();
            SetPhysicsProcess(false);
        }
    }
}