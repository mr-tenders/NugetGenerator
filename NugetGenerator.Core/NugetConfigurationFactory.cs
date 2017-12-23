using System.Collections.Generic;

namespace NugetGenerator.Core
{
    public class NugetConfigurationFactory : INugetConfigurationFactory
    {

        public NugetConfiguration Create(string packageName, string version, string author, IEnumerable<string> assemblies)
        {
            return new NugetConfiguration
            {
                Name = packageName,
                Version = version,
                Authors = author,
                Assemblies = assemblies
            };
        }
    }
}
