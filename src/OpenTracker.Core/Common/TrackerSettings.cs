﻿using System;
using System.Web;
using System.Web.Configuration;

namespace OpenTracker.Core.Common
{
    public class TrackerSettings
    {
        /// <summary>
        /// Retrieves Configuration Variables
        /// </summary>
        /// <param name="appSetting"></param>
        /// <returns></returns>
        private static string GetSpecificAppSetting(string appSetting)
        {
            return WebConfigurationManager.AppSettings[appSetting];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string BASE_URL
        {
            get { return GetSpecificAppSetting("BASE_URL"); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string REQUIRE_SSL
        {
            get { return GetSpecificAppSetting("REQUIRE_SSL"); }
        }

        /// <summary>
        /// Tracker update interval in seconds. 
        /// 30 minutes (1800 seconds) is default
        /// </summary>
        public static int ANNOUNCE_INTERVAL
        {
            get { return int.Parse(GetSpecificAppSetting("ANNOUNCE_INTERVAL")); }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string TORRENT_DIRECTORY
        {
            get { return HttpContext.Current.Server.MapPath(GetSpecificAppSetting("TORRENT_DIRECTORY")); }
        }

        /// <summary>
        /// /
        /// </summary>
        /// <returns></returns>
        public static string NFO_DIRECTORY
        {
            get { return HttpContext.Current.Server.MapPath(GetSpecificAppSetting("NFO_DIRECTORY")); }
        }

        /// <summary>
        /// Determines wether the server should ping 
        /// the client for a connectability check
        /// </summary>
        public static bool CHECK_CONNECTABLE
        {
            get { return Convert.ToBoolean(GetSpecificAppSetting("CHECK_CONNECTABLE")); }
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool BLACKLIST_PORTS
        {
            get { return Convert.ToBoolean(GetSpecificAppSetting("BLACKLIST_PORTS")); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string TORRENT_NAME_PREFIX
        {
            get { return GetSpecificAppSetting("TORRENT_NAME_PREFIX"); }
        }



    }
}
