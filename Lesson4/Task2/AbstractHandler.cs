using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public abstract class AbstractHandler
    {
        public void DocumentRedactor()
        {
            Create();
            Open();
            Change();
            Save();
        }

        public abstract void Open();

        public abstract void Create();

        public abstract void Change();

        public abstract void Save();
    }
}
