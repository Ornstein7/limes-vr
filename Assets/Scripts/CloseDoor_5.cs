using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor_5 : MonoBehaviour
{
    public Animator anim;
    public Transform player;
    public Transform door;

    void Update()
    {
        float distance = Vector3.Distance(player.position, door.position);

        if (distance > 5)
        {
            anim.SetBool("Not_near_5", true);
        }

        else
        {
            anim.SetBool("Not_near_5", false);
        }
    }
}
