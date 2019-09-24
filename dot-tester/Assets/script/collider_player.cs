using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider_player : MonoBehaviour
{
    // Start is called before the first frame update
    public bool player_stay =false;
    public int a = 9;
    void Start()
    {
        player_stay = false;
    }


    void OnCollisionStay2D(Collision2D obj){
        if(obj.gameObject.tag == "Player"){
            player_stay = true;
        }
    }

    void OnCollisionExit2D(Collision2D obj){
        if (obj.gameObject.tag == "Player")
        {
            player_stay = false;
        }
    }

}
