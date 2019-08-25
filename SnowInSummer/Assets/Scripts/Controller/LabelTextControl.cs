using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabelTextControl : MonoBehaviour
{
    // Start is called before the first frame update
    string[] text = { "前情提要", "前情提要", "第一關 遊戲規則" };

    private int index = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            this.GetComponent<Text>().text = text[index];
            index++;
        }
    }
}
