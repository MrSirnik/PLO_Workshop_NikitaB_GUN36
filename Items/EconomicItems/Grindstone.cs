namespace GamePrototype.Items.EconomicItems
{
    public sealed class Grindstone : EconomicItem
    {
        //public uint UseGrindstone => 4;
        public override bool Stackable => false;

        public Grindstone(string name) : base(name)
        {

        }    
    }
}
