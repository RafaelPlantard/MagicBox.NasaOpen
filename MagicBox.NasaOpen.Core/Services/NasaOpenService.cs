using System;

namespace MagicBox.NasaOpen.Services
{
    /// <summary>
    /// The singleton for NASA Open APIs services.
    /// </summary>
    public sealed class NasaOpenService : INasaOpenService
    {
        public INasaApi Api
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}