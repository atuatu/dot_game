using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_animation : MonoBehaviour
{
    void FixedUpdate()
    {
        Animator ani=GetComponent<Animator>();

        //上
       if(Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.DownArrow)){
            ani.SetBool("stop",true);
            ani.SetFloat("tree",0.3f);
        }
        //下
        else if(Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.UpArrow)){
            ani.SetBool("stop",true);
            ani.SetFloat("tree",0f);
        }
        //左
        else if(Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow)){
            ani.SetBool("stop",true);
            ani.SetFloat("tree",0.1f);
        }
        //右
        else if(Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.DownArrow)){
            ani.SetBool("stop",true);
            ani.SetFloat("tree",0.2f);
        }
        else if(!Input.anyKey) {
            ani.SetBool("stop",false);
        }
    }
}
