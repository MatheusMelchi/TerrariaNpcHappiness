using EnumsNET;
using TerrariaNpcHappiness.Logic.Enum;

namespace TerrariaNpcHappiness.Logic.Classes
{
    public class Npc
    {
        public NPCIdentificationEnum Id { get; set; }
        public string? Name { get { return this.Id.AsString(EnumFormat.Description); } }
        public decimal? BuyMultiplier { get; set; }
        public decimal? SellMultiplier { get; set; }
    }
}
