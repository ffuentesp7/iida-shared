namespace Iida.Shared.Usgs;

public class DataProductId {
	private DataProductId(string value) => Value = value;
	public string Value {
		get; private set;
	}
	public static DataProductId LandsatTmC1 => new("5e83d08ee1e2890b");
	public static DataProductId LandsatEtmC1 => new("5e83a506f72553b6");
	public static DataProductId Landsat8C1 => new("5e83d0b656b77cf3");
	public static DataProductId LandsatTmC2L1 => new("5e83d0a05ee25348");
	public static DataProductId LandsatEtmC2L1 => new("5e83d0d02b146ae0");
	public static DataProductId LandsatOtC2L1 => new("5e81f14f59432a27");
	public static DataProductId LandsatTmC2L2 => new("5e83d1193824e4fc");
	public static DataProductId LandsatEtmC2L2 => new("5e83d12add5d4aa1");
	public static DataProductId LandsatOtC2L2 => new("5e83d14f2fc39685");
	public static DataProductId Sentinel2a => new("5e83a42ca9977c30");
}