using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject laser;
    public GameObject spawnPoint;

    public float speed = 12;
    public float bounds = 11;

    private Transform myTransform;

    private Vector3 playerPosition;

    void Start()
    {
        myTransform = transform;
        playerPosition = myTransform.position;
    }

    void Update()
    {
        PlayerMovement();
        myTransform.position = playerPosition;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootLaser();
        }
    }

    void PlayerMovement()
    {
        playerPosition.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        //playerPosition.x = Mathf.Clamp(playerPosition.x, -bounds, bounds);
        playerPosition.x = MyMathf.ClampValue(playerPosition.x, -bounds, bounds);
    }

    void ShootLaser()
    {
        Instantiate(laser, spawnPoint.transform.position, spawnPoint.transform.rotation);
        
        //GameObject laserClone = Instantiate(laser, transform.position + Vector3.up, transform.rotation);
        //laserClone.GetComponent<Rigidbody>().velocity = Vector3.up * 10f;
    }
}

