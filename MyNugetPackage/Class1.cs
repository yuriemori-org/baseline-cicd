namespace MyNugetPackage;

public class Class1
{
    public string GetMessage()
    {
        return $"Hello from MyNugetPackage!This version is {GetVersion()}";
    }
    public string GetVersion()
    {
        return "1.0.0";
    }

}
