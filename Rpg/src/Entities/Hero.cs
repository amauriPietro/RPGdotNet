namespace Rpg.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Nome, int level, string heroType){
            this.Nome = Nome;
            this.level = level;
            this.heroType = heroType;
        }
        public Hero(){

        }
        public string? Nome;
        public string? heroType;
        public int level;
        public int maxHP;
        public int maxMP;
        public int currHP;
        public int currMP;

        public override string ToString(){
            return this.Nome + " " + this.level + " " + this.heroType;
        }

        public virtual string Attack(){
            return this.Nome + " golpeou com seus punhos";
        }
    }
}