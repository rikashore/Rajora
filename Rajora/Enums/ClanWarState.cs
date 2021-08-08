using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Rajora
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClanWarState
    {
        [EnumMember(Value = "preparation")]
        Preparation,

        [EnumMember(Value = "inWar")]
        InWar,

        [EnumMember(Value = "ended")]
        Ended
    }
}