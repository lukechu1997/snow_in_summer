using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    public GameObject TimerText;
    public GameObject Player { get { return GameObject.Find("MainCharater"); } }
    public GameObject NextLVPanel;

    int Time = 40;
    public Collider2D Collider2D;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(0, 8);
        Invoke("Timer", 1.0f);
    }

    // Update is called once per frame

    void Timer()
    {
        Time--;
        TimerText.GetComponent<Text>().text = Time.ToString();
        if (Time <= 0)
        {
            LevelEnd();
        }
        else
        {
            Invoke("Timer", 1.0f);
        }
    }
    void LevelEnd()
    {
        NextLVPanel.active = true;
    }
    public void OnClickNextLV()
    {
        int SupNum = Player.GetComponent<PlayerEvent>().GetSupNum();
        int ToolNum = Player.GetComponent<PlayerEvent>().GetToolNum();
        PlayerPrefs.SetInt("SupN", SupNum);
        PlayerPrefs.SetInt("ToolN", ToolNum);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);     

    }
    public void LoadLV3()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void LoadLV2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void LoseGame()
    {
        SceneManager.LoadScene("StartScene");
    }
}
