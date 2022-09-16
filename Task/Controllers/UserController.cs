using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task.Data.Context;
using Task.Data.Repositories.UserRepository;
using Task.DTOs.User;

namespace Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MainContext _context;
        private readonly IMapper _mapper;

        public UserController(MainContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult GetAllUsers()
        {
            var dbList = _context.Users.Include(p => p.Certifications).Where(p => p.CirtficatNum > 5).ToList();
            var UserReadDTO = _mapper.Map<List<UserReadDTO>>(dbList);
            return Ok(UserReadDTO);
        }
    }
}
