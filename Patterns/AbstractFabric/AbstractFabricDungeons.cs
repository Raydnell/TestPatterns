using CsharpPatterns.Patterns.AbstractFabric.Dungeons;

namespace CsharpPatterns.Patterns.AbstractFabric
{
    public abstract class AbstractFabricDungeons
    {
        public abstract AbstractLightDungeon CreateLightDungeon();
        public abstract AbstractRegularDungeon CreateRegularDungeon();
        public abstract AbstractUltraHardDungeon CreateUltraHardDungeon();
    }
}