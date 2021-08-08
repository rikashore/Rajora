using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Rajora
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClanType
    {
        [EnumMember(Value = "InviteOnly")]
        InviteOnly,

        [EnumMember(Value = "Closed")]
        Closed,

        [EnumMember(Value = "Open")]
        Open
    }
}