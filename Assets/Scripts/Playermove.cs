using UnityEngine;

public class Playermove : MonoBehaviour
{
    public Rigidbody rb;
    public float SideForce = 0.1f;
    public Transform player;

    private bool InJump = false;
    // Update is called once per frame
    void FixedUpdate() //Fixed for Physics sutff
    {
               //WASD Movement
        if (Input.GetKey("d"))
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //(x,y,z, forcoemode)
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, SideForce * Time.deltaTime, ForceMode.VelocityChange); //(x,y,z, forcoemode)
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -SideForce * Time.deltaTime, ForceMode.VelocityChange);
        }


        if ((Input.GetKey(KeyCode.Space)) & (InJump == false))
        {
            rb.AddForce(0, SideForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            InJump = true;
        }

        if (player.position.y <= 2) //Player will techinically never have to hit the ground
        {
            InJump = false;
        }



        /*if (rb.position.y < -5)
        {
            FindObjectOfType<GameManager>().EndGame();
        }*/

    }
}
