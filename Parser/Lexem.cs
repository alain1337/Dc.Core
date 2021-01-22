using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class Lexem
    {
        public string Text { get; }
        public object Value { get; }
        public Type ValueType { get; }
        public int Kind { get; }

        public Lexem (string text, Type valueType, int kind)
        {
            Text = text;
            Value = Convert.ChangeType (text, valueType);
            ValueType = valueType;
            Kind = kind;
        }

        public override string ToString ()
        {
            return Value.ToString ();
        }
    }
}