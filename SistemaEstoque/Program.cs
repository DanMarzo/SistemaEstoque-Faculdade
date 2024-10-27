namespace SistemaEstoque;

public static class Program
{
    [STAThread]
    static void Main()
    {
        var servicesCollection = new ServiceCollection();
        servicesCollection.AddAppServices();

        var serviceProvider = servicesCollection.BuildServiceProvider();

        ApplicationConfiguration.Initialize();
        Application.Run(new HomePage());
    }
}