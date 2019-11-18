using Lab14_XamarinDB.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_XamarinDB.Repositories
{
    public class TodoPersonaDatabase
    {
        readonly SQLiteAsyncConnection database;

        public TodoPersonaDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Persona>().Wait();
        }

        public Task<List<Persona>> GetPersonasAsync()
        {
            return database.Table<Persona>().ToListAsync();
        }

        public Task<int> SaveItemAsync(Persona persona)
        {
            if (persona.ID != 0)
            {
                return database.UpdateAsync(persona);
            }
            else
            {
                return database.InsertAsync(persona);
            }
        }

        public Task<int> DeleteItemAsync(Persona persona)
        {
            return database.DeleteAsync(persona);
        }


    }
}
