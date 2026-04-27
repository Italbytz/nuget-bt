using System.Collections.Generic;

namespace Italbytz.Bt.Abstractions;

public interface IBtProtocolProfile
{
    string ProtocolKey { get; }

    string DisplayName { get; }

    string PrimaryServiceUuid { get; }

    IReadOnlyList<string> NameTokens { get; }

    IReadOnlyList<BtCharacteristicMapping> Characteristics { get; }
}