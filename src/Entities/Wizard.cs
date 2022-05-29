namespace DungeonRpg.src.Entities
{
    public class Wizard : Hero
    {
            public Wizard(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP){

            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Bola de fogo";
        } 
                public virtual string MageAttack(int Bonus)
                {
                    if (Bonus > 6){      
                    return this.Name + " Lançou magia super efetiva com bonus de " + Bonus; 
                    } else {
                        return this.Name + " Lançou uma magia fraca com bonus de " + Bonus;
                                }
                    }    
    }

}
