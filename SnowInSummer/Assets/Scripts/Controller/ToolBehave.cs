using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolBehave : MonoBehaviour
{
    public GameObject Player { get { return GameObject.Find("MainCharater"); } }
    int Dura = 2;

    public GameObject MainCharater { get { return GameObject.Find("MainCharater"); } }
    private Vector2 p1Pos;

    private Vector2 npcPos;
    public bool IsFollowing;
    public float speed = 0.8f;

    private bool isCollider;

    public Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.3f, 1);
    }

    public void Interact()
    {
        Player.GetComponent<PlayerEvent>().AddTool();
        Dura--;
        if (Dura <= 0)
        {
            Destroy(gameObject);
        }
    }

}
