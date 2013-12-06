using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funfun_
{
    [Serializable]
    public class Messages
    {
        string _name;
        string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
