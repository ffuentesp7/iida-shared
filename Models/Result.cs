using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Iida.Shared.Models;

public abstract class Result {
	[Column("id", Order = 0), Key, Required]
	public int Id { get; set; }
	[Column("guid", Order = 1), Required]
	public Guid Guid { get; set; }
	[Column("timestamp", Order = 2), Required]
	public DateTimeOffset? Timestamp { get; set; }
	[Column("url", Order = 3), Required]
	public string? Url { get; set; }
	[Column("order_fk", Order = 4), Required]
	public virtual Order? Order { get; set; }
	[Column("version"), ConcurrencyCheck]
	public Guid Version { get; set; }
}