using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lizzie.Core.Interfaces
{
    public interface IAgent : IKnownPerson
    {
        Mood AgentMood { get; }
    }
}
