using Godot;
using Reoria.Godot.Interfaces.Entities;

namespace Reoria.Godot.Nodes.Entities;

/// <summary>
/// Defines the properties and functions of nodes that inherit from <see cref="RigidBody2D"/>.
/// </summary>
public partial class RigidEntity : RigidBody2D, IRigidEntity
{
    /// <summary>
    /// A node that provides a <see cref="Shape2D"/> to a <see cref="CollisionObject2D"/> parent and
    /// allows to edit it. This can give a detection shape to an <see cref="Area2D"/> or turn
    /// a <see cref="PhysicsBody2D"/> into a solid object.
    /// </summary>
    public CollisionShape2D CollisionShape { get; protected set; }
    /// <summary>
    /// A node that displays a 2D texture. The texture displayed can be a region from
    /// a larger atlas texture, or a frame from a sprite sheet animation.
    /// </summary>
	public Sprite2D Sprite { get; protected set; }

    /// <summary>
    /// Called when the node is "ready", i.e. when both the node and its children have
    /// entered the scene tree. If the node has children, their <see cref="Node._Ready"/> 
    /// callbacks get triggered first, and the parent node will receive the ready 
    /// notification afterwards.
    /// </summary>
    public override void _Ready()
    {
        // Fetch and assign the child node variables.
        this.CollisionShape = this.GetNode<CollisionShape2D>("CollisionShape");
        this.Sprite = this.GetNode<Sprite2D>("Sprite");

        // Pass to the base class' function.
        base._Ready();
    }
}
