namespace Ajax.Models
{
    public class Sehir
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public int UlkeId { get; set; }

        public static List<Sehir> Listele(int ulkeId)
        {
            var liste = new List<Sehir>();
            if(ulkeId == 1)
            {
                liste.Add(new Sehir
                {
                    Id = 1,
                    UlkeId = 1,
                    Adi = "Ankara"
                });

                liste.Add(new Sehir
                {
                    Id = 2,
                    UlkeId = 1,
                    Adi = "İstanbul"
                });

                liste.Add(new Sehir
                {
                    Id = 3,
                    UlkeId = 1,
                    Adi = "İzmir"
                });
            }
            else if (ulkeId == 2)
            {
                liste.Add(new Sehir
                {
                    Id = 1,
                    UlkeId = 2,
                    Adi = "Berlin"
                });

                liste.Add(new Sehir
                {
                    Id = 2,
                    UlkeId = 2,
                    Adi = "Frankfurt"
                });

                liste.Add(new Sehir
                {
                    Id = 3,
                    UlkeId = 2,
                    Adi = "Munih"
                });
            }
            else if (ulkeId == 3)
            {
                liste.Add(new Sehir
                {
                    Id = 1,
                    UlkeId = 3,
                    Adi = "Londra"
                });

                liste.Add(new Sehir
                {
                    Id = 2,
                    UlkeId = 3,
                    Adi = "Galler"
                });
            }

            return liste;
        }
    }
}
