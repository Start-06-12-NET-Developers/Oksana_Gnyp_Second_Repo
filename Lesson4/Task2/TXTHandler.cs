using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Txt document is opening");
        }

        public override void Create()
        {
            Console.WriteLine("Txt document is creating");
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
