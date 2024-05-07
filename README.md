# SkyNeg.Xspf
Library to work with XSPF playlist

## Usage

### Read playlist
Read playlist from stream using [Read(Stream stream)](src/SkyNeg.Xspf/XspfDocument.cs) method
```C#
var playlist = XspfDocument.Read(stream);
```

### Write playlist
Write playlist to stream using [Write(Stream stream, Playlist playlist)](src/SkyNeg.Xspf/XspfDocument.cs) method
```C#
Playlist playlist = new Playlist();
using (var fs = File.Create(path))
{
    XspfDocument.Write(fs, playlist);
}
```
