using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Rajora
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PlayerRole
    {
        [EnumMember(Value = "member")]
        Member,

        [EnumMember(Value = "admin")]
        Admin,

        [EnumMember(Value = "coLeader")]
        CoLeader,

        [EnumMember(Value = "leader")]
        Leader
    }
}