namespace Iida.Shared.Usgs;

public class SearchSceneResponse {
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public int requestId { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? version { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public int sessionId { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public Data? data { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public object? errorCode { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public object? errorMessage { get; set; }
}

public class Data {
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public Result?[]? results { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public int recordsReturned { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public int totalHits { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? totalHitsAccuracy { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public bool isCustomized { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public int numExcluded { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public int startingNumber { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public int nextRecord { get; set; }
}

public class Result {
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public Browse?[]? browse { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? cloudCover { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? entityId { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? displayId { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public object? orderingId { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public object?[]? metadata { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public object? hasCustomizedMetadata { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public Options? options { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public Selected? selected { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public Spatialbounds? spatialBounds { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public Spatialcoverage? spatialCoverage { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public Temporalcoverage? temporalCoverage { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? publishDate { get; set; }
}

public class Options {
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public bool bulk { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public bool download { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public bool order { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public bool secondary { get; set; }
}

public class Selected {
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public bool bulk { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public bool compare { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public bool order { get; set; }
}

public class Spatialbounds {
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? type { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public double?[]?[]?[]? coordinates { get; set; }
}

public class Spatialcoverage {
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? type { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public double?[]?[]?[]? coordinates { get; set; }
}

public class Temporalcoverage {
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? endDate { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? startDate { get; set; }
}

public class Browse {
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? id { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public object? browseRotationEnabled { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? browseName { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? browsePath { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? overlayPath { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? overlayType { get; set; }
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "USGS JSON parsing")]
	public string? thumbnailPath { get; set; }
}