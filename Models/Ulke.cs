namespace Ajax.Models
{
    public class Ulke
    {
        public int Id { get; set; }
        public string Adi { get; set; }

        public static List<Ulke> Listele()
        {
            var list = new List<Ulke>();
            list.Add(new Ulke
            {
                Id = 1,
                Adi = "Türkiye"
            });

            list.Add(new Ulke
            {
                Id = 2,
                Adi = "Almanya"
            });

            list.Add(new Ulke
            {
                Id = 3,
                Adi = "İngiltere"
            });

            return list;
        }
    }
}
