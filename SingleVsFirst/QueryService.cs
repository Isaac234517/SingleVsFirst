using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace SingleVsFirst
{
    public class QueryService
    {
        private IEnumerable<Guest> _guests { get; }

        public QueryService(int numberOfSamples)
        {
            Randomizer.Seed = new Random(100);
            var guestFaker = new Faker<Guest>()
                .RuleFor(g => g.Id, faker => faker.IndexFaker)
                .RuleFor(g => g.Name, faker => faker.Person.FullName)
                .RuleFor(g => g.Phone, faker => faker.Person.Phone)
                .RuleFor(g => g.Age, faker => faker.Random.Number(0,100))
                .RuleFor(g => g.Gender, faker => faker.PickRandom<Gender>());
            _guests = guestFaker.Generate(numberOfSamples);
        }

        public Guest? SingleOrDefaultByID(int id) => _guests.SingleOrDefault(g=> g.Id == id);

        public Guest? FirstOrDefaultByID(int id) => _guests.FirstOrDefault(g => g.Id == id);

    }
}
