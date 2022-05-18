using System;

namespace Anamon.GameDigest.Models
{
    public interface FileDigest {
        public string Path { get; set; }
        public string Filename { get; set; }
        public int Filesize { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public byte[] MagicBytes { get; set; }
        public string Crc32 { get; set; }
        public string Md5 { get; set; }
        public string Sha256 { get; set; }
    }
}
