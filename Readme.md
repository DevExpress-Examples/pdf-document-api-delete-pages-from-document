<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595468/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T114310)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# PDF Document API - Delete Pages from a Document

This example illustrates how to use [PDF Document API](https://docs.devexpress.com/OfficeFileAPI/16491/pdf-document-api) to delete pages from PDF files.

In this example, the [PdfDocumentProcessor.DeletePage](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.DeletePage(System.Int32)) method is called 55 times to delete each odd-numbered page in the <strong>TextDelete</strong> document (contains 109 pages) starting from the last odd-numbered page. 

The result is saved to the <strong>Deleted</strong> document, which contains only even pages, by the [PdfDocumentProcessor.SaveDocument](https://docs.devexpress.com/OfficeFileAPI/devexpress.pdf.pdfdocumentprocessor.savedocument.overloads) method call.

>[!NOTE]
> The Universal Subscription or an additional Document Server Subscription is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information.

# Files to Review

* [Program.cs](./CS/PdfDeletePageExample/Program.cs) (VB: [Program.vb](./VB/PdfDeletePageExample/Program.vb))

 # Documentation

 [Organize Pages in PDF Documents](https://docs.devexpress.com/OfficeFileAPI/119762/pdf-document-api/document-manipulation/page-manipulation)
