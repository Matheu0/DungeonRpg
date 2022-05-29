namespace DungeonRpg.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        protected Hero(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public string Name;
        public int Level;
        public string HeroType;
        public int HP;
        public int MP;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;

        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a Master Sword";
        } 
    }
}