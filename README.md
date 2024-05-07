# SkyNeg.Xspf
Library to work with XSPF playlist

## Usage

### Read playlist
Read playlist from stream using [Read(Stream stream)](src/SkyNeg.Xspf/Xspf.cs) method
```C#
var playlist = Xspf.Read(stream);
```

### Write playlist
Write playlist to stream using [Write(Stream stream, Playlist playlist)](src/SkyNeg.Xspf/Xspf.cs) method
```C#
Playlist playlist = new Playlist();
using (var fs = File.Create(path))
{
    Xspf.Save(fs, playlist);
}
```
