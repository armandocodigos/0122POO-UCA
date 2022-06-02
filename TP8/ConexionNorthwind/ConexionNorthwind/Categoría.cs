namespace ConexionNorthwind
{
    public class Categoría
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public Categoría()
        {
            this.CategoryID = 0;
            this.CategoryName = "";
            this.Description = "";
        }

        public Categoría(int categoryId, string categoryName, string description)
        {
            CategoryID = categoryId;
            CategoryName = categoryName;
            Description = description;
        }
    }
}