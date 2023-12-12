using CsharpPatterns.Patterns.AbstractFabric.Dungeons;
using CsharpPatterns.Patterns.AbstractFabric.Dungeons.UnderwaterDungeons;

namespace CsharpPatterns.Patterns.AbstractFabric
{
    public class UnderwaterDungeonsFabric : AbstractFabricDungeons
    {
        public override AbstractLightDungeon CreateLightDungeon()
        {
            return new LightUnderwaterDungeon();
        }

        public override AbstractRegularDungeon CreateRegularDungeon()
        {
            return new RegularUnderwaterDungeon();
        }

        public override AbstractUltraHardDungeon CreateUltraHardDungeon()
        {
            return new UltraHardUnderwaterDungeon();
        }
    }
}
