using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

namespace Iida.Shared.DataTransferObjects;

[JsonObject]
public abstract class Result {
	[JsonProperty("guid"), Required]
	public Guid? Guid { get; set; }
	[JsonProperty("result_date"), Required]
	public DateTimeOffset? Timestamp { get; set; }
	[JsonProperty("url"), Required]
	public string? Url { get; set; }
}