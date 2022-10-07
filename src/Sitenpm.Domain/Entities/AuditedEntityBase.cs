using System;
using admin.Domain.Entities.Interfaces;

namespace admin.Domain.Entities;

public abstract class AuditedEntityBase : IAuditedEntityBase
{
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string LastModifiedBy { get; set; }
    public DateTime LastModifiedDate { get; set; }
}
