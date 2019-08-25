using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class PlayerEvent : MonoBehaviour
{
    private Ray ray;
    public RaycastHit hitinfo;
    public GameObject Interaction;
    public GameObject ToolInter;
    public int SupNum;
    public int ToolNum;
    public GameObject SupText;
    public GameObject ToolText;
    public GameObject LoseGamePanel;

    // Start is called before the first frame update
    void Start()
    {
        SupNum = 0;
        ToolNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0) && Physics2D.Raycast(ray.origin, ray.direction, 10, -1))
        {
            if (Interaction != null)
            {                
                Interaction.GetComponent<npcBehave>().Interact();
            }
            if (ToolInter != null)
            {
                ToolInter.GetComponent<ToolBehave>().Interact();
            }
        }
    }
    public void NewInteract(GameObject NewInter)
    {

        Interaction = NewInter;
    }
    public void NewTool(GameObject NewInter)
    {

        ToolInter = NewInter;
    }
    public void AddPeople()
    {
        Interaction = null;
        SupNum += 10;
        SupText.GetComponent<Text>().text = SupNum.ToString();
    }
    public void AddTool()
    {
        ToolNum ++;
        ToolText.GetComponent<Text>().text = ToolNum.ToString();
    }
    public void MeetEnemy()
    {
        if (ToolNum >= 10)
        {
            ToolNum-=10;
        }
        else
        {
            SubPeople();
        }
    }
    public void SubPeople()
    {
        SupNum -= 15;
        CheckLose();
        SupText.GetComponent<Text>().text = SupNum.ToString();
    }
    public void SubTool()
    {
        ToolNum --;
        ToolText.GetComponent<Text>().text = ToolNum.ToString();
    }
    public int GetSupNum()
    {
        return SupNum;
    }
    public int GetToolNum()
    {
        return ToolNum;
    }
    void CheckLose()
    {
        if (SupNum < 0)
        {
            LoseGamePanel.active = true;
        }
    }
}
