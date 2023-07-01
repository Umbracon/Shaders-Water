using UnityEngine;

public class RotatingLights : MonoBehaviour
{
    [SerializeField] float speed;
    
    void Update()
    {
        transform.Rotate(Vector3.up * speed, Space.Self);
    }
}
