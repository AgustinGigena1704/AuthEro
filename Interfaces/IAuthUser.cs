using System;
using System.Collections.Generic;
using System.Text;

namespace AuthEro.Interfaces
{
    public interface IAuthUser
    {
        string Id { get; set; }
        string Email { get; set; }
        string PasswordHash { get; set; }
        string? DisplayName { get; set; }
        DateTime? LastLogin { get; set; }

        // Auditoría
        DateTime CreatedAt { get; set; }
        string? CreatedBy { get; set; }

        DateTime? ModifiedAt { get; set; }
        string? ModifiedBy { get; set; }

        // Borrado lógico
        bool IsDeleted { get; set; }
        DateTime? DeletedAt { get; set; }
        string? DeletedBy { get; set; }
    }
}
