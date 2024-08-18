// DInjector.cs
using Autofac;
using Negocio.Parametros;
using Negocio.Parametros.Interfaces;

public static class DInjector
{
    private static IContainer _container;

    static DInjector()
    {
        ConfigureContainer();
    }

    private static void ConfigureContainer()
    {
        var builder = new ContainerBuilder();

        // Registrar tipos e implementações
        builder.RegisterType<ParametrosBiz>().As<IParametrosBiz>();

        // Construir o container
        _container = builder.Build();
    }

    public static T Resolve<T>()
    {
        if (_container == null)
        {
            ConfigureContainer();
        }
        return _container.Resolve<T>();
    }
}
