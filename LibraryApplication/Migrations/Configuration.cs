using LibraryApplication.DbModel.Context;
using System.Data.Entity.Migrations;

namespace LibraryApplication.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DataBaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataBaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
