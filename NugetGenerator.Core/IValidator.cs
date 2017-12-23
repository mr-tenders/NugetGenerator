using System;
using System.Collections.Generic;
using System.Text;

namespace NugetGenerator.Core
{
    public interface IValidator<T>
    {
        string Instance { get; set; }
        IEnumerable<Exception> Validate();
        IEnumerable<Exception> Validate(string expected);
        bool IsValid();
        bool IsValid(string expected);
    }
}
