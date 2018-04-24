using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;

namespace Team_Project
{
    class Login
    {
        public static Dictionary<string, string> LoginInfo = new Dictionary<string, string>();
        
        public async void WriteLoginInfoToFile(string username, string password)
        {
            StorageFolder loginInfoFolder = ApplicationData.Current.LocalFolder;
            StorageFile loginInfoFile = await loginInfoFolder.CreateFileAsync("LoginInfo.txt", CreationCollisionOption.OpenIfExists);

            string[] info = { $"Username: {username}", $"Password: {password}" };

            await FileIO.AppendLinesAsync(loginInfoFile, info);
        }

        public bool ValidateInfo(string username, string password)
        {
            if (!LoginInfo.ContainsKey(username))
            {
                LoginInfo.Add(username, password);
                WriteLoginInfoToFile(username, password);
                MessageDialog message = new MessageDialog($"{username} was successfully added!");
                message.ShowAsync();
                return true; 
            }
            else
            {
                //MessageDialog message = new MessageDialog($"{username} already exists!");
                //message.ShowAsync();
                return false;
            }
        }
    }
}
