using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 targetPosition;
    private float totalTravelTime;
    private float elapsedTime = 0f;

    public void SetTarget(Vector3 targetPos, float travelTime)
    {
        this.startPosition = transform.position;
        this.targetPosition = targetPos;
        this.totalTravelTime = travelTime;
    }

    void Update()
    {
        if (totalTravelTime <= 0) return;

        elapsedTime += Time.deltaTime;
        float journeyFraction = elapsedTime / totalTravelTime;
        transform.position = Vector3.Lerp(startPosition, targetPosition, journeyFraction);

        if (journeyFraction >= 1.0f)
        {
            Destroy(gameObject);
        }
    }
}
