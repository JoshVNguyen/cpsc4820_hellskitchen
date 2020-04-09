using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_character : MonoBehaviour
{
    public float speed = 1f;
 
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;

        Vector3 move = new Vector3(x, 0.0f, z);
        
        // Rotate player smoothly in the direction they're facing
        if(move != Vector3.zero){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(move.normalized), 0.2f);
        }
        
        transform.Translate(move, Space.World);
    }

}
