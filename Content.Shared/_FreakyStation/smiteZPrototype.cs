using System.Numerics;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;
using Robust.Shared.Utility;

namespace Content.Shared._FreakyStation;

/// <summary>
/// Use this for custom ghost's
/// </summary>
[Prototype("SmiteZ")]
public sealed class SmiteZPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; } = default!;

    [DataField(required: true)]
    public string Ckey { get; } = default!;

}
