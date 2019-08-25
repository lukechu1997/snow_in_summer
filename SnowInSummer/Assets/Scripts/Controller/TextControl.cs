using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextControl : MonoBehaviour
{
    // Start is called before the first frame update

    string[] text = { "經過了第一次的抗爭，人民們並未獲得滿意的結果，打算再發起一次更大規模的遊行，但政府已經有警戒心，瑜是一切傳達消息的行動都，必續偷偷進行......",
        "一、玩家作為遊行召集人，必須在街道巷弄間將休息散播出去，通知人民預備進行抗爭遊行，但過程不能被警察發現，若進入警察的守備區域會遭到拘捕，意即任務失敗(關卡結束)。\n\n二、在遊戲時間(1分鐘)內傳達到的人數會成為第三關進行抗爭時的籌碼。"};

    string[] label = { "前情提要", "第一關 遊戲規則" };

    private int index = 0;

    public GameObject Label;

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
                Label.GetComponent<Text>().text = label[index];
                index++;
            }
            else
            {
                SceneManager.LoadScene("Stage1");
            }
        }
    }
}
