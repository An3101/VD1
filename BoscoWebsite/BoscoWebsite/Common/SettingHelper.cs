using BoscoWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoscoWebsite.Common
{
    
    public class SettingHelper
    {
        private static ApplicationDbContext dbConnect = new ApplicationDbContext();
        public static string GetValue(string key)
        {
            var item = dbConnect.systemSettings.SingleOrDefault(x => x.SettingKey == key);
            if (item != null)
            {
                return item.SettingValue;
            }
            return "";
        }

    }
}