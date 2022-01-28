using UnityEngine;
using UnityEngine.Serialization;


namespace BSMG
{

    [System.Serializable]
    public class SongInfo
    {
        public string _version;
        public string _songName;
        public string _songSubName;
        public string _songAuthorName;
        public string _levelAuthorName;
        public float _beatsPerMinute;
        public float _shuffle;
        public float _shufflePeriod;
        public float previewStartTime;
        public float previewDuration;
        public string _songFilename;
        public string _coverImagePath;
        public string _environmentName;
        public float _songTimeOffset;
        public string _customData;
        public BeatmapCharacteristic[] _difficultyBeatmapSets;


        private static string[] difficulties =
        {
            "Easy",
            "Normal",
            "Hard",
            "Expert",
            "ExpertPlus"
        };

        public DifficultyLevel GetHighestDifficulty()
        {
            DifficultyLevel highestDifficulty = null;
            int highestRank = -1;

            foreach (DifficultyLevel level in _difficultyBeatmapSets[0]._difficultyBeatmaps)
            {
                for (int rank = 0; rank < difficulties.Length; rank++)
                {
                    Debug.Log(difficulties + " rank " + rank + " level diff" + level + level._difficulty);
                    if (level._difficulty.Equals(difficulties[rank]) && rank > highestRank)
                    {
                        highestDifficulty = level;
                        highestRank = rank;
                        break;
                    }
                }
            }

            return highestDifficulty;
        }
    }
}