namespace Iida.Shared.Usgs;

public class Parameters : Configuration {
	public string? Api { get; set; }
	public string? Login { get; set; }
	public string? Logout { get; set; }
	public string? SearchScene { get; set; }
	public string? DownloadScene { get; set; }
	public string? Username { get; set; }
	public string? Password { get; set; }
	public string? Dataset { get; set; }
}
