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
        private readonly IPdfGenerator _pdfGenerator;
        public GenerarPdfController(IPdfGenerator pdfGenerator)
        {
            _pdfGenerator = pdfGenerator;
        }
        // POST api/<GenerarPdfController>
        [HttpPost("GenerarPdf")]
        public byte[] GenerarPdf([FromBody] Request request)
        {
            if (string.IsNullOrEmpty(request?.Html))
            {
                throw new Exception("No hay un archivo html valido");
            }
            return _pdfGenerator.GenerarPdf(request?.Html);
        }
    }
}
