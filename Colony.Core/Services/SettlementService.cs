using Ardalis.Result;
using Colony.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Colony.Core.Services
{
    public class SettlementService
    {
        private readonly IAttributeGenerator _attributeGenerator;
        private readonly INameGenerator _nameGenerator;
        private readonly Random _random;

        public SettlementService(INameGenerator nameGenerator, IAttributeGenerator attributeGenerator)
        {
            this._nameGenerator = nameGenerator;
            this._attributeGenerator = attributeGenerator;
            this._random = new Random();
        }

        public Result<Settlement> EstablishSettlment(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return Result.Error("Name is required");
            }

            var settlement = new Settlement { Name = name };
            for (var i = 0; i < 10; i++)
            {
                var sex = _attributeGenerator.GenerateRandomSex();
                var person = new Person { FirstName = this._nameGenerator.GenerateFirstName(sex), LastName = _nameGenerator.GenerateLastName(), Age = (byte)_random.Next(18, 40), Sex = sex };

                settlement.Population.Add(person);
            }

            return settlement;
        }
    }
}