using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

using GeoJSON.Net.Feature;

namespace Iida.Shared.DataTransferObjects;

public class Order {
	[JsonPropertyName("geoJson"), Required]
	public FeatureCollection? GeoJson { get; set; }
	[JsonPropertyName("fecha_inicio"), Required]
	public DateOnly? Start { get; set; }
	[JsonPropertyName("fecha_fin"), Required]
	public DateOnly? End { get; set; }
	[JsonPropertyName("porcentaje_cobertura_nubes"), Required]
	public string? CloudCover { get; set; }
}