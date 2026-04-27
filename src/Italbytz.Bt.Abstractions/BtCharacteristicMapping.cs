namespace Italbytz.Bt.Abstractions;

public sealed class BtCharacteristicMapping
{
    public BtCharacteristicMapping(
        string name,
        string serviceUuid,
        string characteristicUuid,
        bool canRead,
        bool canWrite,
        bool canNotify)
    {
        Name = name;
        ServiceUuid = serviceUuid;
        CharacteristicUuid = characteristicUuid;
        CanRead = canRead;
        CanWrite = canWrite;
        CanNotify = canNotify;
    }

    public string Name { get; }

    public string ServiceUuid { get; }

    public string CharacteristicUuid { get; }

    public bool CanRead { get; }

    public bool CanWrite { get; }

    public bool CanNotify { get; }
}