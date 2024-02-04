using Reoria.Interfaces.Models.Accounts;

namespace Reoria.Models.Accounts;

/// <summary>
/// Defines the properties and functions of account data models.
/// </summary>
public partial class AccountModel : Model, IAccountModel
{
    /// <summary>
    /// A string that represents the email used to authenticate this account.
    /// </summary>
    public string Email { get; set; } = string.Empty;
    /// <summary>
    /// A string that represents the password used to authenticate this account.
    /// </summary>
    public string Password { get; set; } = string.Empty;
}
