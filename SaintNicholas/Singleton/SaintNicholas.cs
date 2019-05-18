using System;

namespace SaintNicholas.Singleton
{
    public class SaintNicholas
    {
        private int _logCount = 0;
        private static SaintNicholas _saintNicholas;
        private static readonly object Locker = new object();

        private SaintNicholas()
        {
        }

        public static SaintNicholas GetSaintNicholas()
        {
            lock (Locker)
            {
                if (_saintNicholas == null)
                {
                    _saintNicholas = new SaintNicholas();
                }
            }

            return _saintNicholas;
        }

        public void Log(String message)
        {
            Console.WriteLine(_logCount + ": " + message);
            _logCount++;
        }
    }
}
