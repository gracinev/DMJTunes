using System;
using System.Collections.Generic;
using System.IO;
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

        public Login()
        {
            //LoadInfoFromFile(); this method crashses the program!
        }
        public async void WriteLoginInfoToFile(string username, string password)
        {
            StorageFolder loginInfoFolder = ApplicationData.Current.LocalFolder;
            StorageFile loginInfoFile = await loginInfoFolder.CreateFileAsync("LoginInfo.txt", CreationCollisionOption.OpenIfExists);

            string[] info = { $"Username: {username}", $"Password: {password}" };

            await FileIO.AppendLinesAsync(loginInfoFile, info);
        }

        public void ValidateInfo(string username, string password)
        {
            if (!LoginInfo.ContainsKey(username))
            {
                LoginInfo.Add(username, password);
                WriteLoginInfoToFile(username, password);
                MessageDialog message = new MessageDialog($"{username} was successfully added!");
                message.ShowAsync();
            }
            else
            {
                MessageDialog message = new MessageDialog($"{username} already exists!");
                message.ShowAsync();
            }
        }

        public async void LoadInfoFromFile()
        {
            StorageFolder loginInfoFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            StorageFile loginInfoFile = await loginInfoFolder.GetFileAsync("LoginInfo.txt");

            var lines = File.ReadAllLines(loginInfoFile.Path);

            foreach (var line in lines)
            {
                string[] loginSplit = line.Split(new char[] { ' ', ',', '?', ':', '.', '!' }, StringSplitOptions.RemoveEmptyEntries);
                LoginInfo.Add(loginSplit[0], loginSplit[1]);
            }

        }
    }
}
