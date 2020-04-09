using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_character : MonoBehaviour
{
    public float speed = 1f;
 
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
         float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(x,0,z);

    }

}
