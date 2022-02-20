namespace Rpg.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Nome, int level, string heroType){
            this.Nome = Nome;
            this.level = level;
            this.heroType = heroType;
            this.maxHP = 574;
            this.currHP = 574;
            this.maxMP = 89;
            this.currMP = 89;
        }
        public override string Attack(){
            return this.Nome + " lançou um shuriken";
        }
        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Nome + " lançou uma shuriken com dano crítico de " + Bonus;
            }
            else{
                return this.Nome + " lançou uma shuriken sem força com dano de " + Bonus;
            }
            
        }
    }
}