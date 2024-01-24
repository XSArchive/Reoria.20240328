using Godot;
using Reoria.Nodes;
using Reoria.Nodes.Entitites.Players.Interfaces;

namespace Reoria.Godot.Nodes.Entities.Players;

/// <summary>
/// Defines the properties and functions of nodes controlled by players.
/// </summary>
public partial class Player : KinematicEntity, IPlayer
{
    /// <summary>
    /// Called when the node is "ready", i.e. when both the node and its children have
    /// entered the scene tree. If the node has children, their <see cref="Node._Ready"/> 
    /// callbacks get triggered first, and the parent node will receive the ready 
    /// notification afterwards.
    /// </summary>
    public override void _Ready()
    {
        // Pass to the base class' function.
        base._Ready();
    }

    public override void _Process(double delta)
    {
        this.Velocity = Vector2.Zero;
        var move_speed = 32;

        if (Input.IsKeyPressed(Key.W)) { this.Velocity += Vector2.Up * move_speed; }
        if (Input.IsKeyPressed(Key.S)) { this.Velocity += Vector2.Down * move_speed; }
        if (Input.IsKeyPressed(Key.A)) { this.Velocity += Vector2.Left * move_speed; }
        if (Input.IsKeyPressed(Key.D)) { this.Velocity += Vector2.Right * move_speed; }

        if(this.Velocity != Vector2.Zero)
        {
            this.CollisionShape.SetDeferred("Disabled", false);
            _ = this.MoveAndSlide();
        }
        else
        {
            this.CollisionShape.SetDeferred("Disabled", true);
        }

        base._Process(delta);
    }
}
