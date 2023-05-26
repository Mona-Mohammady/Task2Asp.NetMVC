namespace Task1Asp.NetMVC.Models
{
    public class SampleData
    {

        private static List<Guestes> guests;
        static SampleData()
        {
            guests = new List<Guestes>
            {
                new Guestes(){Name = "Mona",Email="mona@gmail.com",Attend=true , Phone="0123456789"},
          
            };
        }

        public static List<Guestes> getGuests()
        {
            return guests;
        }

      

        public static void AddGuest(Guestes guest)
        {
           guests.Add(guest);
        }
    }
}
