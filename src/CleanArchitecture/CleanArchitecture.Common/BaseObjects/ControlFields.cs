//////////////////////////////////////////////////////////////////////////////
/////////// PBW Web Architects, LLC
/////////// Project:
/////////// Ver:
//////////////////////////////////////////////////////////////////////////////
/////////// Architect/ Analyst: Cesar L Diaz
//////////////////////////////////////////////////////////////////////////////
using System;

namespace CleanArchitecture.Common
{
    public abstract class ControlFields : IAuditable
    {
        public bool IsActive { get; set; } = true;

        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public string DeActivatedBy { get; set; }
        public DateTime? DeActivatedOn { get; set; }

        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }

        public short? DisplayOrder { get; set; }
        public virtual string Description { get; set; } // is virtual for everriding if necessary
    }
}