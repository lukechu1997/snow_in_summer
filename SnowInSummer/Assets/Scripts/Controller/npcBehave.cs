using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcBehave : MonoBehaviour
{
    public GameObject Player { get { return GameObject.Find("MainCharater"); } }

    public GameObject MainCharater;

    private Vector2 p1Pos;

    private Vector2 npcPos;
    public bool IsFollowing;
    public float speed = 1.0f;

    private bool isCollider;

    public Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFollowing)
        {
            // get object position
            p1Pos = MainCharater.transform.position;
            npcPos = this.transform.position;

            float moveY = 0;//上下移动的速度         
            float moveX = 0;//左右移动的速度 

            Vector2 vector = Vector3.Normalize(new Vector2(p1Pos.x - npcPos.x, p1Pos.y - npcPos.y));

            moveX += speed * Time.deltaTime * vector.x;
            moveY += speed * Time.deltaTime * vector.y;

            this.rigid.AddForce(new Vector2(moveX, moveY) * 80);

        }
    }
    public void Interact()
    {
        Player.GetComponent<PlayerEvent>().AddPeople();
        IsFollowing = true;
    }

}
