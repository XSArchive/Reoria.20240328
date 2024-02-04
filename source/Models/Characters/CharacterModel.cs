using Reoria.Interfaces.Models.Accounts;

namespace Reoria.Models.Characters;

/// <summary>
/// Defines the properties and functions of character data models.
/// </summary>
public partial class CharacterModel : Model, ICharacterModel
{
    /// <summary>
    /// A string representing the name of the character.
    /// </summary>
    public string Name { get; set; } = "New Character";
}
