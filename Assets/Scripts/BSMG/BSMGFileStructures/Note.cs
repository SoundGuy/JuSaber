﻿using UnityEngine;


namespace BSMG
{

    [System.Serializable]
    public class Note
    {
        public float _time;
        public int _lineIndex;
        public int _lineLayer;
        public int _type;
        public int _cutDirection;
        public string _customData;


        // TODO: move these out of this class in to a monobehaviour
        private bool alreadyHit = false;
        private bool alreadyMissed = false;

        public bool NotYetHit()
        {
            return !alreadyHit;
        }

        public bool NotYetMissed()
        {
            return !alreadyMissed;
        }

        public void Hit()
        {
            alreadyHit = true;
        }

        public void Miss()
        {
            alreadyMissed = true;
        }
    }
}