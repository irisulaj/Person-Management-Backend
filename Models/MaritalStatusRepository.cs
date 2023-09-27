namespace PersonManagement.Models
{
    public class MaritalStatusRepository : IMaritalStatusRepository
    {
        private readonly PersonManagementContext _personManagementContext;

        public MaritalStatusRepository(PersonManagementContext personManagementContext)
        {
            _personManagementContext = personManagementContext;
        }

        public IEnumerable<Pm02MaritalStatus> maritalStatuses

        {
            get
            {
                return _personManagementContext.Pm02MaritalStatuses.Where(m => m.IsActive == true);
            }
        }

        public Pm02MaritalStatus? GetMaritalStatusById(int? Id)
        {
            return _personManagementContext.Pm02MaritalStatuses.FirstOrDefault(i => i.IdMaritalStatus == Id);
        }
    }
}
