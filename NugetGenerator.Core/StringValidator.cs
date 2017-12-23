using System;
using System.Linq;
using System.Collections.Generic;

namespace NugetGenerator.Core
{
    public class StringValidator : IStringValidator
    {
        private string _instance;
        public string Instance
        {
            get => _instance;
            set { _instance = value; }
        }

        public bool IsValid()
        {
            return !Validate().Any();
        }

        public bool IsValid(string expected)
        {
            return !Validate(expected).Any();
        }

        public IEnumerable<Exception> Validate(string expected)
        {
            var exceptions = new List<Exception>();
            if (Instance != expected)
            {
                exceptions.Add(new ArgumentException($"Expected value \"{expected}\" does not match \"{Instance}\""));
            }

            return exceptions;
        }

        public IEnumerable<Exception> Validate()
        {
            var result = new List<Exception>();
            if (string.IsNullOrEmpty(Instance))
            {
                result.Add(new ArgumentNullException("String is null or empty"));
            }

            return result;
        }
    }
}
