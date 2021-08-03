namespace Core.Entities
{
    public class Owner : Entitybase
    {
        public string fullName { get; set; }

        public string Profil { get; set; }

        public string Avatar { get; set; }

        public Adress adress { get; set; }
    }
}
