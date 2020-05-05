using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ManipulatingResources.Api.Contexts;
using ManipulatingResources.Api.Entities.Data;
using ManipulatingResources.Api.DTOS;
using AutoMapper;

namespace ManipulatingResources.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsPayablesController : ControllerBase
    {
        public AccountsPayablesController(AppDbContext context, Mapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        private readonly AppDbContext _context;
        private readonly Mapper _mapper;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountPayableDto>>> Get()
        {
            var accounts = await _context.AccountPayables.ToListAsync();

            if (!accounts.Any()) return NotFound();

            var accountsDtos = _mapper.Map<List<AccountPayableDto>>(accounts);

            return accountsDtos;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var idAccount = await _context.AccountPayables
                .Select(x => x.IdAccountPayable).FirstOrDefaultAsync(x => x == id);

            if (idAccount == null) return BadRequest();

            _context.AccountPayables.Remove(new AccountPayable { IdAccountPayable = idAccount });
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
