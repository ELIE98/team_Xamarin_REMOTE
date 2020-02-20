using System;
using System.Threading.Tasks;
using RestoNaN;
using SQLite;

namespace RestoNaN
{
    public class SqLiteHelper
    {

        SQLiteAsyncConnection db;

        public SqLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Person>().Wait();
        }

        public Task<int> inscription(Person pers)
        {
            return db.InsertAsync(pers);
        }



        public Task<Person> connexion(string email, string password)
        {
            return db.Table<Person>().Where(i => i.email == email && i.password == password).FirstOrDefaultAsync();
        }



    }
}
