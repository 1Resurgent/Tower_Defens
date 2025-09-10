using UnityEngine;

namespace Project.Settings
{
    [CreateAssetMenu(menuName = "Game/New mobSetting", fileName = "NewMobSetting")]
    public class MobSetting : ScriptableObject
    {
        public int MaxHealth;
        public float Speed;
        public Enemy Prefab;
    }
}