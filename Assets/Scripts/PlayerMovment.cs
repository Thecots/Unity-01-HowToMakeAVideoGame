using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;
    public float fordwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, fordwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("f"))
        {
            rb.AddForce(0, 50 * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("i"))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionY;
        }
        

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EngGame();
        }
    }
}
