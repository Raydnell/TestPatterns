using CsharpPatterns.Patterns.AbstractFabric.Dungeons;
using CsharpPatterns.Patterns.AbstractFabric.Dungeons.DarkDungeons;

namespace CsharpPatterns.Patterns.AbstractFabric
{
    public class DarkDungeonsFabric : AbstractFabricDungeons
    {
        public override AbstractLightDungeon CreateLightDungeon()
        {
            return new LightDarkDungeon();
        }

        public override AbstractRegularDungeon CreateRegularDungeon()
        {
            return new RegularDarkDungeon();
        }

        public override AbstractUltraHardDungeon CreateUltraHardDungeon()
        {
            return new UltraHardDarkDungeon();
        }
    }
}
