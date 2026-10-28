namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbmigrator = new DBMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbmigrator.Migrate();
            installer.Install();


        }
    }
}
