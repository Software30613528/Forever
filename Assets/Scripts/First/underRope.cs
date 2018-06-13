using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class underRope : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        /*
         * 新声明一个委托，该委托的处理事件是处理人物动作
         */
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "player1")
        {
            //inPlayer1 = true;
            /*
             * 注册角色1委托事件，当按下角色1功能键触发事件             * 
             */
        }
        else if (other.gameObject.name == "player2")
        {
            //inPlayer2 = true;
            /*
             * 注册角色2委托事件，当按下角色2功能键触发事件
             */
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "player1")
        {
            //inPlayer1 = false;
            /*
             * 注销角色1委托事件
             */
        }
        else if (other.gameObject.name == "player2")
        {
            //inPlayer2 = false;
            /*
             * 注销角色2委托事件
             */
        }
    }

    /*
     * 委托事件处理函数
     * {
     * 发送委托自身声明的委托，参数中需要传递当前的场景编号（4）
     * }
     */

    private void OnDisable()
    {
        /*
         * 销毁声明的委托
         */
    }
}
