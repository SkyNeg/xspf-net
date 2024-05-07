using System.Xml.Serialization;

namespace SkyNeg.Xspf
{
    public class Metadata
    {
        /// <summary>
        /// URI of a resource defining the metadata.
        /// </summary>
        [XmlAttribute(AttributeName = "rel")]
        public string Rel { get; set; }

        /// <summary>
        /// Value of the metadata element.
        /// This is plain old text, not XML, and it may not contain markup. xspf:playlist elements MAY contain exactly one.
        /// </summary>
        [XmlText]
        public string Content { get; set; }
    }
}
