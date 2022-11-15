using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

namespace Iida.Shared.DataTransferObjects;

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
	[JsonProperty("actual_evapotranspiration_maps"), Required]
	public virtual ICollection<EvapotranspirationMap>? EvapotranspirationMaps { get; set; }
	[JsonProperty("meteorological_data"), Required]
	public virtual ICollection<MeteorologicalData>? MeteorologicalDatas { get; set; }
}