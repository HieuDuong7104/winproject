using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Firebase.Storage;
using System;
using System.IO;
using System.Threading.Tasks;
using FireSharp;

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

        public async Task<string> UploadImageAndGetUrl(string localImagePath)
        {
            var storage = new FirebaseStorage("gs://win-project-dcfd0.appspot.com");
            var imageUrl = await storage
                .Child("folder_name")
                .Child(Path.GetFileName(localImagePath))
                .PutAsync(File.OpenRead(localImagePath));

            return imageUrl;
        }

        public async Task UploadData(UserInfo userinfo)
        {
            //userinfo.AvatarUrl = await UploadImageAndGetUrl(userinfo.AvatarUrl);

            SetResponse response = await client.SetAsync("info/" + value + "/", userinfo);
        }

        public async Task<UserInfo> GetData(string path)
        {
            FirebaseResponse response = await client.GetAsync(path);
            UserInfo userinfo = response.ResultAs<UserInfo>();
            return userinfo;
        }
    }
}
