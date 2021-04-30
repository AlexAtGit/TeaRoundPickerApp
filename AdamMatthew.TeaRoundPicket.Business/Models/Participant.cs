using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdamMatthew.TeaRoundPicket.Business.Models
{
    public class Participant
    {
        public Participant()
        {
            Id = Guid.NewGuid();
        }

        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("firstname")]
        public string Firstname { get; set; }

        [JsonPropertyName("lastname")]
        public string Lastname { get; set; }

        [JsonPropertyName("rounds")]
        public List<DateTime> Rounds { get; set; } = new List<DateTime>();
    }
}
