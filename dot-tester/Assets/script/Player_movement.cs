using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_movement : MonoBehaviour
{
    public bool click=false;
    public bool direction = false;
    Rigidbody2D rig;
    int player_speed;
    // Start is called before the first frame update
    void Start()
    {
        player_speed=60;
        rig=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         Rigidbody2D rig=GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){
        Move();
    }

    void Move(){
        if(!Input.anyKey){
            rig.velocity=Vector2.zero;
        }
        if(Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.DownArrow)){UpMove();}
        else if(Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.UpArrow)){DownMove();}
        else if(Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow)){LeftMove();}
        else if(Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.DownArrow)){RightMove();}

        if(Input.GetKeyDown(KeyCode.Space)){
            click=true;
        }
    }

    void UpMove(){
        rig.velocity=new Vector2(0,player_speed);
        direction = true;//正面を見ている
    }
    void DownMove(){
        rig.velocity=new Vector2(0,-player_speed);
        direction = false;//正面を見ていない
    }
    void LeftMove(){
        rig.velocity=new Vector2(-player_speed,0);
        direction = false;//正面を見ていない
    }
    void RightMove(){
            rig.velocity=new Vector2(player_speed,0);
            direction = false;//正面を見ていない
    }
}
