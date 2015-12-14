using Newtonsoft.Json;

namespace MagicBox.NasaOpen.Entities.Mars
{
    /// <summary>
    /// Full featured of data for a camera.
    /// </summary>
    [JsonObject]
    public sealed class Camera : CameraBase, IEntity
    {
        /// <summary>
        /// Camera identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Rover identifier for a specific camera.
        /// </summary>
        [JsonProperty("rover_id")]
        public int RoverId { get; set; }
    }
}