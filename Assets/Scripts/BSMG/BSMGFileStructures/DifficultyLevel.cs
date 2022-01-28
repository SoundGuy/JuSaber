using UnityEngine;
using UnityEngine.Serialization;


namespace BSMG
{

    [System.Serializable]
    public class DifficultyLevel
    {
        public string _difficulty;
        public int _difficultyRank;
        public string _beatmapFilename;
        public float _noteJumpMovementSpeed;
        public float _noteJumpStartBeatOffset;
        public string _customData;
    }


}