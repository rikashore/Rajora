using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Rajora
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WarlogResult
    {
        [EnumMember(Value = "lose")]
        Lose,

        [EnumMember(Value = "tie")]
        Tie,

        [EnumMember(Value = "win")]
        Win
    }
}