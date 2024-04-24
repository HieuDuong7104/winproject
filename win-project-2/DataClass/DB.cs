using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Firebase.Storage;
using System;
using System.IO;
using System.Threading.Tasks;
using FireSharp;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;


namespace win_project_2.DataClass
{
    public delegate void MessageReceivedHandler(string message);
    public delegate void NotificationReceivedHandler(string notification);
    public class DB
    {
        private IFirebaseConfig config;
        private IFirebaseClient client;

        
        public int postCount;

        string value = GlobalVariables.id;
        public event MessageReceivedHandler OnMessageReceived;
        public event NotificationReceivedHandler OnNotificationReceived;
        public DB()
        {
            config = new FirebaseConfig
            {
                AuthSecret = "bzVpBwNt053VMRWqXMuNt1yL7sAdVeNZMu810ZoW",
                BasePath = "https://win-project-dcfd0-default-rtdb.asia-southeast1.firebasedatabase.app/"
            };
            client = new FirebaseClient(config);
    }

        public async Task<string> uploadFile(string file_path)
        {
            var stream = File.Open(file_path, FileMode.Open);
            var storage = new FirebaseStorage("win-project-dcfd0.appspot.com");
            var task = storage
                .Child("files")
                .Child(Path.GetFileName(file_path))
                .PutAsync(stream);

            string downloadUrl = "";
            try
            {
                downloadUrl = await task;
               
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                stream.Close();
            }
            return downloadUrl;
        }

        //NguoiTimTho
        public async Task UploadInfoNguoiTimTho(NguoiTimTho nguoitimtho) // Upload Info của NguoiTimTho
        {
            SetResponse response = await client.SetAsync("info/nguoitimtho/" + GlobalVariables.id, nguoitimtho);
        }

        public async Task<NguoiTimTho> GetInfoNguoiTimTho(string id) // Lấy Info của NguoiTimTho theo id
        {
            FirebaseResponse response = await client.GetAsync("info/nguoitimtho/" + id);
            NguoiTimTho nguoitimtho = response.ResultAs<NguoiTimTho>();
            return nguoitimtho;
        }

        public async Task<List<NguoiTho>> GetInfoFavTho(string Ids) // Lấy List FavTho của NguoiTimTho
        {
            if (string.IsNullOrEmpty(Ids)) return null;

            List<NguoiTho> usersList = new List<NguoiTho>();
            string[] ids = Ids.Split(',');
            

            foreach (string id in ids)
            {
                NguoiTho user = await GetInfoNguoiTho(id);
                usersList.Add(user);
            }

            return usersList;
        }
        /*
         
            var dt = new DB();
            NguoiTimTho nguoitimtho = await dt.GetInfoNguoiTimTho("test1503");
            //MessageBox.Show(nguoitimtho.FavThoIds);
            List<NguoiTho> listnguoitho = await dt.GetInfoFavTho(nguoitimtho.FavThoIds);
            foreach (NguoiTho nguoitho in listnguoitho)
            {
                Console.WriteLine("Tên: " + nguoitho.Name);
                Console.WriteLine("Ngày sinh: " + nguoitho.DateOfBirth);
                Console.WriteLine("Số điện thoại: " + nguoitho.PhoneNumber);
                Console.WriteLine("Email: " + nguoitho.Email);
                Console.WriteLine("Địa chỉ: " + nguoitho.Address);
                // In thêm các thông tin khác của NguoiTho nếu cần
                Console.WriteLine("---------------------");
            }

         */


        public async Task<Post> GetInfoPost(string id) // Lấy Thông tin Bài đăng theo id
        {
            FirebaseResponse response = await client.GetAsync("post/timtho/" + id);
            Post post = response.ResultAs<Post>();
            return post;
        }

        public async Task<List<Post>> GetListPost(string Ids) // Lấy List tất cả Post
        {
            if (string.IsNullOrEmpty(Ids)) return null;

            List<Post> postsList = new List<Post>();
            string[] ids = Ids.Split(',');


            foreach (string id in ids)
            {
                Post post = await GetInfoPost("p" + id);
                postsList.Add(post);
            }

            return postsList;
        }

        public async Task AddUserToFavorites(string userId)
        {
            
            FirebaseResponse response = await client.GetAsync("info/nguoitimtho/" + GlobalVariables.id + "/FavThoIds");
            var favTho = response.ResultAs<string>();

            
            if (!favTho.Contains(userId))
            {
                if (favTho == "")
                {
                    favTho += userId;
                }
                else
                {
                    favTho += "," + userId;
                }
                SetResponse setResponse = await client.SetAsync("info/nguoitimtho/" + GlobalVariables.id + "/FavThoIds", favTho);
                if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("ID người dùng đã được thêm vào danh sách yêu thích.");
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi thêm ID người dùng.");
                }
            }
            else
            {
                Console.WriteLine("ID người dùng đã tồn tại trong danh sách yêu thích.");
            }
        }



        public async Task<List<NguoiTimTho>> GetAllNguoiTimTho()
        {
            FirebaseResponse response = await client.GetAsync("info/nguoitimtho/");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Lấy dictionary chứa tất cả người tìm thợ
                var allNguoiTimTho = response.ResultAs<Dictionary<string, NguoiTimTho>>();

                // Tạo một list để chứa tất cả thông tin người tìm thợ
                List<NguoiTimTho> listNguoiTimTho = allNguoiTimTho.Values.ToList();

                return listNguoiTimTho;
            }
            else
            {
                Console.WriteLine("Không thể lấy dữ liệu: " + response.StatusCode);
                return new List<NguoiTimTho>(); // Trả về list rỗng nếu có lỗi
            }
        }



        //NguoiTho
        public async Task UploadInfoNguoiTho(NguoiTho nguoitho)
        {
            SetResponse response = await client.SetAsync("info/nguoitho/" + GlobalVariables.id, nguoitho);
        }

        public async Task<NguoiTho> GetInfoNguoiTho(string id)
        {
            FirebaseResponse response = await client.GetAsync("info/nguoitho/" + id);
            NguoiTho nguoitho = response.ResultAs<NguoiTho>();
            return nguoitho;
        }

        public async Task<List<NguoiTho>> GetAllNguoiTho()
        {
            FirebaseResponse response = await client.GetAsync("info/nguoitho/");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Lấy dictionary chứa tất cả thông tin người thợ
                var allNguoiTho = response.ResultAs<Dictionary<string, NguoiTho>>();

                // Tạo một list để chứa tất cả thông tin người thợ
                List<NguoiTho> listNguoiTho = allNguoiTho.Values.ToList();

                return listNguoiTho;
            }
            else
            {
                Console.WriteLine("Không thể lấy dữ liệu: " + response.StatusCode);
                return new List<NguoiTho>(); // Trả về list rỗng nếu có lỗi
            }
        }


        //Post
        public async Task<string> PostArticle(Post post)
        {
            FirebaseResponse response = await client.GetAsync("numPost/timtho");
            int postCount = response.ResultAs<int>();
            postCount++;

            SetResponse setResponse = await client.SetAsync("numPost/timtho", postCount);
            if (setResponse.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Failed to increment post count.");
                return null; // Hoặc xử lý lỗi theo cách khác
            }

            post.Id = postCount.ToString();
            SetResponse postResponse = await client.SetAsync("post/timtho/" + "p" + post.Id + "/", post);
            if (postResponse.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Failed to post article.");
                return null; // Hoặc xử lý lỗi theo cách khác
            }

            return post.Id;
        }


        public async Task<List<Post>> GetAllPosts()
        {
            FirebaseResponse response = await client.GetAsync("post/timtho/");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Lấy dictionary chứa tất cả bài đăng
                var allPosts = response.ResultAs<Dictionary<string, Post>>();

                // Tạo một list để chứa tất cả thông tin bài đăng
                List<Post> listPosts = allPosts.Values.ToList();

                return listPosts;
            }
            else
            {
                Console.WriteLine("Không thể lấy dữ liệu: " + response.StatusCode);
                return new List<Post>(); // Trả về list rỗng nếu có lỗi
            }
        }

        public async Task AddPostToDonePost(string postId)
        {

            FirebaseResponse response = await client.GetAsync("info/nguoitho/" + GlobalVariables.id + "/DonePostIds");
            var donePost = response.ResultAs<string>();


            if (!donePost.Contains(postId))
            {
                if (donePost == "")
                {
                    donePost += postId;
                }
                else
                {
                    donePost += "," + postId;
                }
                SetResponse setResponse = await client.SetAsync("info/nguoitho/" + GlobalVariables.id + "/DonePostIds", donePost);
                if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("ID người dùng đã được thêm vào danh sách yêu thích.");
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi thêm ID người dùng.");
                }
            }
            else
            {
                Console.WriteLine("ID người dùng đã tồn tại trong danh sách yêu thích.");
            }
        }

        public async Task AddPostToPosted(string postId)
        {

            FirebaseResponse response = await client.GetAsync("info/nguoitimtho/" + GlobalVariables.id + "/PostIds");
            var Posted = response.ResultAs<string>();


            if (!Posted.Contains(postId))
            {
                if (Posted == "")
                {
                    Posted += postId;
                }
                else
                {
                    Posted += "," + postId;
                }
                SetResponse setResponse = await client.SetAsync("info/nguoitimtho/" + GlobalVariables.id + "/PostIds", Posted);
                if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("ID người dùng đã được thêm vào danh sách yêu thích.");
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi thêm ID người dùng.");
                }
            }
            else
            {
                Console.WriteLine("ID người dùng đã tồn tại trong danh sách yêu thích.");
            }
        }

        public async Task UpReview(Review review, string idnguoitho) // idnguoitho là id NguoiTho muốn đánh giá, GlobalVariables.id là id của người đang review (NguoiTimTho)
        {
            SetResponse response = await client.SetAsync("review/" + idnguoitho + "/" + GlobalVariables.id, review);
        }

        public async Task UpdateRate(string nguoithoid, float rate)
        {
            SetResponse response = await client.SetAsync("info/nguoitho/" + nguoithoid + "/rate", rate);
        }

        public async Task<List<Review>> GetAllReview(string nguoithoid)
        {
            FirebaseResponse response = await client.GetAsync("review/" + nguoithoid + "/");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Lấy dictionary chứa tất cả bài đăng
                var allReview = response.ResultAs<Dictionary<string, Review>>();
                if (allReview == null)
                {
                    return null;
                }
                // Tạo một list để chứa tất cả thông tin bài đăng
                List<Review> listReview = allReview.Values.ToList();

                return listReview;
            }
            else
            {
                Console.WriteLine("Không thể lấy dữ liệu: " + response.StatusCode);
                return new List<Review>(); // Trả về list rỗng nếu có lỗi
            }
        }

        public async void SendMessage(string roomId, string tinnhan)
        {
            FirebaseResponse response = await client.GetAsync("message/" + roomId + "/" + "count");
            // Kiểm tra nếu giá trị trả về là null và gán count = 0
            int count = response.Body == "null" ? 0 : response.ResultAs<int>();
            count++;
            SetResponse setResponse = await client.SetAsync("message/" + roomId + "/" + "count", count);
            SetResponse Messresponse = await client.SetAsync("message/" + roomId + "/" + count, tinnhan);
        }


        public async Task<List<string>> GetAllMessagesAsync(string roomId)
        {
            FirebaseResponse response = await client.GetAsync("message/" + "idroom");
            Dictionary<string, string> messages = response.ResultAs<Dictionary<string, string>>();
            List<string> messageList = new List<string>();

            foreach (var message in messages)
            {
                messageList.Add(message.Value);
            }

            return messageList;
        }

        public string LatestMessage { get; private set; }

        public async void ListenForNewMessages(string roomId)
        {
            EventStreamResponse response = await client.OnAsync("message/" + roomId + "/",
                added: (sender, args, context) =>
                {
                    //Console.WriteLine("New message received: " + args.Data);
                    OnMessageReceived?.Invoke(args.Data);
                });
        }

        public async Task AddtoContact(string id)
        {
            FirebaseResponse response = await client.GetAsync("contactlist/" + GlobalVariables.id);
            var contact = response.ResultAs<string>();

            // Kiểm tra nếu contact là null hoặc không chứa id
            if (contact == null || !contact.Contains(id))
            {
                // Nếu contact là null hoặc rỗng, gán trực tiếp id
                contact = contact == null || contact == "" ? id : contact + "," + id;

                SetResponse setResponse = await client.SetAsync("contactlist/" + GlobalVariables.id, contact);
                if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra");
                }
            }
            else
            {
                Console.WriteLine("Đã tồn tại");
            }
        }

        public async Task<string> GetContactList(string userId)
        {
            FirebaseResponse response = await client.GetAsync("contactlist/" + userId);
            string contactList = response.ResultAs<string>(); // Lấy chuỗi contact list

            if (contactList != null)
            {
                return contactList; // Trả về chuỗi contact list nếu tồn tại
            }
            else
            {
                return ""; // Trả về chuỗi rỗng nếu không tìm thấy
            }
        }

        public async Task ApplyForJob(string jobId, string workerId)
        {
            // Lấy danh sách ID người thợ đã apply từ database
            FirebaseResponse response = await client.GetAsync("jobs/" + jobId + "/applicants");
            var applicants = response.ResultAs<string>();

            // Kiểm tra xem người thợ đã apply chưa
            if (applicants == null || !applicants.Contains(workerId))
            {
                // Cập nhật danh sách người thợ đã apply
                applicants = applicants == null || applicants == "" ? workerId : applicants + "," + workerId;
                SetResponse setResponse = await client.SetAsync("jobs/" + jobId + "/applicants", applicants);

                if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine("Người thợ đã được thêm vào danh sách ứng viên.");
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi thêm người thợ vào danh sách ứng viên.");
                }
            }
            else
            {
                Console.WriteLine("Người thợ đã tồn tại trong danh sách ứng viên.");
            }
        }

        public async Task NotifyWorker(string workerId, string message)
        {
            // Gửi thông báo đến người thợ
            PushResponse pushResponse = await client.PushAsync("notifications/" + workerId, message);

            if (pushResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Thông báo đã được gửi.");
            }
            else
            {
                Console.WriteLine("Có lỗi xảy ra khi gửi thông báo.");
            }
        }

        public string LatestNotify { get; private set; }

        public async void ListenForNewNotify(string workerId)
        {
            EventStreamResponse response = await client.OnAsync("notifications/" + workerId + "/",
                added: (sender, args, context) =>
                {
                    //Console.WriteLine("New notification received: " + args.Data);
                    OnNotificationReceived?.Invoke(args.Data);
                });
        }

    }
}
