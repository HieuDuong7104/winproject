using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.DataClass
{
    public class NguoiTimTho : UserInfo
    {
        List<NguoiTho> FavTho { get; set; }
        List<Post> Posts { get; set; }



        public NguoiTimTho(List<NguoiTho> favtho, List<Post> posts)
        {
            FavTho = favtho ?? new List<NguoiTho>();
            Posts = posts ?? new List<Post>();
        }

        public NguoiTimTho()
        {
            FavTho = new List<NguoiTho>();
            Posts = new List<Post>();
        }
    }
}
