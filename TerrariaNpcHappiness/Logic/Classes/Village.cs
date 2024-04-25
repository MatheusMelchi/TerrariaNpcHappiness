using TerrariaNpcHappiness.Logic.Enum;

namespace TerrariaNpcHappiness.Logic.Classes
{
    public class Village
    {
        public Village()
        {
            NPCs = new List<NPC>();
        }

        public BiomesEnum Biome { get; set; }
        public List<NPC> NPCs { get; set; }
    }
}
