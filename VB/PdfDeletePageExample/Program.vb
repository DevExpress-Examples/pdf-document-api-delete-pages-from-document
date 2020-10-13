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
				For i As Integer = pdfDocumentProcessor.Document.Pages.Count To 1 Step -1
					If i Mod 2 <> 0 Then
						pdfDocumentProcessor.DeletePage(i)
					End If
				Next i
				pdfDocumentProcessor.SaveDocument("..\..\docs\Deleted.pdf")
			End Using
		End Sub
	End Class
	#End Region ' #Code
End Namespace
