using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Drawing;
using System.IO;

namespace DAL
{
    public class ConnectToDB
    {
        static MongoClient dbClient = new MongoClient("mongodb://localhost:27017");

        private IMongoCollection<T> GetCollection<T>(in string collectionName)
        {
            var db = dbClient.GetDatabase("HMO");
            return db.GetCollection<T>(collectionName);
        }

        public List<UserModel> GetUsers()
        {
            var db = dbClient.GetDatabase("HMO");
            var usersCollection = db.GetCollection<UserModel>("users");
            var documents = IMongoCollectionExtensions.Find<UserModel>(usersCollection, u => true).ToList();
            List<UserModel> users = new List<UserModel>();
            foreach (var document in documents)
            {
                users.Add(document);
            }
            return users;
        }

        public UserModel GetUser(string ID)
        {
            var db = dbClient.GetDatabase("HMO");
            var usersCollection = db.GetCollection<UserModel>("users");
            var documents = IMongoCollectionExtensions.Find<UserModel>(usersCollection, u => u.UserId == ID).ToList();
            UserModel user = new UserModel();
            foreach (var document in documents)
            {
                user = document;
            }
            return user;    
        }

        /// <summary>
        /// How many Copa members are not vaccinated at all?
        /// </summary>
        /// <returns></returns>
        public int GetNotVaccinated()
        {
            var db = dbClient.GetDatabase("HMO");
            var usersCollection = db.GetCollection<UserModel>("users");
            var documents = IMongoCollectionExtensions.Find<UserModel>(usersCollection, u => u.DateOfReceiptOfVaccinations.Count() == 0).ToList();
            List<UserModel> users = new List<UserModel>();
            foreach (var document in documents)
            {
                users.Add(document);
            }
            //List <UserModel> user = usersCollection;
            return users.Count();
        }

        /// <summary>
        /// How many patients are active every day in the last month
        /// </summary>
        /// <returns></returns>
        public Dictionary<int,int> GetActivePatients()
        {
            var db = dbClient.GetDatabase("HMO");
            var usersCollection = db.GetCollection<UserModel>("users");
            var documents = IMongoCollectionExtensions.Find<UserModel>(usersCollection, u => true).ToList();
            Dictionary<int,int> DActivPatients = new Dictionary<int,int>();
            for(int i=1;i<=31;i++)
            {
                DActivPatients[i] = 0;
            }
            foreach (var document in documents)
            {
                if (IsInLastMonth(document.PositiveOutcomeDateAndRecoveryDate[0]))
                {
                    int day = document.PositiveOutcomeDateAndRecoveryDate[0].Day;
                    DActivPatients[day] += 1;
                }   
            }
            return DActivPatients;
        }

        bool IsInLastMonth(DateTime dt)
        {
            DateTime lastMonth = DateTime.Today.AddMonths(-1);
            return dt.Month == lastMonth.Month && dt.Year == lastMonth.Year;
        }

        public bool AddUser(UserModel user)
        {
            var collection = GetCollection<UserModel>("users");
            Task<bool> flag = CheckUserAdd(user);
            if (flag.Result == false)
            {
               collection.InsertOne(user);
                return true;
            }              
            else
            {
                return false;
            }
        }

        public async Task<bool> CheckUserAdd(UserModel user)
        {
            var collection = GetCollection<UserModel>("users");
            var answer = await collection.FindAsync<UserModel>(u => u.UserId == user.UserId).ConfigureAwait(false);
            if (answer.ToList().Count() > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> CheckUser(UserModel user)
        {
            var collection = GetCollection<UserModel>("users");
            var answer = await collection.FindAsync<UserModel>(u => u.UserId == user.UserId ).ConfigureAwait(false);
            if (answer.ToList().Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }  
}
