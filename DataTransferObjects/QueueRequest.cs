using System.ComponentModel.DataAnnotations;

using GeoJSON.Net.Feature;

using Newtonsoft.Json;

namespace Iida.Shared.DataTransferObjects;

[JsonObject]
public class QueueRequest {
	[JsonProperty("geojson"), Required]
	public FeatureCollection? GeoJson { get; set; }
	[JsonProperty("timestamp"), Required]
	public DateTimeOffset? Timestamp { get; set; }
	[JsonProperty("start_date"), Required]
	public DateTimeOffset? Start { get; set; }
	[JsonProperty("end_date"), Required]
	public DateTimeOffset? End { get; set; }
	[JsonProperty("cloud_cover"), Required]
	public double CloudCover { get; set; }
	[JsonProperty("guid"), Required]
	public Guid Guid { get; set; }
}