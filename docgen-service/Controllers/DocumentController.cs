using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace docgen_service.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DocumentController : Controller
    {
        public DocumentController(ILogger<DocumentController> logger)
        {

        }

        /// <summary>
        /// Получает информацию о всех клиентах в БД
        /// </summary>
        /// <remarks>
        /// 
        /// Пример запроса:
        /// 
        ///     GET /Clients
        /// 
        /// Пример ответа:
        ///     
        ///         {
        ///             clientId: 1,
        ///             clientInn: 988979344,
        ///             clientName: 'Рога и копыта',
        ///             clientsHolding: '12 Стульев'
        ///         },
        ///         {
        ///             clientId: 2,
        ///             clientInn: 8374985793487,
        ///             clientName: 'Напитки из Черноголовки',
        ///             clientsHolding: 'Вкусные напитки'
        ///         },
        ///         ...
        ///     
        /// </remarks>
        /// <returns>Информация по всем клиентам</returns>
        /// <response code="200">Найдена информация по клиентам</response>
        /// <response code="400">Клиенты не найдены</response>
        [HttpGet]
        [Produces("application/json")]
        public OkResult TestRequest()
        {            
            return Ok();
        }
    }
}
