using Godot;
using Reoria.Godot.Interfaces.Models.Accounts;
using Reoria.Godot.Models.Characters;
using System;

namespace Reoria.Godot.Models.Accounts;

/// <summary>
/// Defines the properties and functions of account data models.
/// </summary>
[GlobalClass]
public partial class AccountModel : Model, IAccountModel
{
    /// <summary>
    /// A string that represents the email used to authenticate this account.
    /// </summary>
    [Export]
    public string Email { get; set; } = string.Empty;
    /// <summary>
    /// A string that represents the password used to authenticate this account.
    /// </summary>
    [Export]
    public string Password { get; set; } = string.Empty;
    /// <summary>
    /// A list of <see cref="CharacterModel"/> classes that this account owns.
    /// </summary>
    [Export]
    public CharacterModel[] Characters = Array.Empty<CharacterModel>();
}
