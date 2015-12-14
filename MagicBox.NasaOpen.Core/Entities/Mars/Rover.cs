using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MagicBox.NasaOpen.Entities.Mars
{
    /// <summary>
    /// The rover of the mission the photos were taken.
    /// </summary>
    [JsonObject]
    public sealed class Rover : IEntity
    {
        /// <summary>
        /// The cameras of this rover had.
        /// </summary>
        [JsonProperty("cameras")]
        public IEnumerable<CameraBase> Cameras { get; set; }

        /// <summary>
        /// The rover identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The rover landing date.
        /// </summary>
        [JsonProperty("landing_date")]
        public DateTime LandingDate { get; set; }

        /// <summary>
        /// The maximum value for the earth date.
        /// </summary>
        [JsonProperty("max_date")]
        public DateTime MaxDate { get; set; }

        /// <summary>
        /// The maximum value to martial sol.
        /// </summary>
        [JsonProperty("max_sol")]
        public int MaxSol { get; set; }

        /// <summary>
        /// The rover name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The amount of photos that this rover taken.
        /// </summary>
        [JsonProperty("total_photos")]
        public long TotalPhotos { get; set; }
    }
}