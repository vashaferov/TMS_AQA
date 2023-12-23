using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Message
    {
        public string Text { get; }

        public Message(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return $"{nameof(Text)}: {Text}";
        }
    }
}
