using System;

namespace interfaces
{
    partial class Program
    {
        public class DbMigrator
        {
            private readonly ILogger _logger;

            public DbMigrator(ILogger logger)
            {
                _logger = logger;
            }

            public void Migrate()
            {
                _logger.LogInfo("Migration startet at:" + DateTime.Now);
                _logger.LogInfo("Migration finished at:" + DateTime.Now);
            }
        }
    }
}
