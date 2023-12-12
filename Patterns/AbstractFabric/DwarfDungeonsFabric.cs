using CsharpPatterns.Patterns.AbstractFabric.Dungeons;
using CsharpPatterns.Patterns.AbstractFabric.Dungeons.DwarfDungeons;

namespace CsharpPatterns.Patterns.AbstractFabric
{
    public class DwarfDungeonsFabric : AbstractFabricDungeons
    {
        public override AbstractLightDungeon CreateLightDungeon()
        {
            return new LightDwarfDungeon();
        }

        public override AbstractRegularDungeon CreateRegularDungeon()
        {
            return new RegularDwarfDungeon();
        }

        public override AbstractUltraHardDungeon CreateUltraHardDungeon()
        {
            return new UltraHardDwarfDungeon();
        }
    }
}
