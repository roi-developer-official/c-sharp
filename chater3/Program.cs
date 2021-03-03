using System;
namespace chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            //inheritence
            var text = new Text(2);
            text.Width = 100;
            text.Copy();

            //any inheriting can translated to composition
            //because using inheritence can be with high hierachies and fregile
            //composition
            var dbMigrator = new DbMigrator(new Logger());
            dbMigrator.Migrate();

        }



        //Composition
        public class Logger
        { 
            public void Log(string message)
            {
                Console.WriteLine(message);
            }
        }

        public class DbMigrator
        {
            private readonly Logger _logger;

            public DbMigrator(Logger logger)
            {
                _logger = logger;
            }

            public void Migrate()
            {
                _logger.Log("We are migrating");
            }
        }

        

    }
}
