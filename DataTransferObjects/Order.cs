using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

using GeoJSON.Net.Feature;

namespace Iida.Shared.DataTransferObjects;

public class Order {
	[JsonPropertyOrder(0), JsonPropertyName("guid"), Required]
	public Guid? Guid { get; set; }
	[JsonPropertyOrder(1), JsonPropertyName("fecha_orden"), Required]
	public DateTimeOffset? TimeStamp { get; set; }
	[JsonPropertyOrder(2), JsonPropertyName("geojson"), Required]
	public FeatureCollection? GeoJson { get; set; }
	[JsonPropertyOrder(3), JsonPropertyName("fecha_inicio"), Required]
	public DateOnly? Start { get; set; }
	[JsonPropertyOrder(4), JsonPropertyName("fecha_fin"), Required]
	public DateOnly? End { get; set; }
	[JsonPropertyOrder(5), JsonPropertyName("porcentaje_cobertura_nubes"), Required]
	public string? CloudCover { get; set; }
	[JsonPropertyOrder(6), JsonPropertyName("mapas_evapotranspiración"), Required]
	public virtual ICollection<EvapotranspirationMap>? EvapotranspirationMaps { get; set; }
	[JsonPropertyOrder(7), JsonPropertyName("datos_meteorológicos"), Required]
	public virtual ICollection<MeteorologicalData>? MeteorologicalDatas { get; set; }
}