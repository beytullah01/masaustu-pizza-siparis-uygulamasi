using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace pizzacim
{
    class baglan
    {
        public string baglanti()
        {



            MySqlConnectionStringBuilder bag = new MySqlConnectionStringBuilder();



            bag.Server = "localhost"; // Mysql veritabanına girerken yazdığınız server adı bende localhost 

            bag.Password = ""; //kullanıcı parolam root sizde değişik olabilir..

            bag.Database = "pizza"; // database ismimiz

            bag.UserID = "root"; //Bu da kullanıcı adınız

            return bag.ToString();

           
        }


    }
}
