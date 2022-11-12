using GeoJSON.Net.Feature;

namespace Iida.Shared.Requests;

public class Order {
	public FeatureCollection? FeatureCollection { get; set; }
	public DateTimeOffset? Start { get; set; }
	public DateTimeOffset? End { get; set; }
}