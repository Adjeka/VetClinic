using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalExaminations.Models.PermissionManagers
{
    [NotMapped]
    public abstract class PermissionManager
    {
        abstract public bool CanViewAnimalsRegistry { get; }
        abstract public bool CanViewOrganizationsRegistry { get; }
        abstract public bool CanViewContractsRegistry { get; }
        abstract public bool CanChangeAnimalsRegistry { get; }
        abstract public bool CanChangeOrganizationsRegistry { get; }
        abstract public bool CanChangeContractsRegistry { get; }
        abstract public Func<Animal, bool> AnimalsFilter { get; }
        abstract public Func<Organization, bool> OrganizationsFilter { get; }
        abstract public Func<Contract, bool> ContractsFilter { get; }
    }
}
