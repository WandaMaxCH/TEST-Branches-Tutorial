// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

if (!System.IO.Directory.Exists("C:/temp"))
{
    System.IO.Directory.CreateDirectory("C:/temp");
}

System.IO.File.WriteAllText("C:/temp/Georg.txt", DateTime.Now.ToString());