using System.Collections.Generic;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Logger.Appender;
using Logger.Config;
using Logger.Helper;
using Component = Castle.MicroKernel.Registration.Component;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = InstallContainer();
            var logger = container.Resolve<ILoggerFactory>().Resolve();

            logger.LogFatal("This is my first fatal");
            logger.LogError("This is my first error");
            logger.LogWarn("This is my first warn");
            logger.LogInfo("This is my first info");
            logger.LogDebug("This is my first debug");
            logger.LogTrace("This is my first trace");
        }


        private static WindsorContainer InstallContainer()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<IJsonConverter>().ImplementedBy<JsonConverter>()
                    .DependsOn(Dependency.OnValue("filePath", "LoggerConfig.json")));
            container.Register(Component.For<IAppenderFactory>().ImplementedBy<AppenderFactory>());
            container.Register(Component.For<ILoggerFactory>().ImplementedBy<LoggerFactory>());
            return container;
        }
    }
}
