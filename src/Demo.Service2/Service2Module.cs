using Autofac;
using Demo.Common;

namespace Demo.Service2
{
    public class Service2Module : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Service2>().As<IService>();
        }
    }
}