using Godot;
using System;

public partial class MoveState : Node
{
    public override void _Ready()
    {
        
    }

    public override void _Notification(int what)
    {
        base._Notification(what);
        if (what == 5001)
        {
           // Called every time the node is added to the scene.
            // Mit GetOwner<Player>() wird der Player-Knoten geholt
            Player characterNode = GetOwner<Player>();
            characterNode.animPlayerNode.Play(GameConstants.ANIM_MOVE);
        }
    }
}