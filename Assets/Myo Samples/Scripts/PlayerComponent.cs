using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerComponent : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    //private Rigidbody rigib;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
  
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);


    }
    //trying to make the walls colide with the ball
    // void onCollisionEnter(Collider col)
    //  {
    //      if (col.gameObject.CompareTag("Wall"))
    //      {
    //          col.gameObject.SetActive(true);
    //      }
    //  }

    void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);
        if (other.gameObject.CompareTag("pickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 5;
            SetCountText();
        }

    }

   /* void OnCollisionEnter(Collider col)
    {
        //Destroy(other.gameObject);
        if(col.gameObject.CompareTag("wall"))
        {
            col.gameObject.SetActive(true);
            
        }*/
    
  //  }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 110)
        {
            winText.text = "You Win!!!!";
        }
    }
}
