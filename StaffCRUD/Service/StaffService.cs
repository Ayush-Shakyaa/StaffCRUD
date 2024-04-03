using Microsoft.EntityFrameworkCore;

namespace StaffCRUD.Service
{
    public class StaffService : IStaffService
    {
        private readonly ApplicationDBContext _dbContext;

        public StaffService(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Staff> AddStaff(Staff staff)
        {
            var result = await _dbContext.Staffs.AddAsync(staff);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteStaff(string id)
        {
            var staff = await _dbContext.Staffs.FindAsync(id);
            if (staff != null)
            {
                _dbContext.Staffs.Remove(staff);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Staff>> GetAllStaff()
        {
            return await _dbContext.Staffs.ToListAsync();
        }
        public async Task<IEnumerable<Staff>> GetStaffById(string id)
        {
            Guid staffId;
            if (!Guid.TryParse(id, out staffId))
            {
                
                return null;
            }

            return await _dbContext.Staffs.Where(s => s.Id == staffId).ToListAsync();
        }
        public async Task<Staff> UpdateStaff(Staff staff)
        {
            _dbContext.Entry(staff).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return staff;
        }
    }
}
