using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = Vector3.up * speed;
    }
}
