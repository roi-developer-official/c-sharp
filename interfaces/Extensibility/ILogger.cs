namespace interfaces
{
    partial class Program
    {
        public interface ILogger
        {
            void LogError(string message);
            void LogInfo(string message);
        }
    }
}
