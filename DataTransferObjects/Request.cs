using System.ComponentModel.DataAnnotations;

using GeoJSON.Net.Feature;

using Newtonsoft.Json;

namespace Iida.Shared.DataTransferObjects;

public class Request {
	[JsonProperty("geojson"), Required]
	public FeatureCollection? GeoJson { get; set; }
	[JsonProperty("start_date"), Required]
	public DateTimeOffset? Start { get; set; }
	[JsonProperty("end_date"), Required]
	public DateTimeOffset? End { get; set; }
	[JsonProperty("cloud_cover"), Required]
	public double CloudCover { get; set; }
	[JsonIgnore]
	public Guid Guid { get; set; }
}