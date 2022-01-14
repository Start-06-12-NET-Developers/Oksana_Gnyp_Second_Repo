using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class DocHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Doc document is opening");
        }

        public override void Create()
        {
            Console.WriteLine("Doc document is creating");
        }

        public override void Change()
        {
            Console.WriteLine("Doc document is edited");
        }

        public override void Save()
        {
            Console.WriteLine("Doc document is saving");
        }
    }
}
