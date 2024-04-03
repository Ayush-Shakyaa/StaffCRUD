namespace StaffCRUD.Service
{
    public interface IStaffService
    {
        Task<Staff> AddStaff(Staff staff);
        Task<IEnumerable<Staff>> GetAllStaff();
        Task<Staff> UpdateStaff(Staff staff);
        Task DeleteStaff(string id);

        Task<IEnumerable<Staff>> GetStaffById(string id);

    }
}
