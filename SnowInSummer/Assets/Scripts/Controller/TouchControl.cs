
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    private Vector2 firstPos;//接触时的position 

    private Vector2 twoPos;//移动后的position 

    public float speed = 1.0f;        //移动速度 

    private bool isMouseDown = false;

    private void Start()
    {
    }

    void Update()
    {
#if UNITY_EDITOR
        #region 滑鼠

        if (!isMouseDown)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //获取接触屏幕的坐标 
                firstPos = Input.mousePosition;
                isMouseDown = true;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            //获取在屏幕上移动后的坐标 
            isMouseDown = false;
        }

        float moveY = 0;// 上下移动的速度         
        float moveX = 0;//左右移动的速度 

        //判断移动                 
        if (isMouseDown)
        {
            twoPos = Input.mousePosition;

            Vector2 vector = Vector3.Normalize(new Vector2(twoPos.x - firstPos.x, twoPos.y - firstPos.y));

            if (Camera.main.WorldToScreenPoint(transform.position).x < Screen.width)
            {
                if (vector.x > 0)
                    moveX += speed * Time.deltaTime * vector.x;
            }

            if (Camera.main.WorldToScreenPoint(transform.position).y < Screen.height)
            {
                if (vector.y > 0)
                    moveY += speed * Time.deltaTime * vector.y;
            }

            if (Camera.main.WorldToScreenPoint(transform.position).x > 0)
            {
                if (vector.x < 0)
                    moveX += speed * Time.deltaTime * vector.x;
            }

            if (Camera.main.WorldToScreenPoint(transform.position).y > 0)
            {
                if (vector.y < 0)
                    moveY += speed * Time.deltaTime * vector.y;
            }

            //改变物体坐标 
            this.transform.Translate(moveX, moveY, 0);

            #endregion
#endif
            /*
            #region Android觸摸

            if (Input.touchCount == 0)
                return;

            float moveY = 0;// 上下移动的速度         
            float moveX = 0;//左右移动的速度 

            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                //获取接触屏幕的坐标 
                fristPos = Input.GetTouch(0).position;
            }
            //判断移动                 
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                //获取在屏幕上移动后的坐标 
                twoPos = Input.GetTouch(0).position;
                //判断向上移动,并且不出上方屏幕 
                if (fristPos.y < twoPos.y && Camera.main.WorldToScreenPoint(transform.position).y < Screen.height)
                {
                    moveY += speet * Time.deltaTime;
                }
                //判断向下移动,并且不出下边屏幕 
                if (fristPos.y > twoPos.y && Camera.main.WorldToScreenPoint(transform.position).y > 0)
                {
                    moveY -= speet * Time.deltaTime;
                }
                //判断向左移动,并且不出左边屏幕 
                if (fristPos.x > twoPos.x && Camera.main.WorldToScreenPoint(transform.position).x > 0)
                {
                    moveX -= speet * Time.deltaTime;
                }
                //判断向右移动,并且不出右边屏幕 
                if (fristPos.x < twoPos.x && Camera.main.WorldToScreenPoint(transform.position).x < Screen.width)
                {
                    moveX += speet * 2.0f * Time.deltaTime;
                }
                //改变物体坐标 
                transform.Translate(moveX, moveY, 0);
            }

            #endregion
    */
        }
    }
}
