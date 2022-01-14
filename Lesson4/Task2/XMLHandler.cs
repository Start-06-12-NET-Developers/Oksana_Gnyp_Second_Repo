using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Xml document is opening");
        }

        public override void Create()
        {
            Console.WriteLine("Xml document is creating");
        }

        public override void Change()
        {
            Console.WriteLine("Txt document is edited");
        }

        public override void Save()
        {
            Console.WriteLine("Txt document is saving");
        }
    }
}
