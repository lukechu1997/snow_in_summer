﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTri : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        if (collision.gameObject.tag == "npc")
        {
            

            //Player.GetComponent<PlayerEvent>().NewInteract(this.transform.parent.gameObject);
        }
    }
}
