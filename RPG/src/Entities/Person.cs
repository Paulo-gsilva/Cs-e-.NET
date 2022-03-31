namespace dotnet__poo.src.Entities
{
    public class Person
    {

        public Person(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){ //override - sobrescrever
        //sobrescreve metodo ToString que já existe no sistema
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack(){ //virtual permite a sobrescrição por parte do filho
            return this.Name + " " + "Atacou com sua espada";
        }
    }
}