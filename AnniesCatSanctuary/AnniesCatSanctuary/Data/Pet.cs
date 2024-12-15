namespace AnniesCatSanctuary.Data
{
    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; } // For example: Dog, Cat, etc.
        public string Description { get; set; }
        public bool IsFavorite { get; set; } // Will be used to mark a pet as a favorite
        public bool IsHidden { get; set; } // Add IsHidden property
    }
}
