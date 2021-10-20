using System;

namespace database_of_customers
{
    class Program
    {
        static void Main(string[] args)
        {

            // Mockdata
            MongoCRUD db = new MongoCRUD("UserDatabase");
            PersonModel person = new PersonModel
            {
                FirstName = "John",
                LastName = "Andersson",
                SocialSecurityNumber = "9612291476",
                Email = "john.andersson@gmail.com",
                SwishNumber = "0762-282947",
                Address = new AddressModel
                {
                    StreetAdress = "Östra Storgatan 9A",
                    City = "Västerås",
                    ZipCode = 44936
                }
            };

            db.InsertRecord("Users", person);

            //var recs = db.LoadRecords<NameModel>("Users");

            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{ rec.FirstName } { rec.LastName }");
            //    Console.WriteLine();
            //}

            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{ rec.Id }: { rec.FirstName } { rec.LastName }");

            //    if (rec.Address != null)
            //    {
            //        Console.WriteLine(rec.Address.City);
            //    }
            //    Console.WriteLine();
            //}

            //var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("cba6960f-dc9c-4aad-923a-308c71aa51cf"));
            ////oneRec.DateOfBirth = new DateTime(1991, 12, 29, 0, 0, 0, DateTimeKind.Utc);
            ////db.UpsertRecord("Users", oneRec.Id, oneRec);
            //db.DeleteRecord<PersonModel>("Users", oneRec.Id);

            Console.ReadLine();
        }
    }
}
