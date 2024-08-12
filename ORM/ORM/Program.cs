using ORM.CodeFirst;

namespace ORM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HMSDbContext context = new();

            //Patient patient = new Patient()
            //{
            //    Id = 2,
            //    Age = 21,
            //    Name = "Nijat",
            //    Surname = "Soltanov"
            //};
            //Console.WriteLine(context.Entry(patient).State);
            //context.Patients.Remove(patient);
            //Console.WriteLine(context.Entry(patient).State); 
            //context.SaveChanges();
            //Console.WriteLine(context.Entry(patient).State);


            //List<Patient> patients = new(){new()
            //{
            //        Age = 21,
            //        Name = "Nijat",
            //        Surname = "Soltanov"
            //},new()
            //{
            //    Age = 20,
            //    Name = "Azima",
            //    Surname = "Qadirli"
            //},new()
            //{
            //    Age = 22,
            //    Name = "Yusif",
            //    Surname = "Pirquliyev"
            //}};

            //context.Patients.AddRange(patients);
            //context.SaveChanges();



            //var patients =  context.Patients.ToList();

            //foreach (var patient in patients)
            //{
            //    Console.WriteLine(patient.Name);
            //}

            Patient? patient = context.Patients?.Where(x => x.Id == 4).FirstOrDefault();

            Console.WriteLine(context.Entry(patient).State); //Detached  Unchanged
            patient.Name = "Ezime";
            context.Update(patient);
            Console.WriteLine(context.Entry(patient).State); //Modified Modified
            context.SaveChanges();
            Console.WriteLine(context.Entry(patient).State); //Detached Unchanged


        }
    }
}
