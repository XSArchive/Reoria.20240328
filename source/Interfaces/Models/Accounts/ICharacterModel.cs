namespace Reoria.Interfaces.Models.Accounts;

/// <summary>
/// Provides the properties and functions of character data models.
/// </summary>
public interface ICharacterModel
{
    /// <summary>
    /// A string representing the name of the character.
    /// </summary>
    string Name { get; set; }
}