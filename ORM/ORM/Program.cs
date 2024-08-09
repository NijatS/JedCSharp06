using ORM.CodeFirst;

namespace ORM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HMSDbContext context = new();

            Patient patient = new Patient()
            {
                Id = 1,
                Age = 21,
                Name = "Nijat",
                Surname = "Soltanov"
            };

            //context.Patients.Add(patient);


            context.Patients.Remove(patient);
            context.SaveChanges();


        }
    }
}
