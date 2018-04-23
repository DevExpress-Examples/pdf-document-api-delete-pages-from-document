#Region "#Reference"
Imports DevExpress.Pdf
' ...
#End Region ' #Reference

Namespace PdfDeletePageExample
    #Region "#Code"
    Friend Class Program
        Shared Sub Main(ByVal args() As String)
            Using pdfDocumentProcessor As New PdfDocumentProcessor()
                pdfDocumentProcessor.LoadDocument("..\..\docs\TextDelete.pdf")
                For i As Integer = pdfDocumentProcessor.Document.Pages.Count \ 2 To 0 Step -1
                    pdfDocumentProcessor.DeletePage(i * 2 + 1)
                Next i
                pdfDocumentProcessor.SaveDocument("..\..\docs\Deleted.pdf")
            End Using
        End Sub
    End Class
    #End Region ' #Code
End Namespace