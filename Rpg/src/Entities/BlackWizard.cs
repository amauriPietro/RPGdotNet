namespace Rpg.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Nome, int level, string heroType){
            this.Nome = Nome;
            this.level = level;
            this.heroType = heroType;
            this.maxHP = 385;
            this.currHP = 385;
            this.maxMP = 641;
            this.currMP = 641;
        }
        public override string Attack(){
            return this.Nome + " lançou Magia negra";
        }
        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Nome + " lançou Magia negra super efetiva com bonus de " + Bonus;
            }
            else{
                return this.Nome + " lançou uma magia negra com força fraca com bonus de " + Bonus;
            }
            
        }
    }
}