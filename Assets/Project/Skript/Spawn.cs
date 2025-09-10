using System;
using System.Collections;
using System.Threading;
using Project.Settings;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private WavesSetting _wavesSetting;
    
    [SerializeField]
    private float Timer;

    [SerializeField]
    private Transform _parent;

    private void Start()
    {
        StartCoroutine(SpawningCoroutine());
    }

    private IEnumerator SpawningCoroutine()
    {
        foreach (var wave in _wavesSetting.Waves)
        {
            for (int i = 0; i < wave.mobsAmount; i++)
            {
                SpawnMob(wave.mobSetting.Prefab);
                yield return new WaitForSeconds(wave.delayBetweenMobs);
            }
            
            yield return new WaitForSeconds(3f);
        }
    }

    public void SpawnMob(Enemy enemy)
    {
        Instantiate(enemy, _parent);
    }

    
}
