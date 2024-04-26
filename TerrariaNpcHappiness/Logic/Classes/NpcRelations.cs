using TerrariaNpcHappiness.Logic.Enum;

namespace TerrariaNpcHappiness.Logic.Classes
{
    public static class NpcRelations
    {
        public static Dictionary<NPCIdentificationEnum, Relations> Relations = new Dictionary<NPCIdentificationEnum, Relations>()
        {
            {
                NPCIdentificationEnum.Guide, new Relations
                {
                    NPC = NPCIdentificationEnum.Guide,
                    LikedBiomes = [BiomesEnum.Forest],
                    DislikedBiomes = [BiomesEnum.Ocean],
                    LovedNpcs = [],
                    LikedNpcs = [NPCIdentificationEnum.Clothier, NPCIdentificationEnum.Zoologist],
                    DislikedNpcs = [NPCIdentificationEnum.Steampunker],
                    HatedNpcs = [NPCIdentificationEnum.Painter]
                }
            },
            {
                NPCIdentificationEnum.Merchant, new Relations
                {
                    NPC = NPCIdentificationEnum.Merchant,
                    LikedBiomes = [BiomesEnum.Forest],
                    DislikedBiomes = [BiomesEnum.Desert],
                    LovedNpcs = [],
                    LikedNpcs = [NPCIdentificationEnum.Golfer, NPCIdentificationEnum.Nurse],
                    DislikedNpcs = [NPCIdentificationEnum.TaxCollector],
                    HatedNpcs = [NPCIdentificationEnum.Angler]
                }
            },
            {
                NPCIdentificationEnum.Zoologist, new Relations
                {                    
                    NPC = NPCIdentificationEnum.Zoologist,
                    LikedBiomes = [BiomesEnum.Forest],
                    DislikedBiomes = [BiomesEnum.Desert],
                    LovedNpcs = [NPCIdentificationEnum.WitchDoctor],
                    LikedNpcs = [NPCIdentificationEnum.Golfer],
                    DislikedNpcs = [NPCIdentificationEnum.Angler],
                    HatedNpcs = [NPCIdentificationEnum.ArmsDealer]
                }
            },
            {
                NPCIdentificationEnum.Golfer, new Relations
                {                    
                    NPC = NPCIdentificationEnum.Golfer,
                    LikedBiomes = [BiomesEnum.Forest],
                    DislikedBiomes = [BiomesEnum.Underground],
                    LovedNpcs = [NPCIdentificationEnum.Angler],
                    LikedNpcs = [NPCIdentificationEnum.Zoologist, NPCIdentificationEnum.Painter],
                    DislikedNpcs = [NPCIdentificationEnum.Pirate],
                    HatedNpcs = [NPCIdentificationEnum.Merchant]
                }
            },
            {
                NPCIdentificationEnum.Nurse, new Relations
                {                    
                    NPC = NPCIdentificationEnum.Nurse,
                    LikedBiomes = [BiomesEnum.Hallow],
                    DislikedBiomes = [BiomesEnum.Snow],
                    LovedNpcs = [NPCIdentificationEnum.ArmsDealer],
                    LikedNpcs = [NPCIdentificationEnum.Wizard],
                    DislikedNpcs = [NPCIdentificationEnum.PartyGirl, NPCIdentificationEnum.Dryad],
                    HatedNpcs = [NPCIdentificationEnum.Zoologist]
                }
            },
            {
                NPCIdentificationEnum.Tavernkeep, new Relations
                {
                    NPC = NPCIdentificationEnum.Tavernkeep,
                    LikedBiomes = [BiomesEnum.Hallow],
                    DislikedBiomes = [BiomesEnum.Snow],
                    LovedNpcs = [NPCIdentificationEnum.Demolitionist],
                    LikedNpcs = [NPCIdentificationEnum.GoblinTinkerer],
                    DislikedNpcs = [NPCIdentificationEnum.Guide],
                    HatedNpcs = [NPCIdentificationEnum.DyeTrader]
                }
            },
        };

        public static Relations NpcRelationById(NPCIdentificationEnum npc)
        {
            return Relations.FirstOrDefault(x => x.Key == npc).Value;
        }
    }
}
