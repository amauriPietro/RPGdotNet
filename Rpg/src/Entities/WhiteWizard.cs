namespace Rpg.src.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Nome, int level, string heroType){
            this.Nome = Nome;
            this.level = level;
            this.heroType = heroType;
            this.maxHP = 601;
            this.currHP = 601;
            this.maxMP = 482;
            this.currMP = 482;
        }
        public override string Attack(){
            return this.Nome + " lançou Magia";
        }
        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Nome + " lançou Magia super efetiva com bonus de " + Bonus;
            }
            else{
                return this.Nome + " lançou uma magia com força fraca com bonus de " + Bonus;
            }
            
        }
    }
}