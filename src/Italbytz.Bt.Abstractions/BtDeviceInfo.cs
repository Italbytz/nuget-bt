namespace Italbytz.Bt.Abstractions;

public sealed class BtDeviceInfo
{
	public BtDeviceInfo(string deviceId, string name, int? rssi)
	{
		DeviceId = deviceId;
		Name = name;
		Rssi = rssi;
	}

	public string DeviceId { get; }

	public string Name { get; }

	public int? Rssi { get; }
}