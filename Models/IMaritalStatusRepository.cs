namespace PersonManagement.Models
{
    public interface IMaritalStatusRepository
    {
        IEnumerable<Pm02MaritalStatus> maritalStatuses { get; }
        Pm02MaritalStatus? GetMaritalStatusById(int? Id);
    }
}
