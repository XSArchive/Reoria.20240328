using Godot;
using Reoria.Godot.Interfaces.Models.Characters;

namespace Reoria.Godot.Models.Characters;

/// <summary>
/// Defines the properties and functions of character data models.
/// </summary>
[GlobalClass]
public partial class CharacterModel : Model, ICharacterModel
{
    /// <summary>
    /// A string representing the name of the character.
    /// </summary>
    [Export]
    public string Name { get; set; } = "New Character";
}
