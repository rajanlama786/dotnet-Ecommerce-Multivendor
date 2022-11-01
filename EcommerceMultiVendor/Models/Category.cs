namespace EcommerceMultiVendor.Models
{
    public class Category
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }

        public int GetID() => Id;

        public string GetCatName() => Name;

        public string GetDescription() => Description;

        public void SetId( int id ) {
            Id = id;
        }

        public void SetCatName(string name)
        {
            Name = name;
        }

        public void SetDescritpion( string description )
        {
            Description = description;
        }
    }
}
