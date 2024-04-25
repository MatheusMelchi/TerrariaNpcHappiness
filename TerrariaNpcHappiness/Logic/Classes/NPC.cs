using System;
using TerrariaNpcHappiness.Logic.Enum;
using EnumsNET;

namespace TerrariaNpcHappiness.Logic.Classes
{
    public class NPC
    {
        public NPC(NPCIdentificationEnum id)
        {
            Id = id;
            Name = id.AsString(EnumFormat.Description);
        }

        public NPCIdentificationEnum Id { get; set; }
        public string Name { get; set; }
    }
}
