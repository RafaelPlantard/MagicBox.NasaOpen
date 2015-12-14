using System.Collections.Generic;
using Newtonsoft.Json;

namespace MagicBox.NasaOpen.Entities.Mars
{
    /// <summary>
    /// The entity that is returned for an request to Mars Rover Photos API.
    /// </summary>
    [JsonObject]
    public sealed class RoverResponse
    {
        /// <summary>
        /// The set of photos returned.
        /// </summary>
        [JsonProperty("photos")]
        public IEnumerable<Photo> Photos { get; set; }
    }
}