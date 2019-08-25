using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcTrigger : MonoBehaviour
{
    public GameObject Player { get { return GameObject.Find("Trigger"); } }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject == Player)
        {
            Debug.Log(collision);
            Player.transform.parent.GetComponent<PlayerEvent>().NewInteract(this.transform.parent.gameObject);
            gameObject.active = false;
        }
    }
}
