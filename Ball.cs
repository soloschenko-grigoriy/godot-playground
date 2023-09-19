namespace Godot;

public partial class Ball : RigidBody2D
{
    public override void _Ready()
    {
       GD.Print("Hello!");
    }

    public override void _Process(double delta)
    {
        base._Process(delta);
        GD.Print("Process");
    }
}