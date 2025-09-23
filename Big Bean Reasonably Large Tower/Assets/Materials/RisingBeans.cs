using UnityEngine;

public class RiseObject : MonoBehaviour
{
    public float riseSpeed = 1f; // Speed at which the object rises

    void Update()
    {
        // Move the object upwards along the Y-axis
        transform.Translate(Vector3.up * riseSpeed * Time.deltaTime);
    }
}