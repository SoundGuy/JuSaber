using System.IO;
using UnityEngine;


namespace BSMG
{

    public class Song
    {

        public SongInfo songInfo;
        private string path;

        public Song(SongInfo songInfo, string path)
        {
            this.songInfo = songInfo;
            this.path = path;
        }

        public string GetName()
        {
            return songInfo._songName;
        }

        public string GetSoundFilePath()
        {
            return Path.Combine(path, songInfo._songFilename);
        }

        public MapData GetMapData()
        {
            return FileLoader.LoadMapData(songInfo.GetHighestDifficulty(), path);
        }

        public float GetOffset()
        {
            return songInfo._songTimeOffset;
        }
    }
}