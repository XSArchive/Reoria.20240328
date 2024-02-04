using Godot;
using Reoria.Interfaces.Models.Characters;

namespace Reoria.Models.Characters;

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
