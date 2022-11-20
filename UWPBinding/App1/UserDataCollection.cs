using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class UserDataCollection : ObservableCollection<UserData>
    {
        public UserDataCollection()
        {
            // Sample data loaded here. Replace with data from your database

            this.Add(new UserData()
            {
                UserName = "user1",
                FirstName = "FN1",
                LastName = "LN1",
                Email = "user1@nowhere.local"
            });

            this.Add(new UserData()
            {
                UserName = "user2",
                FirstName = "FN2",
                LastName = "LN2",
                Email = "user2@nowhere.local"
            });

            this.Add(new UserData()
            {
                UserName = "user3",
                FirstName = "FN3",
                LastName = "LN3",
                Email = "user3@nowhere.local"
            });
        }
    }

    public class UserData
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
