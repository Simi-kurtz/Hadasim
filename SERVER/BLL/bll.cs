using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class bll
    {

        public bll(){
        }
        public void AddUser(UserModel user)
        {
            ConnectToDB c = new ConnectToDB();

            c.AddUser(user);
        }
    }
}
