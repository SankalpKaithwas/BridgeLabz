namespace Composition
{
    class DBMigrator
    {
        private readonly Logger _logger;

        public DBMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("asjdhgasdjhasdh");
        }

    }
}
