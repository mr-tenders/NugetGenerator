using System;
using System.Collections.Generic;

namespace NugetGenerator.Core
{
    [Serializable]
    public class NugetConfiguration
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Authors { get; set; }
        public IEnumerable<string> Assemblies { get; set; }
    }
}
