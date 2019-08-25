using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextControl : MonoBehaviour
{
    // Start is called before the first frame update

    string[] text = { "1", "2", "3" };

    private int index = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (index < text.Length)
            {
                this.GetComponent<Text>().text = text[index];
                index++;
            }
            else
            {
                SceneManager.LoadScene("Stage1");
            }
        }
    }
}
