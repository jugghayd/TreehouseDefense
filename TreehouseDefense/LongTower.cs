namespace TreehouseDefense
{
    class LongTower : Tower
    {
        protected override int Range { get; } = 2;

        public LongTower(MapLocation location) : base(location)
        {
           
        }
    }
}