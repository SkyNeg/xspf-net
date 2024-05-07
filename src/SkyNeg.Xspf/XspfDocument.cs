using System.IO;
using System.Xml.Serialization;

namespace SkyNeg.Xspf
{
    public static class XspfDocument
    {
        public const string NamespacePrefix = "xspf";
        public const string Namespace = "http://xspf.org/ns/0/";
        public const int Version = 1;

        public static Playlist Read(Stream stream)
        {
            var xmlSerializer = new XmlSerializer(typeof(Playlist), Namespace);
            var playlist = (Playlist)xmlSerializer.Deserialize(stream);
            return playlist;
        }

        public static void Write(Stream stream, Playlist playlist)
        {
            var xmlSerializer = new XmlSerializer(typeof(Playlist), Namespace);
            xmlSerializer.Serialize(stream, playlist);
        }
    }
}
