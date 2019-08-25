using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTrigger : MonoBehaviour
{
    public GameObject Player { get { return GameObject.Find("Trigger"); } }
    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if (collision.gameObject == Player)
        {
            Player.transform.parent.GetComponent<PlayerEvent>().NewTool(this.transform.parent.gameObject);
        }
    }
}
