using System.Collections.Generic;

namespace NugetGenerator.Core
{
    public interface INugetConfigurationFactory
    {
        NugetConfiguration Create(string packageName, string version, string author, IEnumerable<string> assemblies);
    }
}
