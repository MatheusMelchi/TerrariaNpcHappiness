using TerrariaNpcHappiness.Logic.Enum;

namespace TerrariaNpcHappiness.Logic.Classes
{
    public class HappinessCalculator
    {
        private const double BaseHappiness = 1;

        public static List<Npc> CalculateHappiness(Village village)
        {
            if (!village.NPCs.Any())
                return new List<Npc>();

            List<Npc> npcHappiness = new();
            int villageNpcAmount = village.NPCs.Count;

            foreach (var Npc in village.NPCs)
            {
                Relations relations = NpcRelations.NpcRelationById(Npc.Id);

                double buyMultiplier = BaseHappiness;
                double sellMultiplier = BaseHappiness;

                if ((villageNpcAmount - 1) <= 2)
                {
                    buyMultiplier -= 0.05;
                    sellMultiplier += 0.05;
                }
                else if ((villageNpcAmount - 1) >= 4)
                {
                    buyMultiplier += 0.05;
                    sellMultiplier -= 0.05;
                }

                if(village.NPCs.Where(x => x.Id == NPCIdentificationEnum.Princess).Any())
                {
                    buyMultiplier -= 0.06; 
                    sellMultiplier += 0.06;
                }

                if (relations.LikedBiomes.Contains(village.Biome))
                {
                    buyMultiplier -= 0.12;
                    sellMultiplier += 0.14;
                }
                else if (relations.DislikedBiomes.Contains(village.Biome))
                {
                    buyMultiplier += 0.06;
                    sellMultiplier -= 0.06;
                }

                foreach(var villageNpc in village.NPCs.Where(x => x != Npc))
                {
                    if (relations.LovedNpcs.Contains(villageNpc.Id))
                    {
                        buyMultiplier -= 0.12;
                        sellMultiplier += 0.14;
                    }
                    else if (relations.LikedNpcs.Contains(villageNpc.Id))
                    {
                        buyMultiplier -= 0.6;
                        sellMultiplier += 0.6;
                    }
                    else if (relations.HatedNpcs.Contains(villageNpc.Id))
                    {
                        buyMultiplier += 0.12;
                        sellMultiplier -= 0.11;
                    }
                    else if (relations.DislikedNpcs.Contains(villageNpc.Id))
                    {
                        buyMultiplier += 0.6;
                        sellMultiplier -= 0.6;
                    }
                }

                if (buyMultiplier < 0.67)
                    buyMultiplier = 0.67;
                else if (buyMultiplier > 1.5)
                    buyMultiplier = 1.5;

                if (sellMultiplier < 0.67)
                    sellMultiplier = 0.67;
                else if (sellMultiplier > 1.5)
                    sellMultiplier = 1.5;

                npcHappiness.Add(new Npc { Id = Npc.Id, BuyMultiplier = buyMultiplier, SellMultiplier = sellMultiplier });
            }

            return npcHappiness;
        }
    }
}
