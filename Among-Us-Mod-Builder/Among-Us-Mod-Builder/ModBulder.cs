using System;

namespace ModManager4.Class
{
    public class ModBulder
    {
        internal object logs;
        internal string tempPath;
        internal string token;

        public Version version { get; internal set; }
        public object utils { get; internal set; }

        internal void log(string v)
        {
            throw new NotImplementedException();
        }

        internal void FileDelete(string installerPath)
        {
            throw new NotImplementedException();
        }
    }
}