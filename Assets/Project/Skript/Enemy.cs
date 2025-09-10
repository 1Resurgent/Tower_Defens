using Project.Settings;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private MobSetting _setting;

    private void Update()
    {
        transform.Translate(0,0, _setting.Speed * Time.deltaTime);

        Destroy(gameObject,20f);
    }
}
