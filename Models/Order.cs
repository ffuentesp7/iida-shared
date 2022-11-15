using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iida.Shared.Models;

[Table("order")]
public class Order {
	[Column("id", Order = 0), Key, Required]
	public int Id { get; set; }
	[Column("guid", Order = 1), Required]
	public Guid Guid { get; set; }
	[Column("timestamp", Order = 2), Required]
	public DateTimeOffset TimeStamp { get; set; }
	[Column("start", Order = 3), Required]
	public DateTimeOffset? Start { get; set; }
	[Column("end", Order = 4), Required]
	public DateTimeOffset? End { get; set; }
	[Column("eta_maps_fk", Order = 5)]
	public virtual ICollection<EvapotranspirationMap>? EvapotranspirationMaps { get; set; }
	[Column("meteo_data_fk", Order = 6)]
	public virtual ICollection<MeteorologicalData>? MeteorologicalDatas { get; set; }
	[Column("version"), ConcurrencyCheck]
	public Guid Version { get; set; }
}