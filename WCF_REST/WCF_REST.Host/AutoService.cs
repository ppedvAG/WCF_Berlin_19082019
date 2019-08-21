using Bogus;
using System.Collections.Generic;
using System.Linq;

namespace WCF_REST.Host
{
    class AutoService : IAutoService
    {
        static List<Auto> db = new List<Auto>();


        static AutoService()
        {
            var faker = new Faker<Auto>()
                            .RuleFor(x => x.Hersteller, a => a.Vehicle.Manufacturer())
                            .RuleFor(x => x.Modell, a => a.Vehicle.Model())
                            .RuleFor(x => x.Kraftstoff, a => a.Vehicle.Fuel())
                            .RuleFor(x => x.AnzahlLenkräder, a => a.Random.Number(1, 8));

            foreach (var item in faker.Generate(10))
            {
                item.Id = db.Count + 1;
                db.Add(item);
            }
        }

        public void AddAuto(Auto auto)
        {
            auto.Id = db.Max(x => x.Id) + 1;
            db.Add(auto);
        }

        public void DeleteAuto(int id)
        {
            db.Remove(db.ToList().FirstOrDefault(x => x.Id == id));
        }

        public IEnumerable<Auto> GetAllAutos()
        {
            return db;
        }

        public IEnumerable<Auto> GetAutoMitAnzahlLenkräder(string zahl)
        {
            return db.Where(x => x.AnzahlLenkräder >= int.Parse(zahl));
        }

        public void UpdateAuto(Auto auto)
        {
            int oldId = auto.Id;
            DeleteAuto(auto.Id);
            AddAuto(auto);
            auto.Id = oldId;
        }
    }



}
