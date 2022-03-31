namespace RPG.src.Entities
{
    public class Wizard : Person //ocorre a heraça
    {

        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " " + "Atacou com sua magia";
        }
    }
}