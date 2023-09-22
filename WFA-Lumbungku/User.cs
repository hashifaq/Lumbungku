using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA-Lumbungku
{
    internal class User
    {
        private int user_id { get; set; }
        private string username { get; set; }
        private string password { get; set; }
        private string name { get; set; }
        private int coor_lon { get; set; }
        private int coor_lat { get; set; }

        public int User_id
        {
            get { return user_id; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Coor_lon
        {
            get { return coor_lon; }
        }

        public int Coor_lat
        {
            get { return coor_lat; }
        }

        public void login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void signUp(string username, string password, string name, int coor_lon, int coor_lat)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.coor_lon = coor_lon;
            this.coor_lat = coor_lat;
        }

        public void forgetPassword(string username, string name)
        {
            this.username = username;
            this.name = name;
        }

        public void resetPassword(string username, string newPassword)
        {
            this.username = username;
            this.password = newPassword;
        }

        public object getProfile(int user_id)
        {
            this.user_id = user_id;
        }

        public void updateProfile(int user_id)
        {
            this.user_id = user_id;
        }

        public void logout()
        {
            //code
        }
    }

}