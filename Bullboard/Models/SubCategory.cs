namespace Bullboard.Models
{
    /// <summary>
    /// SubCategory model
    /// </summary>
    public class SubCategory
    {
        /// <summary>
        /// Gets or sets the  subcategory identifier.
        /// </summary>
        public long SubCategoryId { get; set; }

        /// <summary>
        /// Gets or sets the subcaegory name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the subcaegory name.
        /// </summary>
        public long CategoryId { get; set; }
    }
}