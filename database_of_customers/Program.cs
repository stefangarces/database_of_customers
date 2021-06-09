﻿using System;

namespace database_of_customers
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("Adress");
            PersonModel person = new PersonModel
            {
                FirstName = "Stefan",
                LastName = "Garcés",
                Address = new AddressModel
                {
                    StreetAdress = "Skårdalsvägen 11B",
                    City = "Göteborg",
                    ZipCode = 44536
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