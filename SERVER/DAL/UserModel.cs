using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace DAL
{
    public class UserModel
    {
        private static ConnectToDB connection = new ConnectToDB();


        [BsonId]
        //[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string Street{ get; set; }
        public string HouseNum { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate = new DateTime();
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string VaccineManufacturer { get; set; }

        private List<DateTime> dateOfReceiptOfVaccinations = new List<DateTime>(4);
        
        private List<DateTime> positiveOutcomeDateAndRecoveryDate = new List<DateTime>(2);
        public List<DateTime> DateOfReceiptOfVaccinations { get => dateOfReceiptOfVaccinations; set => dateOfReceiptOfVaccinations = value; }
        public List<DateTime> PositiveOutcomeDateAndRecoveryDate { get => positiveOutcomeDateAndRecoveryDate; set => positiveOutcomeDateAndRecoveryDate = value; }


        public bool AddUser()
        {
            return connection.AddUser(this);
        }
        public bool CheckUser(UserModel u)
        {
            return connection.CheckUser(u).Result;
        }
        public List<UserModel> GetUsers()
        {
            return connection.GetUsers();
        }

        public UserModel GetUser(string ID)
        {
            return connection.GetUser(ID);
        }
        public int GetNotVaccinated()
        {
            return connection.GetNotVaccinated();
        }

        public Dictionary<int,int> GetActivePatients()
        {
            return connection.GetActivePatients();
        }

    }
}
