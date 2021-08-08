using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Rajora
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WarFrequency
    {
        [EnumMember(Value = "unknown")]
        Unknown,

        [EnumMember(Value = "never")]
        Never,

        [EnumMember(Value = "lessThanOncePerWeek")]
        LessThanOncePerWeek,

        [EnumMember(Value = "oncePerWeek")]
        OncePerWeek,

        [EnumMember(Value = "moreThanOncePerWeek")]
        MoreThanOncePerWeek,

        [EnumMember(Value = "always")]
        Always
    }
}