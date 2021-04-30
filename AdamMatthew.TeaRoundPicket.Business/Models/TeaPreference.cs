using System;
using System.Text.Json.Serialization;

namespace AdamMatthew.TeaRoundPicket.Business.Models
{
    public class TeaPreference
    {
        [JsonPropertyName("participantId")]
        public Guid ParticipantId { get; set; }

        [JsonPropertyName("addSugar")]
        public bool AddSugar { get; set; }

        [JsonPropertyName("addMilk")]
        public bool AddMilk { get; set; }

        [JsonPropertyName("teaBrand")]
        public TeaBrand TeaBrand { get; set; } = TeaBrand.Unspecified;
    }
}
