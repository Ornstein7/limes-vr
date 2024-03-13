using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CloseDoor_3 : MonoBehaviour
{
    public Animator anim;
    public Transform player;
    public Transform door;

    // Start is called before the first frame update
    void Update()
    {
        float distance = Vector3.Distance(player.position, door.position);

        if (distance > 5)
        {
            anim.SetBool("Not_near_3", true);
        }

        else
        {
            anim.SetBool("Not_near_3", false);
        }
    }
}
