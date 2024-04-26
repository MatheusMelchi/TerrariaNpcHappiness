using TerrariaNpcHappiness.Logic.Enum;

namespace TerrariaNpcHappiness.Logic.Classes
{
    public class Village
    {
        public Village(int? villageNumber)
        {
            if (!villageNumber.HasValue)
                this.VillageNumber = 1;
            else
                this.VillageNumber = villageNumber.Value;

            NPCs = new List<Npc>();
        }

        public int VillageNumber { get; set; }
        public BiomesEnum Biome { get; set; }
        public List<Npc> NPCs { get; set; }
    }
}
