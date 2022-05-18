using System;

using Anamon.GameDigest.Models.Enums;

namespace Anamon.GameDigest.Models
{
    public interface Digest {
        public string? ReleaseName { get; set; }
        public ReleaseType? ReleaseType { get; set; }
        public FileDigest[] FileDigests { get; set; }
        public string? Source { get; set; }
        public string? Archivist { get; set; }
        public DateTime? Archived { get; set; }
    }
}
