using UnityEngine;

namespace BSMG
{


    [System.Serializable]
    public class MapData
    {
        public string _version;
        public Note[] _notes;
        public MapObstacles[] _obstacles;
        public MapEvents[] _events;
        public MapWaypoints[] _waypoints;
    }
}
