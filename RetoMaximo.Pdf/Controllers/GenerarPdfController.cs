using Microsoft.AspNetCore.Mvc;
using RetoMaximo.Pdf.Model;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetoMaximo.Pdf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerarPdfController : ControllerBase
    {
        
        public GenerarPdfController()
        {
            
        }
        // POST api/<GenerarPdfController>
        [HttpPost("ConvertirHtml")]
        public string ConvertirHtml([FromBody] Request request)
        {
            if (string.IsNullOrEmpty(request?.Html))
            {
                throw new Exception("No hay un archivo html valido");
            }
            return "Convertir pdf";
        }
    }
}
