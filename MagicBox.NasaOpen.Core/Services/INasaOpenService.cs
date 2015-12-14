namespace MagicBox.NasaOpen.Services
{
    /// <summary>
    /// Defines the properties and methods to a NASA Open service.
    /// </summary>
    public interface INasaOpenService
    {
        /// <summary>
        /// Get the current NASA Open APIs.
        /// </summary>
        INasaApi Api { get; }
    }
}