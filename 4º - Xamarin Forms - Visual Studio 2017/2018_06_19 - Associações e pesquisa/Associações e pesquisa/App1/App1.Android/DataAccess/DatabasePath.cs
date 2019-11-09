using System;
using System.IO;
using App1.Droid.DataAccess;
using Interfaces.DataAccess.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(DatabasePath))]
namespace App1.Droid.DataAccess
{
    public class DatabasePath : IDBPath
    {
        public string GetDbPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Oficina.db");
        }
    }
}