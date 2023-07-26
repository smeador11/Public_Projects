using System;
using SQLite;
using WhatsForDinner.Constants;
using WhatsForDinner.JsonModels;

namespace WhatsForDinner.Entities
{
    public class DatabaseAccess
    {
        static SQLiteAsyncConnection Database;

        public static readonly AsyncLazy<DatabaseAccess> Instance = new AsyncLazy<DatabaseAccess>(async () =>
        {
            var instance = new DatabaseAccess();
            CreateTableResult result = await Database.CreateTableAsync<RecipeByIngredientJsonModel>();
            return instance;
        });

        public DatabaseAccess()
        {
            Database = new SQLiteAsyncConnection(SqliteConstants.DatabasePath, SqliteConstants.Flags);
        }
    }
}

