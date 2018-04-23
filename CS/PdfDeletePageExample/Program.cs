
#region #Reference
using DevExpress.Pdf;
// ...
#endregion #Reference

namespace PdfDeletePageExample {
    #region #Code
    class Program {
        static void Main(string[] args) {
            using (PdfDocumentProcessor pdfDocumentProcessor = new PdfDocumentProcessor()) {
                pdfDocumentProcessor.LoadDocument("..\\..\\docs\\TextDelete.pdf");
                for (int i = pdfDocumentProcessor.Document.Pages.Count / 2; i >= 0; i--)
                    pdfDocumentProcessor.DeletePage(i * 2 + 1);
                pdfDocumentProcessor.SaveDocument("..\\..\\docs\\Deleted.pdf");
            }
        }
    }
    #endregion #Code
}