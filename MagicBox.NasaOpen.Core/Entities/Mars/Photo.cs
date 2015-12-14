using System;
using Windows.UI.Xaml.Media;
using Newtonsoft.Json;

namespace MagicBox.NasaOpen.Entities.Mars
{
    /// <summary>
    /// Represents a single photo from Mars.
    /// </summary>
    [JsonObject]
    public sealed class Photo : IEntity
    {
        /// <summary>
        /// The date on Earth.
        /// </summary>
        [JsonProperty("earth_date")]
        public DateTime EarthDate { get; set; }

        /// <summary>
        /// Photo identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The mid quality image.
        /// </summary>
        [JsonProperty("img_src")]
        public ImageSource Image { get; set; }

        /// <summary>
        /// Martian rotation or day.
        /// </summary>
        [JsonProperty("sol")]
        public long Sol { get; set; }

        /// <summary>
        /// The camera from where the photo was taken.
        /// </summary>
        [JsonProperty("camera")]
        public Camera SourceCamera { get; set; }

        /// <summary>
        /// The rover that captures this photo.
        /// </summary>
        [JsonProperty("rover")]
        public Rover SourceRover { get; set; }
    }
}