using System;
using System.Net;
using System.Text;
using Netasync.Http;
using System.Threading.Tasks; 

namespace Nasa
{

    #region "Nasa Enums and Structures"

    public enum NASA_STATUS : ushort
    {
        NASA_REQUEST_SUCCESS            = 0x0000,
        NASA_REQUEST_UNSUCCESSFUL       = 0x0001,
        NASA_REQUEST_PENDING            = 0x0002,
        NASA_REQUEST_INVALID_API_KEY    = 0x0003
    }

    public enum NASA_DATA_TYPE : byte
    {
        NASA_DATA_STRING    = 0x0000,
        NASA_DATA_ASYNCTASK = 0x0001,
        NASA_DATA_CALLBACK  = 0x0002
    }

    public enum NASA_EPIC_REQUEST_TYPE : byte
    {
        NASA_EPIC_NATURAL_RECENT        = 0x0000,
        NASA_EPIC_NATURAL_DATE          = 0x0001,
        NASA_EPIC_NATURAL_ALL           = 0x0002,
        NASA_EPIC_NATURAL_AVAILABLE     = 0x0003,
        NASA_EPIC_ENHANCED_RECENT       = 0x0004,
        NASA_EPIC_ENHANCED_DATE         = 0x0005,
        NASA_EPIC_ENHANCED_ALL          = 0x0006,
        NASA_EPIC_ENHANCED_AVAILABLE    = 0x0007
    }

    public enum NASA_EARTH_REQUEST_TYPE : byte
    {
        NASA_EARTH_IMAGERY      = 0x0001,
        NASA_EARTH_ASSETS       = 0x0002
    }

    public enum NASA_ASTEROIDS_REQUEST_TYPE : byte
    {
        NEO_FEED        = 0x0001,
        NEO_FEED_TODAY  = 0x0002,
        NEO_SENTRY      = 0x0003,
        NEO_SENTRY_ID   = 0x0004,
        NEO_BROWSE      = 0x0005,
        NEO_ASTEROID_ID = 0x0006,
        NEO_STATS       = 0x0007
    }

    public struct NASA_PACKET_INFO
    {
        public NASA_STATUS PacketStatus { get; set; }
        public NASA_DATA_TYPE PacketDataType { get; set; }
        public object PacketData;
        public Task<string> PacketAsyncTask;
    }

    public class NasaAddresses
    {
        //Astronomic Picture of Day
        public const string NASA_ADDRESS_APOD       = "https://api.nasa.gov/planetary/apod";
        //Mars Rover Photos
        public const string NASA_ADDRESS_MRP        = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos";
        //GeneLab Search
        public const string NASA_ADDRESS_GENELAB    = "https://genelab-data.ndc.nasa.gov/genelab/data/search";
        //Earth Polychromatic Imaging Camera
        public const string NASA_ADDRESS_EPIC       = "https://api.nasa.gov/EPIC/api";
        //Earth LANDSET-8 Google Earth API
        public const string NASA_ADDRESS_EARTH      = "https://api.nasa.gov/planetary/earth";
        //Asteroids NeoWs (Neo Webservice)
        public const string NASA_ADDRESS_ASTEROIDS  = "https://api.nasa.gov/neo";
    }

    #endregion

    public class NasaSecureHttpRequest : IDisposable
    {

        public NasaSecureHttpRequest(String httpAddr, SecurityProtocolType protocolType, CookieContainer secureCookieContainer)
        {
            if (httpAddr != null && httpAddr != String.Empty)
            {
                HttpAddr = httpAddr;
                SecureProtocolType = protocolType;
                SecureCookieContainer = secureCookieContainer;
            }
            else
            {
                NasaRequestStatus = NASA_STATUS.NASA_REQUEST_UNSUCCESSFUL;
            }
        }

        public CookieContainer SecureCookieContainer { get; set; }
        public SecurityProtocolType SecureProtocolType { get; set; }
        public NASA_STATUS NasaRequestStatus { get; set; }
        public String HttpAddr { get; set; }

        //Chamadas síncronas e assíncronas seguras utilizadas nas APIs da Nasa.

        public NASA_PACKET_INFO Post(String QueryString)
        {
            SecurityProtocolType lastSecureProtocol = ServicePointManager.SecurityProtocol;
            ServicePointManager.SecurityProtocol = SecureProtocolType;
            using (Ajax NetasyncAjax = new Ajax(HttpAddr, Encoding.Unicode, SecureCookieContainer, AjaxType.AjaxPOST))
            {
                NASA_PACKET_INFO packetInfo = new NASA_PACKET_INFO();
                packetInfo.PacketDataType = NASA_DATA_TYPE.NASA_DATA_STRING;
                try
                {
                    packetInfo.PacketData = NetasyncAjax.Send(QueryString);
                    packetInfo.PacketStatus = NASA_STATUS.NASA_REQUEST_SUCCESS;
                    NasaRequestStatus = NASA_STATUS.NASA_REQUEST_SUCCESS;
                }
                catch
                {
                    packetInfo.PacketStatus = NASA_STATUS.NASA_REQUEST_UNSUCCESSFUL;
                    NasaRequestStatus = NASA_STATUS.NASA_REQUEST_UNSUCCESSFUL;
                }
                ServicePointManager.SecurityProtocol = lastSecureProtocol;
                return packetInfo;
            }
        }

        public NASA_PACKET_INFO Get(String QueryString)
        {
            SecurityProtocolType lastSecureProtocol = ServicePointManager.SecurityProtocol;
            ServicePointManager.SecurityProtocol = SecureProtocolType;
            using (Ajax NetasyncAjax = new Ajax(HttpAddr, Encoding.Unicode, SecureCookieContainer, AjaxType.AjaxGET))
            {
                NASA_PACKET_INFO packetInfo = new NASA_PACKET_INFO();
                packetInfo.PacketDataType = NASA_DATA_TYPE.NASA_DATA_STRING;
                try
                {
                    packetInfo.PacketData = NetasyncAjax.Send(QueryString);
                    packetInfo.PacketStatus = NASA_STATUS.NASA_REQUEST_SUCCESS;
                    NasaRequestStatus = NASA_STATUS.NASA_REQUEST_SUCCESS;
                }
                catch
                {
                    packetInfo.PacketStatus = NASA_STATUS.NASA_REQUEST_UNSUCCESSFUL;
                    NasaRequestStatus = NASA_STATUS.NASA_REQUEST_UNSUCCESSFUL;
                }
                ServicePointManager.SecurityProtocol = lastSecureProtocol;
                return packetInfo;
            }
        }

        public NASA_PACKET_INFO PostAsync(String QueryString)
        {
            SecurityProtocolType lastSecureProtocol = ServicePointManager.SecurityProtocol;
            ServicePointManager.SecurityProtocol = SecureProtocolType;
            using (Ajax NetasyncAjax = new Ajax(HttpAddr, Encoding.Unicode, SecureCookieContainer, AjaxType.AjaxPOST))
            {
                NASA_PACKET_INFO packetInfo = new NASA_PACKET_INFO();
                packetInfo.PacketDataType = NASA_DATA_TYPE.NASA_DATA_ASYNCTASK;
                try
                {
                    packetInfo.PacketAsyncTask = NetasyncAjax.SendAsync(QueryString);
                    packetInfo.PacketStatus = NASA_STATUS.NASA_REQUEST_SUCCESS;
                    NasaRequestStatus = NASA_STATUS.NASA_REQUEST_SUCCESS;
                }
                catch
                {
                    packetInfo.PacketStatus = NASA_STATUS.NASA_REQUEST_UNSUCCESSFUL;
                    NasaRequestStatus = NASA_STATUS.NASA_REQUEST_UNSUCCESSFUL;
                }
                ServicePointManager.SecurityProtocol = lastSecureProtocol;
                return packetInfo;
            }
        }

        public NASA_PACKET_INFO GetAsync(String QueryString)
        {
            SecurityProtocolType lastSecureProtocol = ServicePointManager.SecurityProtocol;
            ServicePointManager.SecurityProtocol = SecureProtocolType;
            using (Ajax NetasyncAjax = new Ajax(HttpAddr, Encoding.Unicode, SecureCookieContainer, AjaxType.AjaxGET))
            {
                NASA_PACKET_INFO packetInfo = new NASA_PACKET_INFO();
                packetInfo.PacketDataType = NASA_DATA_TYPE.NASA_DATA_ASYNCTASK;
                try
                {
                    packetInfo.PacketAsyncTask = NetasyncAjax.SendAsync(QueryString);
                    packetInfo.PacketStatus = NASA_STATUS.NASA_REQUEST_SUCCESS;
                    NasaRequestStatus = NASA_STATUS.NASA_REQUEST_SUCCESS;
                }
                catch
                {
                    packetInfo.PacketStatus = NASA_STATUS.NASA_REQUEST_UNSUCCESSFUL;
                    NasaRequestStatus = NASA_STATUS.NASA_REQUEST_UNSUCCESSFUL;
                }
                ServicePointManager.SecurityProtocol = lastSecureProtocol;
                return packetInfo;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }
                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                disposedValue = true;
            }
        }

        #region "IDisposable interface"

        private bool disposedValue = false; // To detect redundant calls

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~NasaSecureHttpRequest() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }

    public abstract class NasaConnection : IDisposable
    {
        
        public NasaConnection(String apiKey, SecurityProtocolType protocolType)
        {
            ApiKey = apiKey;
            SecureProtocolType = protocolType;
        }

        public String ApiKey { get; set; }
        
        public async Task<bool> IsValidApiKey()
        {
            using (NasaSecureHttpRequest nasaSecHttpReq = new NasaSecureHttpRequest(NasaAddresses.NASA_ADDRESS_APOD, SecurityProtocolType.Tls12, SecureCookieContainer))
            {
                try
                {
                    NASA_PACKET_INFO responsePacket = nasaSecHttpReq.GetAsync("api_key=" + ApiKey);
                    if (responsePacket.PacketStatus == NASA_STATUS.NASA_REQUEST_SUCCESS || responsePacket.PacketStatus == NASA_STATUS.NASA_REQUEST_PENDING)
                    {
                        if (responsePacket.PacketDataType == NASA_DATA_TYPE.NASA_DATA_ASYNCTASK)
                        {
                            string response = await responsePacket.PacketAsyncTask;
                            if (response.Contains("API_KEY_INVALID"))
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                        else
                        {
                            string response = (string)responsePacket.PacketData;
                            if (response.Contains("API_KEY_INVALID"))
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }

        public SecurityProtocolType SecureProtocolType { get; set; }

        public CookieContainer SecureCookieContainer { get; set; }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }
                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                disposedValue = true;
            }
        }

        #region "IDisposable interface"

        private bool disposedValue = false; // To detect redundant calls

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~NasaRequest() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        #endregion
    }
}
