using Domain.Enums;
using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class TeacherParentLink : Entity<Guid>
{
    public Guid TeacherProfileId { get; set; } // Öğretmen profil ID
    public Guid ParentProfileId { get; set; } // Veli profil ID
    public LinkRoleType LinkRole { get; set; } // Bağlantı rolü
    public DateTime? EffectiveFrom { get; set; } // Başlangıç tarihi
    public DateTime? EffectiveTo { get; set; } // Bitiş tarihi
    public bool IsPrimary { get; set; } // Birincil bağlantı mı
    public string? Notes { get; set; } // Notlar
    public Guid? TenantId { get; set; } // Kiracı ID
}
