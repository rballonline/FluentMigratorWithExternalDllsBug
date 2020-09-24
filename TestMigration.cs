using System;
using System.Data;
using System.Data.Common;
using FluentMigrator;

namespace FluentMigratorWithExternalDlls
{
    [Migration(0)]
    public class TestMigration : Migration
    {
        private int id = 0;

        public override void Up()
        {
            Execute.WithConnection(SqlCommands);
            Execute.Sql($"select {id}");
        }

        private void SqlCommands(IDbConnection connection, IDbTransaction transaction)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "select 1";
            command.Transaction = transaction;
            id = (int)command.ExecuteScalar();
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}
