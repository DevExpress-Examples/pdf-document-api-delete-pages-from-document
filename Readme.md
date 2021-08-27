<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595468/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T114310)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/PdfDeletePageExample/Program.cs) (VB: [Program.vb](./VB/PdfDeletePageExample/Program.vb))
<!-- default file list end -->
# How to delete pages from PDF


<p>This example illustrates how to use <a href="https://documentation.devexpress.com/#DocumentServer/CustomDocument16491">PDF Document Processor</a>  for deleting pages from PDF.<br><br>In this example, the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_DeletePagetopic">PdfDocumentProcessor.DeletePage </a> method is called 55 times to delete each odd numbered page in the <strong>TextDelete</strong> document (contains 109 pages) starting from the last odd numbered page. <br><br>The result is saved to the <strong>Deleted</strong> document, which contains only even pages, by calling the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_SaveDocumenttopic">PdfDocumentProcessor.SaveDocument</a> method.<br><br>The Universal Subscription or an additional Document Server Subscription is required to use this example in production code. Please refer to the <a href="https://www.devexpress.com/Subscriptions/">DevExpress Subscription</a> page for pricing information.</p>

<br/>


