using System.Drawing;
using Autofac;
using ChangeDetector;
using Domain;
using InputProvider;
using Presenter;

namespace SendAPicOnChange
{
    internal class DependencyConfiguration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // components
            builder.RegisterInstance(new Configuration());
            builder.RegisterType<MainWindow>();
            builder.RegisterType<BitmapProcessor>().As<IProcessor<Bitmap>>();

            // input
            builder.RegisterType<VideoCaptureDeviceInputProvider>().As<IInputProvider<Bitmap>>().InstancePerLifetimeScope();
            
            // change
            builder.RegisterType<BitmapComparer>().As<IControllableComparer<Bitmap>>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(ChangeDetector<>)).As(typeof(IChangeDetector<>)).InstancePerLifetimeScope();

            // presenters
            builder.RegisterType<ScpUploader>().As<IPresenter<Bitmap>>().InstancePerLifetimeScope();
            builder.RegisterType<BitmapDisplayer>().As<IPresenter<Bitmap>>().As<IControlContentProvider>().InstancePerLifetimeScope();
            builder.RegisterType<TimestampPresenter>().As<IPresenter<Bitmap>>().As<IControlContentProvider>().InstancePerLifetimeScope();
        }
    }
}
