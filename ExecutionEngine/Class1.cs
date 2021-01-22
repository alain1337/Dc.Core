using System;
using System.Linq;
using System.Threading.Tasks;

namespace Parser
{
    public interface IEngine
    {
        void Execute(Lexem lexem);
    }
}