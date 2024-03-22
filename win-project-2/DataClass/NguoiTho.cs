using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2
{
    public class NguoiTho : UserInfo
    {
        public string JobName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Skills { get; set; }
        public string JobLocation { get; set; }
        public string Study { get; set; }
        public List<Post> DonePosts { get; set; }

        // Constructor với tất cả các thuộc tính
        public NguoiTho(string jobName, string description, double price, string skills, string jobLocation, string study, List<Post> donePosts)
        {
            JobName = jobName;
            Description = description;
            Price = price;
            Skills = skills;
            JobLocation = jobLocation;
            Study = study;
            DonePosts = donePosts ?? new List<Post>(); 
        }

        // Constructor mặc định
        public NguoiTho()
        {
            DonePosts = new List<Post>();
        }
    }

}
