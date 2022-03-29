using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contracts;

namespace WebApplication1.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : Controller
    {
        private readonly ICompanyRepository _companyRepo;
        public CompaniesController(ICompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            try
            {
                var companies = await _companyRepo.GetCompanies();
                return Ok(companies);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }


        }
    }

}
