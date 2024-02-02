using Godot;

namespace Reoria.Nodes;

/// <summary>
/// Defines functionality of the main <see cref="Node2D"/>.
/// </summary>
public partial class GameEngine : Node2D
{
	/// <summary>
	/// The reference to the root <see cref="Node"/>.
	/// </summary>
	private static GameEngine instance;

	/// <summary>
	/// The reference to the root <see cref="Node"/>.
	/// </summary>
	public static GameEngine Instance
	{
		get
		{
			// Check to see if the root node is assigned, and return it if it has, if it has not then close the game.
			return instance is not null ? instance
				: throw new NullReferenceException("The root node reference has been lost, the game will now close.");
		}
	}

	/// <summary>
	/// Defines the reference to the primary <see cref="Camera2D"/>.
	/// </summary>
	[Export]
	public Camera2D Camera { get; protected set; }

	/// <summary>
	/// Constructs a new <see cref="GameEngine"/> instance and assignes the reference to it to <see cref="Instance"/>.
	/// </summary>
	public GameEngine()
	{
		// Check to see if the root node has already been created.
		if (instance is not null)
		{
			// Yes it has, we can not allow "Dave" to do this.
			throw new InvalidOperationException("The game can not create more then one root node, the game will now close.");
		}

		// Assign this instance of the root node to the instance property.
		instance = this;
	}

	/// <summary>
	/// Disposes and releases resources used by the class.
	/// </summary>
	~GameEngine()
	{
		// Check to see if the root node has already been created.
		if (instance is not null)
		{
			// Assign this instance of the root node to the instance property.
			instance = null;
		}
	}

	/// <summary>
	/// Called when the node is "ready", i.e. when both the node and its children have
	/// entered the scene tree. If the node has children, their <see cref="Node._Ready"/> 
	/// callbacks get triggered first, and the parent node will receive the ready 
	/// notification afterwards.
	/// </summary>
	public override void _Ready()
	{
		// Fetch and assign the child nodes if they have not been assigned yet.
		this.Camera ??= this.GetNode<Camera2D>("Camera");

		// Pass to the base class' function.
		base._Ready();
	}
}
