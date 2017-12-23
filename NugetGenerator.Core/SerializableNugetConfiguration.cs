using System;
using System.Collections.Generic;
using System.Text;

namespace NugetGenerator.Core
{
    public class SerializableNugetConfiguration
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Authors { get; set; }

        public SerializableNugetConfiguration(NugetConfiguration nuget)
        {

        }
    }
}
