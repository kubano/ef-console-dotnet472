using System;

namespace CleanArchitecture.Common
{
    public interface IAuditable
    {
        bool IsActive { get; set; }
        string CreatedBy { get; set; }
        DateTime? CreatedOn { get; set; }
        string UpdatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
        string DeActivatedBy { get; set; }
        DateTime? DeActivatedOn { get; set; }

        string DeletedBy { get; set; }
        DateTime? DeletedOn { get; set; }

        short? DisplayOrder { get; set; }
        string Description { get; set; }
    }
}