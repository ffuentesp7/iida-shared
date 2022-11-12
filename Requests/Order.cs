namespace Iida.Shared.Requests;

/// <summary>
/// Order request.
/// </summary>
public class Order {
	/// <summary>
	/// GeoJSON polygon of the crop.
	/// </summary>
	public string? GeoJsonString { get; set; }
	/// <summary>
	/// Request start date.
	/// </summary>
	public DateTimeOffset? Start { get; set; }
	/// <summary>
	/// Request end date.
	/// </summary>
	public DateTimeOffset? End { get; set; }
}