using System.Xml.Serialization;

namespace SkyNeg.Xspf
{
    public class Track
    {
        /// <summary>
        /// URI of resource to be rendered.
        /// Probably an audio resource, but MAY be any type of resource with a well-known duration, such as video, a SMIL document, or an XSPF document.
        /// The duration of the resource defined in this element defines the duration of rendering. xspf:track elements MAY contain zero or more location elements, but a user-agent MUST NOT render more than one of the named resources.
        /// </summary>
        [XmlElement(ElementName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Canonical ID for this resource.
        /// Likely to be a hash or other location-independent name, such as a MusicBrainz identifier.
        /// MUST be a legal URI. xspf:track elements MAY contain zero or more identifier elements.
        /// For example, the URI http://musicbrainz.org/track/7e1d6f5f-0ac3-4889-8b57-506a67b459fc.html is an identifier for a specific song, but dereferencing that identifier will not yield a copy of the song.
        /// </summary>
        [XmlElement(ElementName = "identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Human-readable name of the track that authored the resource which defines the duration of track rendering.
        /// This value is primarily for fuzzy lookups, though a user-agent may display it. xspf:track elements MAY contain exactly one.
        /// </summary>
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Human-readable name of the entity (author, authors, group, company, etc) that authored the resource which defines the duration of track rendering.
        /// This value is primarily for fuzzy lookups, though a user-agent may display it. xspf:track elements MAY contain exactly one.
        /// </summary>
        [XmlElement(ElementName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// A human-readable comment on the track.
        /// This is character data, not HTML, and it may not contain markup. xspf:track elements MAY contain exactly one.
        /// </summary>
        [XmlElement(ElementName = "annotation")]
        public string Annotation { get; set; }

        /// <summary>
        /// URI of a place where this resource can be bought or more info can be found. xspf:track elements MAY contain exactly one.
        /// </summary>
        [XmlElement(ElementName = "info")]
        public string Info { get; set; }

        /// <summary>
        /// URI of an image to display for the duration of the track. xspf:track elements MAY contain exactly one.
        /// </summary>
        [XmlElement(ElementName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// Human-readable name of the collection from which the resource which defines the duration of track rendering comes.
        /// For a song originally published as a part of a CD or LP, this would be the title of the original release.
        /// This value is primarily for fuzzy lookups, though a user-agent may display it. xspf:track elements MAY contain exactly one.
        /// </summary>
        [XmlElement(ElementName = "album")]
        public string Album { get; set; }

        /// <summary>
        /// Integer with value greater than zero giving the ordinal position of the media on the xspf:album.
        /// This value is primarily for fuzzy lookups, though a user-agent may display it. xspf:track elements MAY contain exactly one.
        /// It MUST be a valid XML Schema nonNegativeInteger.
        /// </summary>
        [XmlElement(ElementName = "trackNum")]
        public int TrackNumber { get; set; }

        /// <summary>
        /// The time to render a resource, in milliseconds.
        /// It MUST be a valid XML Schema nonNegativeInteger.
        /// This value is only a hint — different XSPF generators will generate slightly different values.
        /// A user-agent MUST NOT use this value to determine the rendering duration, since the data will likely be low quality. xspf:track elements MAY contain exactly one duration element.
        /// </summary>
        [XmlElement(ElementName = "duration")]
        public long DurationMs { get; set; }

        /// <summary>
        /// The link element allows XSPF to be extended without the use of XML namespaces. xspf:track elements MAY contain zero or more link elements.
        /// </summary>
        [XmlElement(ElementName = "link")]
        public Link Link { get; set; }

        /// <summary>
        /// The meta element allows metadata fields to be added to xspf:track elements. xspf:track elements MAY contain zero or more meta elements.
        /// </summary>
        [XmlElement(ElementName = "meta")]
        public Metadata Meta { get; set; }
    }
}
