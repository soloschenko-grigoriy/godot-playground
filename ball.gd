extends RigidBody2D

@export var x: int = 5

@export_category("Main Category")
@export var number = 3
@export var string = ""

@export_category("Extra Category")
@export var flag = false

signal hello


func _init():
	print("hello")
