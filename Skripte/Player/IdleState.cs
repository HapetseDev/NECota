using Godot;
using System;

public partial class IdleState : Node
{
    private Player characterNode;
    public override void _Ready()
    {
        characterNode = GetOwner<Player>();
    }

    public override void _PhysicsProcess(double delta)
    {
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
            characterNode.animPlayerNode.Play(GameConstants.ANIM_IDLE);
        }
    }
}