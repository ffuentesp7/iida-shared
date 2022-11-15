using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Iida.Shared.DataTransferObjects;

public class Result {
	[JsonPropertyOrder(0), JsonPropertyName("guid"), Required]
	public Guid? Guid { get; set; }
	[JsonPropertyOrder(1), JsonPropertyName("result_date"), Required]
	public DateTimeOffset? Timestamp { get; set; }
	[JsonPropertyOrder(2), JsonPropertyName("url"), Required]
	public string? Url { get; set; }
}