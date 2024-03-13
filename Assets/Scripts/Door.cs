using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator anim;
    public Transform player;
    public Transform door;

    // Start is called before the first frame update
    void Update()
    {
        float distance = Vector3.Distance(player.position, door.position);

        if (distance <= 5)
        {
            anim.SetBool("Near", true);
        }

        else
        {
            anim.SetBool("Near", false);
        }
    }
}