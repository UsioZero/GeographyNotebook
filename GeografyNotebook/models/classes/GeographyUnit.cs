using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografyNotebook.models.classes
{
    public abstract class GeographyUnit
    {
        public Guid Uuid {  protected set; get; }

        public String Name { protected set; get; }

        public int Population { protected set; get; }

        public abstract void edit();
    }
}
