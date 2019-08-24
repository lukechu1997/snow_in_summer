using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcBehave : MonoBehaviour
{
    public Vector2 p1Pos;

    public Vector2 npcPos;

    public float speed = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get object position
        p1Pos = GameObject.FindWithTag("Player").transform.position;
        npcPos = GameObject.FindWithTag("npc").transform.position;

        float moveY = 0;//上下移动的速度         
        float moveX = 0;//左右移动的速度 

        Vector2 vector = Vector3.Normalize(new Vector2(p1Pos.x - npcPos.x, p1Pos.y - npcPos.y));

        moveX += speed * Time.deltaTime * vector.x;
        moveY += speed * Time.deltaTime * vector.y;

        this.transform.Translate(moveX, moveY, 0);


        //Debug.Log();
    }
}
