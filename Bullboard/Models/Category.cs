namespace Bullboard.Models
{
    /// <summary>
    /// Category model
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the category identifier.
        /// </summary>
        public long CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the category name.
        /// </summary>
        public string Name { get; set; }
    }
}