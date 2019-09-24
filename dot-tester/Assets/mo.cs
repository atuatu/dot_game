using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos=new Vector2(-30,0);
        Rigidbody2D rigid=this.GetComponent<Rigidbody2D>();
        if(Input.GetKey(KeyCode.LeftArrow)){
            rigid.velocity=pos;
        }
        
    }
}
