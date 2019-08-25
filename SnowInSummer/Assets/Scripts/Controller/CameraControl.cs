using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject MainCharater;

    public GameObject Background;

    private float xMin;

    private float xMax;

    private float yMin;

    private float yMax;

    private Transform CharacterTransform;

    private Vector2 firstPos;//接触时的position 

    private Vector2 twoPos;//移动后的position 

    public float speed = 1.0f;        //移动速度 

    // Start is called before the first frame update
    void Start()
    {
        float widthHalf = 657 / 200;
        float heightHalf = 1034 / 200;

        xMin = Background.transform.position.x - widthHalf;
        xMax = Background.transform.position.x + widthHalf;
        yMin = Background.transform.position.y - heightHalf;
        yMax = Background.transform.position.y + heightHalf;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(MainCharater.transform.position.x);

        if (!(this.transform.position.x <= xMin) || !(this.transform.position.x >= xMax))
        {
            this.transform.position = new Vector3(MainCharater.transform.position.x, this.transform.position.y, this.transform.position.z);
        }

        if (!(this.transform.position.y <= yMin) || !(this.transform.position.y >= yMax))
        {
            this.transform.position = new Vector3(this.transform.position.x, MainCharater.transform.position.y, this.transform.position.z);
        }
    }
}
