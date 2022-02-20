using docgen_service.Configurations.AppSettings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace docgen_service.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase
    {
        private readonly IOptions<Logging> _logging;
        private readonly IOptions<DataBase> _database;
        private readonly ILogger<OptionsController> _logger;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="logging"></param>
        /// <param name="database"></param>
        public OptionsController(ILogger<OptionsController> logger, IOptions<Logging> logging, IOptions<DataBase> database)
        {
            _logger = logger;
            _logging = logging;
            _database = database;
        }

        /// <summary>
        /// Получение информации о конфигурации логирования
        /// </summary>
        /// <remarks>
        /// 
        /// Пример запроса:
        /// 
        ///     GET /LoggingInfo
        /// 
        /// Пример ответа:
        /// 
        ///     "Logging": {
        ///         "LogLevel": {
        ///             "Default": "Information",
        ///             "Microsoft.AspNetCore": "Warning"
        ///         }
        ///     }   
        ///     
        /// </remarks>
        /// <returns>Информация о конфигурации логирования</returns>
        /// <response code="200">ИНформация о конфигурации логирования</response>
        /// <response code="400">Ошибка получения информации</response>
        [Route("LoggingInfo")]
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Logging), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Logging), (int)StatusCodes.Status200OK)]
        public ActionResult<Logging> LoggingInfo()
        {
            var LoggingInfo = new Logging() { LogLevel = _logging.Value.LogLevel };

            return Ok(LoggingInfo);
        }

        /// <summary>
        /// Получение информации о конфигурации базы данных
        /// </summary>
        /// <remarks>
        /// 
        /// Пример запроса:
        /// 
        ///     GET /DataBaseInfo
        /// 
        /// Пример ответа:
        /// 
        ///     "DataBase": {
        ///         "Host": "localhost",
        ///         "Port": "1111",
        ///         "Database": "test",
        ///         "Username": "test@test"
        ///     }   
        ///     
        /// </remarks>
        /// <returns>Информация о конфигурации базы данных</returns>
        /// <response code="200">ИНформация о конфигурации базы данных</response>
        /// <response code="400">Ошибка получения информации</response>
        [Route("DataBaseInfo")]
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(DataBase), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(DataBase), (int)StatusCodes.Status200OK)]
        public ActionResult<DataBase> DataBaseInfo()
        {
            var DataBase = new DataBase()
            {
                Host = _database.Value.Host,
                Port = _database.Value.Port,
                Database = _database.Value.Database,
                Username = _database.Value.Username,
                Password = "secret key"
            };

            return Ok(DataBase);
        }
    }
}
