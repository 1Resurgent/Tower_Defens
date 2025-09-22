using UnityEngine;

public class TowerController : MonoBehaviour
{

    public GameObject projectilePrefab;
    public Transform wallTarget;
    public float timeToReachTarget = 2.0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {

        GameObject bullet = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Projectile projectileScript = bullet.GetComponent<Projectile>();

        if (projectileScript != null)
        {
            projectileScript.SetTarget(wallTarget.position, timeToReachTarget);
        }

    }
}