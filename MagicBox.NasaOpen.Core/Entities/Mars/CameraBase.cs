using Newtonsoft.Json;

namespace MagicBox.NasaOpen.Entities.Mars
{
    /// <summary>
    /// The basic structure of data for a camera.
    /// </summary>
    [JsonObject]
    public class CameraBase
    {
        /// <summary>
        /// Camera's full description for its name.
        /// </summary>
        [JsonProperty("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// Camera's simple name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}