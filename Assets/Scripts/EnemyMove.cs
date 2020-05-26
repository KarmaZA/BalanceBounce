
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform enemy;
    public Rigidbody rb;
    public float xRand =  150f;
    public float BounceForce = 3;
    public float zRand = 150f;
    // Start is called before the first frame update
    void Start()
    {
        xRand = Random.Range(200f, 100f);
        zRand = Random.Range(200f, 100f);
        rb.AddForce(xRand, 0, zRand);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (enemy.position.x >= 7 || enemy.position.x <= -7)
        {
            rb.velocity = new Vector3(-(xRand * BounceForce) * Time.deltaTime, 0-rb.velocity.y * Time.deltaTime, (zRand * BounceForce) * Time.deltaTime);
            xRand *= -1;
        }
        if (enemy.position.z >= 7 || enemy.position.z <= -7)
        {
            rb.velocity = new Vector3((xRand * BounceForce) * Time.deltaTime, -rb.velocity.y * Time.deltaTime, (-zRand * BounceForce) * Time.deltaTime);
            zRand *= -1;
        }
    }
}
