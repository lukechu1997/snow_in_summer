using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{

    public Collider2D Collider2D;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(0, 9);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
