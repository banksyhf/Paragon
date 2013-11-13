using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Paragon_Database.Settings
{
    internal static class ApplicationSettings
    {
        /// <summary>
        /// Must be called before changing any properties. Sets up a base config file.
        /// </summary>
        public static void Initialize()
        {
            _initialized = true;
            if (!File.Exists(IniPath))
                File.Create(IniPath).Close();

            _ini = new IniFile(IniPath);
            _connectionString = _ini.IniReadValue(INI_SECTION, "connectionString");
        }

        private static void ChangeSetting(string name, string value)
        {
            _ini.IniWriteValue(INI_SECTION, name, value);
        }

        private static void CheckInitialized()
        {
            if (!_initialized)
                throw new InvalidOperationException("ApplicationSettings.Initialize() method must be called first.");
        }


        private static string _connectionString;
        public static string ConnectionString
        {
            get
            {
                CheckInitialized();

                return _connectionString;
            }
            set
            {
                CheckInitialized();

                _connectionString = value;
                ChangeSetting("connectionString", value);
            }
        }

        private const string INI_SECTION = "Database";
        private static readonly string IniPath = Path.Combine(Application.StartupPath, "database.ini");
        private static bool _initialized = false;
        private static IniFile _ini;
    }
}
