namespace Rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Nome, int level, string heroType){
            this.Nome = Nome;
            this.level = level;
            this.heroType = heroType;
            this.maxHP = 749;
            this.currHP = 749;
            this.maxMP = 72;
            this.currMP = 72;
        }
        public override string Attack(){
            return this.Nome + " atacou com sua espada";
        }
        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Nome + " acertou um ponto crítico, causando dano bonus de " + Bonus;
            }
            else{
                return this.Nome + " acertou o inimigo, causando dano bonus de " + Bonus;
            }
        }
    }
}