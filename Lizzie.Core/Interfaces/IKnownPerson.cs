using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lizzie.Core.Interfaces
{
    public interface IKnownPerson
    {
        string Title { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        Gender Gender { get; set; }
        DateTime Birthday { get; set; }
    }
}
