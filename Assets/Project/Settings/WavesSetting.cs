using System;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Settings
{
    [CreateAssetMenu(menuName = "Game/New Waves Setting", fileName = "WavesSettings")]
    public class WavesSetting : ScriptableObject
    {
        public List<WaveSetting> Waves = new();
    }

    [Serializable]
    public class WaveSetting
    {
        public MobSetting mobSetting;
        public int mobsAmount;
        public float delayBetweenMobs;
    }
}