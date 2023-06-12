using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public float speed;
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // int q_times = 0;
        // int e_times = 0;
        // int position = 0;
        // if (Input.GetKeyDown(KeyCode.Q)) {
        //     q_times++;
        // }
        // if (Input.GetKeyDown(KeyCode.E)) {
        //     e_times++;
        // }
        // position =  System.Math.Abs(q_times - e_times);

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if (cam.transform.position.Equals(front.transform.position)) {
            
            moveHorizontal = 0.0f;
            moveVertical = 0.0f;
        
            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");
            movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        }
        
        GetComponent<Rigidbody>().velocity = movement * speed;
    }
}
