using Colony.Core.Domain;
using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Colony.Core.Services
{
    public interface INameGenerator
    {
        string GenerateFirstName(Sex sex);
        string GenerateLastName();
    }
}
