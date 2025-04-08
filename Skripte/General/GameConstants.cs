using Godot;
using System;

/* 
 * This class is used to store all the constants used in the game.
 * This is a good practice to keep all the constants in one place so that they can be easily accessed and modified.
 * This class is inherited from Node class so that it can be added to the scene tree and accessed from any script.
 * 
 * This class contains the following constants:
 * 1. Animations: This class contains the names of the animations used in the game.
 * 2. Input: This class contains the names of the input actions used in the game.
 * 
 * This class is used in the following scripts:
 * 1. Player.cs
 * 2. PlayerMovement.cs
 * 3. PlayerAnimation.cs
 * 4. PlayerInput.cs
 * 
 * This class is added to the scene tree in the following scenes:
 * 1. Player.tscn
 */
 
public partial class GameConstants : Node
{
	// Animations
	public const string ANIM_IDLE = "Idle";
	public const string ANIM_MOVE = "Moving";
	public const string ANIM_DASH = "Dash";
	
	//Input
	public const string INPUT_MOVE_LEFT = "MoveLeft";
	public const string INPUT_MOVE_RIGHT = "MoveRight";
	public const string INPUT_MOVE_FORWARD = "MoveForward";
	public const string INPUT_MOVE_BACKWARD = "MoveBackward";
	public const string INPUT_DASH = "Dash";

	// Notifications
	public const int NOTIFICATION_ENTER_STATE = 5001;
	public const int NOTIFICATION_EXIT_STATE = 5002;
	public const int NOTIFICATION_ENTER_IDLE = 5003;
	public const int NOTIFICATION_ENTER_MOVE = 5004;
	public const int NOTIFICATION_ENTER_DASH = 5005;
	public const int NOTIFICATION_ENTER_ATTACK = 5006;
	public const int NOTIFICATION_ENTER_JUMP = 5007;
}
