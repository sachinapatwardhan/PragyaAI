public class DatabaseConnection
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public DatabaseProvider Provider { get; set; }

    public string Server { get; set; } = string.Empty;

    public string Database { get; set; } = string.Empty;

    public AuthenticationType AuthenticationType { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public bool IsEncrypted { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
}
