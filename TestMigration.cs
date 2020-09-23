using System;
using System.Data.SqlClient;
using FluentMigrator;

namespace FluentMigratorWithExternalDlls
{
    [Migration(0)]
    public class TestMigration : Migration
    {
        public override void Up()
        {
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            connection.Close();
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}
