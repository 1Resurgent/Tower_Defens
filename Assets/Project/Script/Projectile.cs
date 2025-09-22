using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 startPosition;
    private Enemy enemy;
    private float totalTravelTime;
    private float elapsedTime = 0f;
    
    [SerializeField]
    private float damage = 5;

    public void SetTarget(Enemy target, float travelTime)
    {
        startPosition = transform.position;
        enemy = target;
        totalTravelTime = travelTime;
    }

    void Update()
    {
        if (totalTravelTime <= 0)
        {
            Destroy(gameObject);
            return;
        }

        elapsedTime += Time.deltaTime;
        float journeyFraction = elapsedTime / totalTravelTime;
        transform.position = Vector3.Lerp(startPosition, enemy.transform.position, journeyFraction);
        if (elapsedTime >= totalTravelTime)
        {
            Destroy(gameObject);
        }
    }
}
