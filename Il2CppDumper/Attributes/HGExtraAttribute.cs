using System;

namespace Il2CppDumper
{
    /// <summary>
    /// Field only present in Hypergryph's modified metadata layout; read only when <see cref="BinaryStream.HGExtra"/> is set.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    class HGExtraAttribute : Attribute
    {
    }
}
