using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.Extensions.Logging;
using ODataRoutingSample.DBAccess;
using ODataRoutingSample.DBAccess.Entities;

namespace ODataRoutingSample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private DBContext dbContext;

        private readonly ILogger<AccountsController> _logger;

        public AccountsController(DBContext dbContext, ILogger<AccountsController> logger)
        {
            this.dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet]
        [EnableQuery]
        public IQueryable<Amount> Get()
        {
            return dbContext.TransactionAmounts;
            //return accounts.AsQueryable<Account>();           
        }
    }
}
