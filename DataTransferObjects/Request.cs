using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

using GeoJSON.Net.Feature;

namespace Iida.Shared.DataTransferObjects;

public class Request {
	[JsonPropertyOrder(0), JsonPropertyName("geojson"), Required]
	public FeatureCollection? GeoJson { get; set; }
	[JsonPropertyOrder(1), JsonPropertyName("start_date"), Required]
	public DateTimeOffset? Start { get; set; }
	[JsonPropertyOrder(2), JsonPropertyName("end_date"), Required]
	public DateTimeOffset? End { get; set; }
	[JsonPropertyOrder(3), JsonPropertyName("cloud_cover"), Required]
	public string? CloudCover { get; set; }
}