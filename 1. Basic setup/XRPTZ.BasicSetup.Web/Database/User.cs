namespace XRPTZ.BasicSetup.Web.Database;

public record User
{
    public required int Id { get; init; }
    public required string FullName { get; init; }
    public required string Username { get; init; }
    public required string Email { get; init; }
}
