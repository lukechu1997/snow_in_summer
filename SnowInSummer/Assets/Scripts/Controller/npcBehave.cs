using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcBehave : MonoBehaviour
{
    public GameObject MainCharater;

    private Vector2 p1Pos;

    private Vector2 npcPos;

    private bool isCollider;

    private float speed = 1;

    public Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        //speed = Random.Range(0.3f, 1);
    }

    // Update is called once per frame
    void Update()
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

        //Debug.Log();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }
}
