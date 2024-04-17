using Godot;
using System;

public partial class main : Node2D
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {   
        string path = "res://scenes/drop.tscn";
        PackedScene packedScene = GD.Load<PackedScene>(path);

		for (int i = 0; i < 5; i++)
		{
			Node2D instance = (Node2D)packedScene.Instantiate();
			instance.GlobalPosition = new Vector2(20,20);
			AddChild(instance);
		}
    }
    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {

    }
}
