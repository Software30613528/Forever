using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushStone : MonoBehaviour {

    // Use this for initialization
    private bool isPlayer1 = true;//角色1的功能键是否被按下
    private bool isPlayer2 = true;//角色2的功能键是否被按下
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (inPlayer1 == true&&inPlayer2==true)
        //{
        //    if (isPlayer1 == true && isPlayer2 == true)
        //    {
        //        /*
        //         * 控制角色1做出推的动作
        //         * 控制角色2做出推的动作
        //         * 石头移动
        //         */
        //        Debug.Log("两个人在做动作");
        //    }
        //    else if (isPlayer1 == true)
        //    {
        //        /*
        //         * 控制角色1产生对话
        //         */
        //        Debug.Log("角色1在做动作");
        //    }
        //    else if (isPlayer2 == true)
        //    {
        //        /*
        //         * 控制角色2产生对话
        //         */
        //        Debug.Log("角色2在做动作");
        //    }
        //}
        //else if (inPlayer1 == true&&isPlayer1==true)
        //{
        //    /*
        //     * 控制角色1产生对话
        //     */
        //    Debug.Log("角色1在做动作");
        //}
        //else if (inPlayer2 == true && isPlayer2 == true)
        //{
        //    /*
        //     * 控制角色2产生对话
        //     */
        //    Debug.Log("角色2在做动作");
        //}
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
     * 获取参数，得知是哪个角色按了功能键，将其标志位取反
     * 如果两个角色都按下了，则发送委托事件，参数列表中传递当前场景编号3
     * }
     */
}
