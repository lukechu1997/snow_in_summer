using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, -1);

            if (hit.collider)
            {
                Debug.DrawLine(ray.origin, hit.transform.position, Color.red, 0.1f, true);
                Debug.Log(hit.transform.name);

                SceneManager.LoadScene("TalkingScene");
            }
        }
    }
}
