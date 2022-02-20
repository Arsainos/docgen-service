using docgen_service.Configurations.AppSettings;
using docgen_service.Database;
using docgen_service.Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace docgen_service.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class DocumentController : Controller
    {
        private readonly DataContext _dataContext;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public DocumentController(ILogger<DocumentController> logger, DataContext context)
        {
            _dataContext = context;
        }

        /// <summary>
        /// Получение информации о всех доступных типах документов для генерации
        /// </summary>
        /// <remarks>
        /// 
        /// Пример запроса:
        /// 
        ///     GET /GetDocumentsType
        /// 
        /// Пример ответа:
        /// 
        ///     {
        ///         [
        ///             {
        ///                 DocumentType: "Профсуждение"
        ///             },
        ///             {
        ///                 DocumentType: "Материальная отвественность"
        ///             }
        ///         ]
        ///     }    
        /// </remarks>
        /// <returns>Информация по всем клиентам</returns>
        /// <response code="200">Информация по типам документов</response>
        /// <response code="400">Ошибка поиска информации по типам документов</response>
        [Route("GetDocumentsType")]
        [HttpGet]
        [Produces("application/json")]
        public IActionResult GetDocumentsType()
        {            
            return Ok();
        }

        /// <summary>
        /// Получение информации о сохраненных шаблонах
        /// </summary>
        /// <remarks>
        /// 
        /// Пример запроса:
        /// 
        ///     GET /GetTemplatesInfo
        /// 
        /// Пример ответа:
        /// 
        ///     {
        ///         [
        ///             {
        ///                 id: 1,
        ///                 DocumentType: "Профсуждение",
        ///                 TemplateName: "Профсуждение.docx",
        ///                 version: 1
        ///             },
        ///             {   
        ///                 id: 2,
        ///                 DocumentType: "Профсуждение",
        ///                 TemplateName: "Профсуждение.docx",
        ///                 version: 2
        ///             },
        ///             {
        ///                 id: 3,
        ///                 DocumentType: "Материальная отвественность",
        ///                 TemplateName: "Материальная ответсвенность.docx",
        ///                 version: 1
        ///             }
        ///         ]
        ///     }    
        /// </remarks>
        /// <returns>Информация о доступных шаблонах</returns>
        /// <response code="200">Информация о шаблонах найдена</response>
        /// <response code="400">Ошибка поиска информации о шаблонах</response>
        [Route("GetTemplatesInfo")]
        [HttpGet]
        [Produces("application/json")]
        public IActionResult GetTemplatesInfo()
        {
            return Ok();
        }

        /// <summary>
        /// Получение конкртеного шаблона
        /// </summary>
        /// <remarks>
        /// 
        /// Пример запроса:
        /// 
        ///     GET /Template/{id}
        ///    
        /// </remarks>
        /// <returns>Скачивание файла конкретного шаблона</returns>
        /// <response code="200">Шаблон найден</response>
        /// <response code="400">Ошибка поиска шаблона</response>
        [Route("Template/{id}")]
        [HttpGet]
        [Produces("application/msword")]
        public IActionResult GetTemplateById()
        {
            return Ok();
        }

        /// <summary>
        /// Удаление конкретного шаблона
        /// </summary>
        /// <remarks>
        /// 
        /// Пример запроса:
        /// 
        ///     DELETE /Template/{id}
        ///  
        /// </remarks>
        /// <returns>Шаблон удалён</returns>
        /// <response code="200">Шаблон успешно удален</response>
        /// <response code="400">Ошибка удаления шаблона</response>
        [Route("Template/{id}")]
        [HttpDelete]
        [Produces("application/json")]
        public IActionResult DeleteTemplateById()
        {
            return Ok();
        }

        /// <summary>
        /// Обновление шаблона конкретной версии.
        /// </summary>
        /// <remarks>
        /// 
        /// Пример запроса:
        /// 
        ///     PUT /Template/{id}-{version}
        /// 
        /// </remarks>
        /// <returns>Шаблон обновлен</returns>
        /// <response code="200">Обновлен шаблон</response>
        /// <response code="400">Ошибка обновления шаблона</response>
        [Route("Template/{id}-{version}")]
        [HttpPut]
        [Produces("application/json")]
        public IActionResult UpdateTemplateById(IFormFile template)
        {
            return Ok();
        }

        /// <summary>
        /// Создание нового шаблона или инкриментальное добавление новой версии
        /// </summary>
        /// <remarks>
        /// 
        /// Пример запроса:
        /// 
        ///     POST /NewTemplate
        ///     
        ///     {
        ///         DocumentType: "Профсуждение"
        ///     }
        /// 
        /// Пример ответа:
        ///     
        ///     {
        ///         id: 15,
        ///         DocumentType: "Профсуждение",
        ///         TemplateName: "Профсуждение.docx",
        ///         version: 3
        ///     }
        ///     
        /// </remarks>
        /// <returns>Шаблон создан</returns>
        /// <response code="200">Успешное создание шаблона</response>
        /// <response code="400">Ошибка создания шаблона</response>
        [Route("NewTemplate")]
        [HttpPost]
        [Produces("application/json")]
        public IActionResult NewTemplate(IFormFile template)
        {
            return Ok();
        }

        /// <summary>
        /// Генерация документа
        /// </summary>
        /// <remarks>
        /// 
        /// Пример запроса:
        /// 
        ///     POST /GenerateDocument
        ///     
        ///     {
        ///         DocumentType: "Профсуждение",
        ///         version: 1,
        ///         data: {
        ///             field1: "Иванов",
        ///             field2: "Иван",
        ///             field3: "Иванович",
        ///             filed4: "Санкт-Петербург"
        ///         }
        ///     }
        /// 
        /// </remarks>
        /// <returns>Сгенерированный документ по шаблону</returns>
        /// <response code="200">Генерация прошла успешно</response>
        /// <response code="400">Ошибка генерации</response>
        [Route("GenerateDocument")]
        [HttpPost]
        [Produces("application/msword")]
        public IActionResult GenerateDocument()
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
        ///     POST /ConvertToPDF
        /// 
        /// </remarks>
        /// <returns>Конвертированный документ в формате PDF</returns>
        /// <response code="200">Успешная конвертация документа</response>
        /// <response code="400">Ошибка конвертации</response>
        [Route("ConvertToPDF")]
        [HttpPost]
        [Produces("application/pdf")]
        public IActionResult ConvertToPDF(IFormFile document)
        {
            return Ok();
        }

        /// <summary>
        /// Получение координат подписей
        /// </summary>
        /// <remarks>
        /// 
        /// Пример запроса:
        /// 
        ///     POST /GetSignsPositions
        ///     
        ///     {
        ///         SeacrhData: [
        ///             {
        ///                 value: "Иванов Иван Иванович"
        ///             },
        ///             {
        ///                 value: "Герасимов Герман Герасимович"
        ///             }
        ///         ]
        ///     }
        /// 
        /// Пример ответа:
        /// 
        ///     {
        ///         [
        ///             {
        ///                 SearchedValue: "Иванов Иван Иванович",
        ///                 Page: 1,
        ///                 SignZone: {
        ///                     x: 200,
        ///                     x1: 320,
        ///                     y: 1000,
        ///                     y2: 1016
        ///                 }
        ///             },
        ///             {
        ///                 SearchedValue : "Герасимов Герман Герасимович",
        ///                 Page: 1,
        ///                 SignZone: {
        ///                     x: 200,
        ///                     x1: 320,
        ///                     y: 1200,
        ///                     y1: 1216
        ///                 }
        ///             }
        ///         ]
        ///     }
        ///       
        /// </remarks>
        /// <returns>Массивы подписей в документе в виде координат</returns>
        /// <response code="200">Координаты найдены</response>
        /// <response code="400">Ошибка поиска координаты</response>
        [Route("GetSignsPositions")]
        [HttpPost]
        [Produces("application/json")]
        public IActionResult GetSignsPositions(IFormFile document)
        {
            return Ok();
        }

        /// <summary>
        /// Конвертация документов и получение координат подписей
        /// </summary>
        /// <remarks>
        /// 
        /// Пример запроса:
        /// 
        ///     POST /ConvertToPDFAndGetSignsPositions
        ///     
        ///     {
        ///         SeacrhData: [
        ///             {
        ///                 value: "Иванов Иван Иванович"
        ///             },
        ///             {
        ///                 value: "Герасимов Герман Герасимович"
        ///             }
        ///         ]
        ///     }
        /// 
        /// Пример ответа:
        /// 
        ///     {
        ///         [
        ///             {
        ///                 SearchedValue: "Иванов Иван Иванович",
        ///                 Page: 1,
        ///                 SignZone: {
        ///                     x: 200,
        ///                     x1: 320,
        ///                     y: 1000,
        ///                     y2: 1016
        ///                 }
        ///             },
        ///             {
        ///                 SearchedValue : "Герасимов Герман Герасимович",
        ///                 Page: 1,
        ///                 SignZone: {
        ///                     x: 200,
        ///                     x1: 320,
        ///                     y: 1200,
        ///                     y1: 1216
        ///                 }
        ///             }
        ///         ]
        ///     }
        ///     
        /// </remarks>
        /// <returns>Массивы подписей в документе в виде координат</returns>
        /// <response code="200">Успешная конвертация</response>
        /// <response code="400">Ошибка конвертации</response>
        [Route("ConvertToPDFAndGetSignsPositions")]
        [HttpPost]
        [Produces("application/json")]
        public IActionResult ConvertToPDFAndGetSignsPositions(IFormFile document)
        {
            return Ok();
        }
        
    }
}
