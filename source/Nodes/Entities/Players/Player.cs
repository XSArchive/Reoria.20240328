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
}
