using System;
using Newtonsoft.Json;

namespace MagicBox.NasaOpen.Entities.Apod
{
    /// <summary>
    /// The response of a request for a APOD API.
    /// </summary>
    [JsonObject]
    public sealed class PlanetaryResponse
    {
        /// <summary>
        /// The url for the main planetary response.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}