namespace Reoria.Interfaces.Models.Accounts;

/// <summary>
/// Provides the properties and functions of account data models.
/// </summary>
public interface IAccountModel
{
    /// <summary>
    /// A string that represents the email used to authenticate this account.
    /// </summary>
    string Email { get; set; }
    /// <summary>
    /// A string that represents the password used to authenticate this account.
    /// </summary>
    string Password { get; set; }
}