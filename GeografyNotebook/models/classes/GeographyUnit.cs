using System;

namespace GeografyNotebook.models.classes
{
    public abstract class GeographyUnit
    {
        public Guid Uuid {  protected set; get; }

        public String Name { protected set; get; }

        public int Population { protected set; get; }
    }
}
