using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

using GeoJSON.Net.Feature;

namespace Iida.Shared.DataTransferObjects;

public class Order {
	[JsonPropertyOrder(0), JsonPropertyName("guid"), Required]
	public Guid? Guid { get; set; }
	[JsonPropertyOrder(1), JsonPropertyName("timestamp"), Required]
	public DateTimeOffset? TimeStamp { get; set; }
	[JsonPropertyOrder(2), JsonPropertyName("geojson"), Required]
	public FeatureCollection? GeoJson { get; set; }
	[JsonPropertyOrder(3), JsonPropertyName("start_date"), Required]
	public DateTimeOffset? Start { get; set; }
	[JsonPropertyOrder(4), JsonPropertyName("end_date"), Required]
	public DateTimeOffset? End { get; set; }
	[JsonPropertyOrder(5), JsonPropertyName("cloud_cover"), Required]
	public string? CloudCover { get; set; }
	[JsonPropertyOrder(6), JsonPropertyName("actual_evapotranspiration_maps"), Required]
	public virtual ICollection<EvapotranspirationMap>? EvapotranspirationMaps { get; set; }
	[JsonPropertyOrder(7), JsonPropertyName("meteorological_data"), Required]
	public virtual ICollection<MeteorologicalData>? MeteorologicalDatas { get; set; }
}