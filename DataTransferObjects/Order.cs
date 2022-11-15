using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

namespace Iida.Shared.DataTransferObjects;

[JsonObject]
public class Order {
	[JsonProperty("guid"), Required]
	public Guid? Guid { get; set; }
	[JsonProperty("status"), Required]
	public string? Status { get; set; }
	[JsonProperty("timestamp"), Required]
	public DateTimeOffset? Timestamp { get; set; }
	[JsonProperty("start_date"), Required]
	public DateTimeOffset? Start { get; set; }
	[JsonProperty("end_date"), Required]
	public DateTimeOffset? End { get; set; }
	[JsonProperty("cloud_cover"), Required]
	public double CloudCover { get; set; }
	[JsonProperty("evapotranspiration_maps"), Required]
	public virtual ICollection<EvapotranspirationMap>? EvapotranspirationMaps { get; set; } = new HashSet<EvapotranspirationMap>();
	[JsonProperty("meteorological_data"), Required]
	public virtual ICollection<MeteorologicalData>? MeteorologicalDatas { get; set; } = new HashSet<MeteorologicalData>();
	[JsonProperty("satellite_images"), Required]
	public virtual ICollection<SatelliteImage>? SatelliteImages { get; set; } = new HashSet<SatelliteImage>();

}