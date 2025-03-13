extends Node2D

var player_turn = true
var player_hp = 100
var enemy_hp = 50

# Called when the node enters the scene tree for the first time.
func _on_attack_button_pressed():
	if player_turn:
		enemy_hp -= 20
		print("Enemy HP: ", enemy_hp)
		player_turn = false
	else:
		player_hp -= 10
		print("Player HP: ", player_hp)
		player_turn = true
  
