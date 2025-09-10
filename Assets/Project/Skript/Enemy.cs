using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Speed = 2;

    private void Update()
    {
        transform.Translate(0,0, Speed * Time.deltaTime);

        Destroy(gameObject,20f);
    }
}
