using DinkToPdf;
using DinkToPdf.Contracts;


namespace RetoMaximo.Pdf
{
    public class PdfGenerator: IPdfGenerator
    {
        private readonly IConverter _converter;
        public PdfGenerator(IConverter converter)
        {
            _converter = converter;
        }

        public byte[] GenerarPdf(string html)
        {
            var configuracionesGlobales = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10, Bottom = 10 }
            };

            var configuracionesDeArchivo = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = html,
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Right = "Página [page] de [toPage]" }
            };

            var pdf = new HtmlToPdfDocument
            {
                GlobalSettings = configuracionesGlobales,
                Objects = { configuracionesDeArchivo }
            };

            byte[] pdfByte = _converter.Convert(pdf);
            return pdfByte;
        }
    }
}
