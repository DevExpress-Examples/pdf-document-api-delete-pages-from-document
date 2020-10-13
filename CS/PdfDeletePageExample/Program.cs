
#region #Reference
using DevExpress.Pdf;
// ...
#endregion #Reference

namespace PdfDeletePageExample {
    #region #Code
    class Program {
        static void Main(string[] args) 
        {
            using (PdfDocumentProcessor pdfDocumentProcessor = new PdfDocumentProcessor()) 
            {
                pdfDocumentProcessor.LoadDocument("..\\..\\docs\\TextDelete.pdf");
                for (int i = pdfDocumentProcessor.Document.Pages.Count-1; i > 0; i--)
                    if (i % 2 != 0)
                    {
                        pdfDocumentProcessor.DeletePage(i);
                    }
                pdfDocumentProcessor.SaveDocument("..\\..\\docs\\Deleted.pdf");
            }
        }
    }
    #endregion #Code
}
