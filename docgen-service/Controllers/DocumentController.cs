using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace docgen_service.Controllers
{
    [Route("[controller]")]
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
        [Route("GetDocumentsType")]
        [HttpGet]
        [Produces("application/json")]
        public OkResult GetDocumentsType()
        {
            return Ok();
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
        [Route("GetTemplatesTypes")]
        [HttpGet]
        [Produces("application/json")]
        public OkResult GetTemplatesTypes()
        {
            return Ok();
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
        [Route("Template/{id}")]
        [HttpGet]
        [Produces("application/json")]
        public OkResult GetTemplateById()
        {
            return Ok();
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
        [Route("Template/{id}")]
        [HttpDelete]
        [Produces("application/json")]
        public OkResult DeleteTemplateById()
        {
            return Ok();
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
        [Route("Template/{id}")]
        [HttpPut]
        [Produces("application/json")]
        public OkResult UpdateTemplateById()
        {
            return Ok();
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
        [Route("Template")]
        [HttpPost]
        [Produces("application/json")]
        public OkResult SaveNewTemplate()
        {
            return Ok();
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
        [Route("CreateDocument")]
        [HttpPost]
        [Produces("application/json")]
        public OkResult CreateDocument()
        {
            return Ok();
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
        [Route("GetSignsPositions")]
        [HttpPost]
        [Produces("application/json")]
        public OkResult GetSignsPositions()
        {
            return Ok();
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
        [Route("ConvertToPDF")]
        [HttpPost]
        [Produces("application/json")]
        public OkResult ConvertToPDF()
        {
            return Ok();
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
        [Route("ConvertToPDFAndGetSignsPositions")]
        [HttpPost]
        [Produces("application/json")]
        public OkResult ConvertToPDFAndGetSignsPositions()
        {
            return Ok();
        }
        
    }
}
