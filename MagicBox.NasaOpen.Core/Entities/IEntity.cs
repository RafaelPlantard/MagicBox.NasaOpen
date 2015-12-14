namespace MagicBox.NasaOpen.Entities
{
    /// <summary>
    /// Defines the basic valid structure for an entity.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Entity identifier.
        /// </summary>
        string Id { get; set; }
    }
}