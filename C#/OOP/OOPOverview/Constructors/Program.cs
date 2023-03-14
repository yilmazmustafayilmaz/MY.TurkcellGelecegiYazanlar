using Constructors;

ReportGenerator reportGenerator1 = new ReportGenerator("C:\\data.txt");
Console.WriteLine(reportGenerator1.ReportFormat);

ReportGenerator reportGenerator2 = new ReportGenerator(readingPath: "C:\\data.txt");
Console.WriteLine(reportGenerator2.ReportFormat);

Ekmek ekmek = new Ekmek();