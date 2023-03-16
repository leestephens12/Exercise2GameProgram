using System.ComponentModel;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetController : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private float moveSpeed;
    private float moveHorizontal;
    // Start is called before the first frame update
    void Start()
    {
        //uses atatched game object
        rb2D = this.gameObject.GetComponent<Rigidbody2D>();
        moveSpeed = 15f; //move speed of the net
    }
    // Update is called once per frame
    void Update()
    {
        //move the net accross x axis
        moveHorizontal = Input.GetAxisRaw("Horizontal");
    }

    //updates with physics engine(put physics here)
    void FixedUpdate()
    {
        //below 0 moves left, above moves right
        if(moveHorizontal > 0.1f || moveHorizontal < -0.1f) {
            rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f));
        }
        
    }
}
