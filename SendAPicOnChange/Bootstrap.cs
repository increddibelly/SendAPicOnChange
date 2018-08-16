using System;
using Autofac;

namespace SendAPicOnChange
{
    internal static class Bootstrap
    {
        internal static IContainer Execute(Action<ContainerBuilder> additionalRegistrations = null)
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<DependencyConfiguration>();
            additionalRegistrations?.Invoke(builder);

            return builder.Build();
        }
    }
}
