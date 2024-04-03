using StaffCRUD.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace StaffCRUD.Controllers
{
    public class StaffController:Controller
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }
        [HttpPost, Route("AddStaff")]
        public async Task<IActionResult> AddStaff(Staff staff)
        {
            var addStaff = await _staffService.AddStaff(staff);
            return Ok(addStaff);
        }

        [HttpDelete, Route("DeleteStaff/{id}")]
        public async Task<IActionResult> DeleteStaff(string id)
        {
            await _staffService.DeleteStaff(id);
            return Ok();
        }


        [HttpGet, Route("GetAllStaffs")]
        public async Task<IActionResult> GetAllStaffs()
        {
            var staffs = await _staffService.GetAllStaff();
            return Ok(staffs);
        }

        [HttpGet, Route("GetStaffById/{id}")]
        public async Task<IActionResult> GetStaffById(string id)
        {
            var staff = await _staffService.GetStaffById(id);
            return Ok(staff);
        }

        [HttpPut, Route("UpdateStaff")]
        public async Task<IActionResult> UpdateStaff(Staff staff)
        {
            var updatedStaff = await _staffService.UpdateStaff(staff);
            return Ok(updatedStaff);
        }



        public IActionResult Index()
        {
            return View();
        }



    }
}
