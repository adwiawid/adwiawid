using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DzdlyaZhdanova
{
    class Logger
    {
        public void LoggerStart()
        {
            // объект конфигурации с вызовом метода BuildConfig, описанного выше
            var builder = new ConfigurationBuilder();
            IConfiguration configuration = BuildConfig(builder);
            //инициализируется логер с помощью выбранного объекта конфигурации
            Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .CreateLogger();
            //подписка на необработанные исключения
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        ///< summary >
        /// Подключает файл конфигурации из каталога с приложением и возвращает конфигурацию.
        /// </ summary >
        static IConfiguration BuildConfig(IConfigurationBuilder builder)
        {
            return
            builder.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appconfig.json", optional: false, reloadOnChange: true)
            .Build();
        }

        /// <summary>
        /// Обработчик, Записывает необработанное исключение
        /// </summary>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception unhandledException = (Exception)e.ExceptionObject;
            Log.Error(unhandledException, "Необработанное исключение");
        }
    }
}
