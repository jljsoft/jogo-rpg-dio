namespace jogo_rpg.src.Model
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) : base("", 0, "")
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}