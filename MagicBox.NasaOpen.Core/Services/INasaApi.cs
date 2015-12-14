using MagicBox.NasaOpen.Entities.Mars;
using MagicBox.NasaOpen.Helpers;
using Refit;
using System;
using System.Threading.Tasks;

namespace MagicBox.NasaOpen.Services
{
    /// <summary>
    /// Defines the method that the NASA Open APIs provides.
    /// </summary>
    public interface INasaApi
    {
        /// <summary>
        /// Search for photos from Mars of a specific rover on Mars where the search of date is done based in the Earth date.
        /// </summary>
        /// <param name="rover">The name of the rover from the photo was getted.</param>
        /// <param name="earthDate">The date on Earth.</param>
        /// <param name="camera">A specific camera to work on.</param>
        /// <param name="page">A specific page to navigate to, 25 items per page returned.</param>
        /// <param name="apiKey">The api key that should be used, api.nasa.gov key for expanded usage.</param>
        /// <returns>A maximum of 25 photos from Mars of one of the rovers based in the Earth date.</returns>
        /// <remarks>
        /// More details on: https://api.nasa.gov/api.html#MarsPhotos
        /// </remarks>
        [Get(NasaApiHelper.MarsRoverPhotos)]
        Task<RoverResponse> GetMarsRoverPhotosByEarthDateAsync(RoverOnMars rover, DateTime earthDate, RoverCamera camera, int page, [AliasAs("api_key")] string apiKey);

        /// <summary>
        /// Get a list of photos from rovers on Mars  where the indicator of date in time is made by martial sol.
        /// </summary>
        /// <param name="rover">The name of the rover from the photo was getted.</param>
        /// <param name="sol">sol (ranges from 0 to max found in endpoint).</param>
        /// <param name="camera">A specific camera to work on.</param>
        /// <param name="page">A specific page to navigate to, 25 items per page returned.</param>
        /// <param name="apiKey">The api key that should be used, api.nasa.gov key for expanded usage.</param>
        /// <returns>A maximum of 25 photos from Mars of a specific rover based in the martial sol.</returns>
        /// <remarks>
        /// More details on: https://api.nasa.gov/api.html#MarsPhotos
        /// </remarks>
        [Get(NasaApiHelper.MarsRoverPhotos)]
        Task<RoverResponse> GetMarsRoverPhotosByMartialSolAsync(RoverOnMars rover, int sol, RoverCamera camera, int page, [AliasAs("api_key")] string apiKey);
    }
}