using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using GeoJSON.Net.Feature;

namespace Iida.Shared.Models;

[Table("order")]
public class Order {
	[Column("id", Order = 0), Key, Required]
	public int Id { get; set; }
	[Column("guid", Order = 0), Required]
	public Guid Guid { get; set; }
	[Column("geo_json", Order = 0), Required]
	public FeatureCollection? GeoJson { get; set; }
	[Column("start", Order = 0), Required]
	public DateOnly? Start { get; set; }
	[Column("end", Order = 0), Required]
	public DateOnly? End { get; set; }
	[Column("cloud_cover", Order = 0), Required]
	public string? CloudCover { get; set; }
}