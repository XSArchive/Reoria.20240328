using Godot;

namespace Reoria.Nodes.Entitites.Interfaces;

/// <summary>
/// Provides the properties and functions of nodes that inherit from <see cref="CharacterBody2D"/>, <see cref="RigidBody2D"/>, or <see cref="StaticBody2D"/>.
/// </summary>
public interface IEntity
{
    /// <summary>
    /// A node that provides a <see cref="Shape2D"/> to a <see cref="CollisionObject2D"/> parent and
    /// allows to edit it. This can give a detection shape to an <see cref="Area2D"/> or turn
    /// a <see cref="PhysicsBody2D"/> into a solid object.
    /// </summary>
    CollisionShape2D CollisionShape { get; }
    /// <summary>
    /// A node that displays a 2D texture. The texture displayed can be a region from
    /// a larger atlas texture, or a frame from a sprite sheet animation.
    /// </summary>
	Sprite2D Sprite { get; }
}
