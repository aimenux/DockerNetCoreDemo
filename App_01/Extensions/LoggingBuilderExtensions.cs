﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace App_01.Extensions;

public static class LoggingBuilderExtensions
{
    public static void AddConsoleLogger(this ILoggingBuilder loggingBuilder)
    {
        if (!File.Exists(PathExtensions.GetSettingFilePath()))
        {
            loggingBuilder.AddSimpleConsole(options =>
            {
                options.SingleLine = true;
                options.IncludeScopes = true;
                options.UseUtcTimestamp = true;
                options.TimestampFormat = "[HH:mm:ss:fff] ";
                options.ColorBehavior = LoggerColorBehavior.Enabled;
            });
        }
    }

    public static void AddNonGenericLogger(this ILoggingBuilder loggingBuilder)
    {
        var categoryName = typeof(Program).Namespace;
        var services = loggingBuilder.Services;
        services.AddSingleton(serviceProvider =>
        {
            var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();
            return loggerFactory.CreateLogger(categoryName!);
        });
    }
}