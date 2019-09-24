using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    //Player_movementをスクリプト参照するための変数
    private Player_movement player_Movement;
    private collider_player collide;
    private bool click = false;
    private bool director = false;
    private bool col = false;
    private Animator anim;

    private void Start()
    {
        player_Movement = FindObjectOfType<Player_movement>();
        anim = GetComponent<Animator>();
        collide = GetComponent<collider_player>();
    }

    private void Update()
    {
        click = player_Movement.click;
        director = player_Movement.direction;
        col = collide.player_stay;
        if (click && director && col) {
             anim.SetBool("open", true);
        }
        
    }
}
