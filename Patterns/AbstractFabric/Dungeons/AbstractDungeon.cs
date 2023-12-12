namespace CsharpPatterns.Patterns.AbstractFabric.Dungeons
{
    public abstract class AbstractDungeon
    {
        public void WhatIsDungeon()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
