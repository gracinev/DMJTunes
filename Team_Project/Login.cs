using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Team_Project
{
    class Login
    {
        public Dictionary<string, string> LoginInfo = new Dictionary<string, string>();

        public void ValidateInput()
        {

        }

        public async void WriteLoginInfoToFile(string username, string password)
        {
            StorageFolder loginInfoFolder = ApplicationData.Current.LocalFolder;
            StorageFile loginInfoFile = await loginInfoFolder.CreateFileAsync("LoginInfo.txt", CreationCollisionOption.OpenIfExists);

            string[] info = { $"Username: {username}", $"Password: {password}" };

            await FileIO.AppendLinesAsync(loginInfoFile, info);
        }
    }
}
