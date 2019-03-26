using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Domain.Entities
{
    public class ProductDetail : BaseModel
    {
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }

        public virtual ApplicationUser Creator { get; set; }
        public string CreatorId { get; set; }

        public string Weight { get; set; }
        public bool IncrementalMemory { get; set; }
        public string InternalMemory { get; set; }
        public string ScreenSize { get; set; }
        public bool TouchScreen { get; set; }
        public string ScreenResolution { get; set; }
        public bool Camera { get; set; }
        public bool FrontCamera { get; set; }
        public bool Flash { get; set; }
        public string ScreenType { get; set; }
        public bool VideoConversation { get; set; }
        public bool GPS { get; set; }
        public string OperatingSystem { get; set; }
        public string OperatingType { get; set; }
        public string BackCameraResolution { get; set; }
        public string FrontCameraResolution { get; set; }
        public string MobileLinkSpeed { get; set; }
        public bool MMS { get; set; }
        public string SpeechTime { get; set; }
        public bool MP3Playback { get; set; }
        public bool NFC { get; set; }
        public bool DownloadGame { get; set; }
        public string PackageIncluded { get; set; }
        public bool FingerprintReader { get; set; }
        public string BatteryPower { get; set; }
        public string BatteryType { get; set; }
        public bool EmailSupport { get; set; }
        public bool RadioSupport { get; set; }
        public string RAM { get; set; }
        public bool VoiceReport { get; set; }
        public bool VoiceCall { get; set; }
        public bool AudioVideoRecording { get; set; }
        public bool TvSupport { get; set; }
        public string Wifi { get; set; }
        public bool FaceRecognition { get; set; }
        public bool VideoPlayback { get; set; }
        public bool InternalModem { get; set; }
        public string StandbyTime { get; set; }
        public bool DoubleLine { get; set; }
        public bool EyeScanning { get; set; }
        public bool Edge { get; set; }
    }
}
