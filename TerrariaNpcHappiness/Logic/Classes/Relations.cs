using TerrariaNpcHappiness.Logic.Enum;

namespace TerrariaNpcHappiness.Logic.Classes
{
    public class Relations
    {
        public NPCIdentificationEnum NPC { get; set; }
        public BiomesEnum[] LikedBiomes { get; set; }
        public BiomesEnum[] DislikedBiomes { get; set; }
        public NPCIdentificationEnum[] LovedNpcs { get; set; }
        public NPCIdentificationEnum[] LikedNpcs { get; set; }
        public NPCIdentificationEnum[] DislikedNpcs { get; set; }
        public NPCIdentificationEnum[] HatedNpcs { get; set; }
    }
}
