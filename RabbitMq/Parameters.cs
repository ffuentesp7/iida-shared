namespace Iida.Shared.RabbitMq;

public class Parameters : Configuration {
	public string? Hostname { get; set; }
	public string? Queue { get; set; }
	public string? Username { get; set; }
	public string? Password { get; set; }
}