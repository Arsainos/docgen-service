using docgen_service.Configurations.AppSettings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace docgen_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase
    {
        private readonly IOptions<Logging> _logging;
        private readonly IOptions<DataBase> _database;
        private readonly ILogger<OptionsController> _logger;

        public OptionsController(ILogger<OptionsController> logger, IOptions<Logging> logging, IOptions<DataBase> database)
        {
            _logger = logger;
            _logging = logging;
            _database = database;
        }


    }
}
