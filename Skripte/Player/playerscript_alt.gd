extends CharacterBody2D
var speed = 100  # Bewegungsgeschwindigkeit
func _physics_process(delta):
	var direction = Vector2.ZERO
	if Input.is_action_pressed("ui_right"):
		direction.x += 1
	if Input.is_action_pressed("ui_left"):
		direction.x -= 1
	if Input.is_action_pressed("ui_down"):
		direction.y += 1
	if Input.is_action_pressed("ui_up"):
		direction.y -= 1
	
	# Normalisiere die Richtung, damit diagonale Bewegung nicht schneller ist
	direction = direction.normalized()
	velocity = direction * speed
	move_and_slide()

func _on_area_2d_body_entered(body):
	if body.name == "Player":  # Überprüft, ob der Spieler kollidiert
		get_tree().change_scene_to_file("res://CombatScene.tscn")  # Wechselt zur Kampfszene
