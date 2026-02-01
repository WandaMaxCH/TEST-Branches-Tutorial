using System.Diagnostics;
using System.Reflection;

namespace test_program_tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void T01_CheckFileExists()
    {
        //Arrange
        String exePath = "C:/src/TEST-Branches-Tutorial/test-program/bin/Debug/net9.0/test-program.exe";
        int delay = 5000;
        String outputPath = "C:/temp/Georg.txt";

        //Act
        System.Diagnostics.Process.Start(exePath);
        Thread.Sleep(delay);

        //Assert
        if (!System.IO.File.Exists(outputPath))
        {
            throw new Exception("Output File not found");
        }

        

    }
}
