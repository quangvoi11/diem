using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diem.quang
{
    class quanlidiem
    {
       public static  SqlConnection con = new SqlConnection("Data Source=QUANGVOIDEVICE\\SQLEXPRESS;Initial Catalog=diem;Integrated Security=True");
    }
}
