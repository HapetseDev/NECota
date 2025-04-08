using Godot;
using System;

public partial class DashState : PlayerState
{
    [Export] private Timer dashTimerNode;
    [Export(PropertyHint.Range, "0,30,0.1")] private float dashSpeed = 20f;


    public override void _Ready()
    {
        base._Ready();
        dashTimerNode.Timeout += HandleDashTimeout;
        
    }

    public override void _PhysicsProcess(double delta)
    {
        
       // if (characterNode.direction != Vector2.Zero) {
       //     characterNode.stateMachineNode.SwitchState<MoveState>();
       //  }
        characterNode.MoveAndSlide();
        characterNode.Flip();
    }

    protected override void EnterState()
    {        
           // Called every time the node is added to the scene.
            // Mit GetOwner<Player>() wird der Player-Knoten geholt
            characterNode.AnimPlayerNode.Play(GameConstants.ANIM_DASH);
            characterNode.Velocity = new(characterNode.direction.X, 0, characterNode.direction.Y);
            characterNode.Velocity *= dashSpeed;

            if (characterNode.Velocity == Vector3.Zero)
            {
                // Wenn der Spieler nicht in eine Richtung bewegt wird, wird die Richtung auf die aktuelle Sprite-Richtung gesetzt
                characterNode.Velocity = characterNode.SpriteNode.FlipH ? Vector3.Left : Vector3.Right;
            }            
            dashTimerNode.Start();
            SetPhysicsProcess(true);       
    }

    private void HandleDashTimeout()
    {
        characterNode.Velocity = Vector3.Zero;
        characterNode.StateMachineNode.SwitchState<IdleState>();
        dashTimerNode.Stop();
        
    }
}