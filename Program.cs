using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

using (PdfDocument one = PdfReader.Open(@"C:\Users\pca167\Downloads\docsAgenda Package - Council Meeting-Hamilton_20Mar_2019.pdf7618.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument two = PdfReader.Open(@"C:\Users\pca167\Downloads\Agenda Package - Council Meeting-Hamilton_16Aug_2018.pdf3507.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument three = PdfReader.Open(@"C:\Users\pca167\Downloads\docsAgenda Package - Council Meeting-Hamilton_20Mar_2019.pdf7618.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument four = PdfReader.Open(@"C:\Users\pca167\Downloads\Agenda Package - Council Meeting-Hamilton_16Aug_2018.pdf3507.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument five = PdfReader.Open(@"C:\Users\pca167\Downloads\docsAgenda Package - Council Meeting-Hamilton_20Mar_2019.pdf7618.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument six = PdfReader.Open(@"C:\Users\pca167\Downloads\Agenda Package - Council Meeting-Hamilton_16Aug_2018.pdf3507.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument seven = PdfReader.Open(@"C:\Users\pca167\Downloads\Agenda Package - Council Meeting-Hamilton_16Aug_2018.pdf3507.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument eight = PdfReader.Open(@"C:\Users\pca167\Downloads\docsAgenda Package - Council Meeting-Hamilton_20Mar_2019.pdf7618.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument nine = PdfReader.Open(@"C:\Users\pca167\Downloads\Agenda Package - Council Meeting-Hamilton_16Aug_2018.pdf3507.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument ten = PdfReader.Open(@"C:\Users\pca167\Downloads\Agenda Package - Council Meeting-Hamilton_16Aug_2018.pdf3507.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument eleven = PdfReader.Open(@"C:\Users\pca167\Downloads\Agenda Package - Council Meeting-Hamilton_16Aug_2018.pdf3507.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument twelve = PdfReader.Open(@"C:\Users\pca167\Downloads\docsAgenda Package - Council Meeting-Hamilton_20Mar_2019.pdf7618.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument thirteen = PdfReader.Open(@"C:\Users\pca167\Downloads\docsAgenda Package - Council Meeting-Hamilton_20Mar_2019.pdf7618.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument onefour = PdfReader.Open(@"C:\Users\pca167\Downloads\docsAgenda Package - Council Meeting-Hamilton_20Mar_2019.pdf7618.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument onefive = PdfReader.Open(@"C:\Users\pca167\Downloads\docsAgenda Package - Council Meeting-Hamilton_20Mar_2019.pdf7618.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument onesix = PdfReader.Open(@"C:\Users\pca167\Downloads\docsAgenda Package - Council Meeting-Hamilton_20Mar_2019.pdf7618.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument oneseven = PdfReader.Open(@"C:\Users\pca167\Downloads\docsAgenda Package - Council Meeting-Hamilton_20Mar_2019.pdf7618.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument oneeight = PdfReader.Open(@"C:\Users\pca167\Downloads\docsAgenda Package - Council Meeting-Hamilton_20Mar_2019.pdf7618.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument onenine = PdfReader.Open(@"C:\Users\pca167\Downloads\docsAgenda Package - Council Meeting-Hamilton_20Mar_2019.pdf7618.pdf", PdfDocumentOpenMode.Import))
using (PdfDocument twenty = PdfReader.Open(@"C:\Users\pca167\Downloads\docsAgenda Package - Council Meeting-Hamilton_20Mar_2019.pdf7618.pdf", PdfDocumentOpenMode.Import))

using (PdfDocument outPdf = new PdfDocument())
{                
    CopyPages(one, outPdf);
    CopyPages(two, outPdf);
    CopyPages(three, outPdf);
    CopyPages(four, outPdf);
    CopyPages(five, outPdf);
    CopyPages(six, outPdf);
    CopyPages(seven, outPdf);
    CopyPages(eight, outPdf);
    CopyPages(nine, outPdf);
    CopyPages(ten, outPdf);
    CopyPages(eleven, outPdf);
    CopyPages(twelve, outPdf);
    CopyPages(thirteen, outPdf);
    CopyPages(onefour, outPdf);
    CopyPages(onefive, outPdf);
    CopyPages(onesix, outPdf);
    CopyPages(oneseven, outPdf);
    CopyPages(oneeight, outPdf);
    CopyPages(onenine, outPdf);

    CopyPages(twenty, outPdf);


    outPdf.Save("bigFile1and2.pdf");
}

void CopyPages(PdfDocument from, PdfDocument to)
{
    for (int i = 0; i < from.PageCount; i++)
    {
        to.AddPage(from.Pages[i]);
    }
}