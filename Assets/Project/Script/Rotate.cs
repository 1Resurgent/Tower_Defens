using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float speedRotate = 0.3f;


    void Update()
    {
        transform.Rotate(0, speedRotate, 0);
    }
}
