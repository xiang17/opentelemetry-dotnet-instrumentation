using System;
using System.Runtime.CompilerServices;

namespace OpenTelemetry.AutoInstrumentation.ClrProfiler.Managed.Logging
{
    internal interface ILogger
    {
        bool IsEnabled(LogEventLevel level);

        void Debug(string messageTemplate, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Debug<T>(string messageTemplate, T property, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Debug<T0, T1>(string messageTemplate, T0 property0, T1 property1, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Debug<T0, T1, T2>(string messageTemplate, T0 property0, T1 property1, T2 property2, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Debug(string messageTemplate, object[] args, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Debug(Exception exception, string messageTemplate, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Debug<T>(Exception exception, string messageTemplate, T property, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Debug<T0, T1>(Exception exception, string messageTemplate, T0 property0, T1 property1, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Debug<T0, T1, T2>(Exception exception, string messageTemplate, T0 property0, T1 property1, T2 property2, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Debug(Exception exception, string messageTemplate, object[] args, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Information(string messageTemplate, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Information<T>(string messageTemplate, T property, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Information<T0, T1>(string messageTemplate, T0 property0, T1 property1, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Information<T0, T1, T2>(string messageTemplate, T0 property0, T1 property1, T2 property2, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Information(string messageTemplate, object[] args, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Information(Exception exception, string messageTemplate, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Information<T>(Exception exception, string messageTemplate, T property, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Information<T0, T1>(Exception exception, string messageTemplate, T0 property0, T1 property1, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Information<T0, T1, T2>(Exception exception, string messageTemplate, T0 property0, T1 property1, T2 property2, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Information(Exception exception, string messageTemplate, object[] args, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Warning(string messageTemplate, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Warning<T>(string messageTemplate, T property, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Warning<T0, T1>(string messageTemplate, T0 property0, T1 property1, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Warning<T0, T1, T2>(string messageTemplate, T0 property0, T1 property1, T2 property2, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Warning(string messageTemplate, object[] args, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Warning(Exception exception, string messageTemplate, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Warning<T>(Exception exception, string messageTemplate, T property, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Warning<T0, T1>(Exception exception, string messageTemplate, T0 property0, T1 property1, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Warning<T0, T1, T2>(Exception exception, string messageTemplate, T0 property0, T1 property1, T2 property2, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Warning(Exception exception, string messageTemplate, object[] args, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Error(string messageTemplate, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Error<T>(string messageTemplate, T property, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Error<T0, T1>(string messageTemplate, T0 property0, T1 property1, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Error<T0, T1, T2>(string messageTemplate, T0 property0, T1 property1, T2 property2, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Error(string messageTemplate, object[] args, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Error(Exception exception, string messageTemplate, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Error<T>(Exception exception, string messageTemplate, T property, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Error<T0, T1>(Exception exception, string messageTemplate, T0 property0, T1 property1, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Error<T0, T1, T2>(Exception exception, string messageTemplate, T0 property0, T1 property1, T2 property2, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");

        void Error(Exception exception, string messageTemplate, object[] args, [CallerLineNumber] int sourceLine = 0, [CallerFilePath] string sourceFile = "");
    }
}
