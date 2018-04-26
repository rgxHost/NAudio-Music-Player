using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    class TrackData : IDisposable
    {
        public int Index { get; set; }
        public string Path { get; set; }
        public string Extension { get; set; }
        public string FileName { get; set; }

        #region <Dispose>
        protected virtual void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                // Dispose Managed Resources
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
