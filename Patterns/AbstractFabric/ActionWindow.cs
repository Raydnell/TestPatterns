using CsharpPatterns.Patterns.AbstractFabric;
using CsharpPatterns.Patterns.AbstractFabric.Dungeons;

namespace CsharpPatterns.Patterns
{
    public class ActionWindow
    {
        readonly AbstractLightDungeon _lightDung;
        readonly AbstractRegularDungeon _regularDung;
        readonly AbstractUltraHardDungeon _ultraHardDung;

        public ActionWindow(AbstractFabricDungeons fabric)
        {
            _lightDung = fabric.CreateLightDungeon();
            _regularDung = fabric.CreateRegularDungeon();
            _ultraHardDung = fabric.CreateUltraHardDungeon();
        }

        public void WhatFabricDungeonsCreated()
        {
            _lightDung.WhatIsDungeon();
            _regularDung.WhatIsDungeon();
            _ultraHardDung.WhatIsDungeon();
        }
    }
}
