using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidDb26_2025CS127.Utilities
{
    public enum ApplicationStatusLevel
    {
        Info,
        Success,
        Warning,
        Error
    }

    public class ApplicationStatusService
    {
        public static event EventHandler<ApplicationStatusEventArgs> StatusChanged;
        public static void PublishSuccess(string message)
        {
            Publish(message, ApplicationStatusLevel.Success);
        }

        public static void PublishInfo(string message)
        {
            Publish(message, ApplicationStatusLevel.Info);
        }

        private static void Publish(string message, ApplicationStatusLevel level)
        {
            StatusChanged?.Invoke(null, new ApplicationStatusEventArgs(message, level));
        }
    }

    public class ApplicationStatusEventArgs : EventArgs
    {
        public ApplicationStatusEventArgs(string message, ApplicationStatusLevel level)
        {
            Message = message;
            Level = level;
        }

        public string Message { get; private set; }
        public ApplicationStatusLevel Level { get; private set; }
    }
}
