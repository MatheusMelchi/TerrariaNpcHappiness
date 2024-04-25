using TerrariaNpcHappiness.Logic.Enum;

namespace TerrariaNpcHappiness.Logic.Classes
{
    public class HappinessCalculator
    {
        private const double BaseHappiness = 1;

        public Dictionary<NPCIdentificationEnum, double[]> CalculateHappiness(Village village)
        {
            Dictionary<NPCIdentificationEnum, double[]> npcHappiness = new();
            int villageNpcAmount = village.NPCs.Count;

            foreach (var Npc in village.NPCs)
            {
                double buyMultiplier = BaseHappiness;
                double sellMultiplier = BaseHappiness;

                //
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

                if(village.NPCs.FirstOrDefault(x => x.Id == NPCIdentificationEnum.Princess) != null)
                {
                    buyMultiplier -= 0.06;
                    sellMultiplier += 0.06;
                }

                switch (Npc.Id)
                {
                    case NPCIdentificationEnum.Guide:
                        if (village.Biome == BiomesEnum.Forest)
                        {
                            buyMultiplier -= 0.06;
                            sellMultiplier += 0.06;
                        }
                        else if(village.Biome == BiomesEnum.Ocean)
                        {
                            buyMultiplier += 0.06;
                            sellMultiplier -= 0.06;
                        }

                        foreach(var villageNpc in village.NPCs.Where(x => x.Id != Npc.Id))
                        {
                            if(villageNpc.Id == NPCIdentificationEnum.Princess)
                            {

                            }
                            
                            if(villageNpc.Id == NPCIdentificationEnum.Clothier || villageNpc.Id == NPCIdentificationEnum.Zoologist)
                            {

                            }

                        }

                        break;

                    default:
                        break;
                }

                npcHappiness.Add(Npc.Id, [buyMultiplier, sellMultiplier]);
            }

            return npcHappiness;
        }
    }
}
