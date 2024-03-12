using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Firebase.Storage;
using System;
using System.IO;
using System.Threading.Tasks;
using FireSharp;
using System.Windows.Forms;

namespace win_project_2
{
    internal class Data
    {
        private IFirebaseConfig config;
        private IFirebaseClient client;
        string value = GlobalVariables.Variable;
        public Data()
        {
            config = new FirebaseConfig
            {
                AuthSecret = "bzVpBwNt053VMRWqXMuNt1yL7sAdVeNZMu810ZoW",
                BasePath = "https://win-project-dcfd0-default-rtdb.asia-southeast1.firebasedatabase.app/"
            };
            client = new FirebaseClient(config);
        }

        public async void uploadFile(string file_path)
        {
            // Sử dụng @ để chỉ định đường dẫn nguyên vẹn
            var stream = File.Open(file_path, FileMode.Open);

            var task = new FirebaseStorage("win-project-dcfd0.appspot.com")
                .Child("files")
                .Child(Path.GetFileName(file_path))
                .PutAsync(stream);

            try
            {
                var downloadUrl = await task;
                // Sử dụng downloadUrl theo nhu cầu của bạn
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                stream.Close(); // Đảm bảo đóng stream sau khi sử dụng
            }
        }


        public async Task UploadData(string file_path ,UserInfo userinfo)
        {
            //userinfo.AvatarUrl = await UploadImageAndGetUrl(userinfo.AvatarUrl);

            SetResponse response = await client.SetAsync(file_path, userinfo);
        }

        public async Task<UserInfo> GetData(string path)
        {
            FirebaseResponse response = await client.GetAsync(path);
            UserInfo userinfo = response.ResultAs<UserInfo>();
            return userinfo;
        }
    }
}
