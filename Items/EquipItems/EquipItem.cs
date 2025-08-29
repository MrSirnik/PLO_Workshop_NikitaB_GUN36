using GamePrototype.Items.EconomicItems;
using GamePrototype.Utils;

namespace GamePrototype.Items.EquipItems
{
    public abstract class EquipItem : Item
    {
        private uint _durability;
        private uint _maxDurability;
        public uint Durability { get => _durability; protected set => _durability = value; }
        public override bool Stackable => false;

        public abstract EquipSlot Slot { get; }

        protected EquipItem(uint maxDurability, string name) : base(name) => _maxDurability = maxDurability;

        public void ReduceDurability(uint delta) => _durability -= delta;//прочность--

        public void Repair(uint delta) => //ремонт++
            _durability += _durability + delta > _maxDurability 
            ? _maxDurability 
            : _durability + delta;
    }
}
