namespace RetoMaximo.Pdf
{
    public interface IPdfGenerator
    {
        byte[] GenerarPdf(string html);
    }
}
