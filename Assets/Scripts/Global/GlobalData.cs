using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData : MonoBehaviour
{

    public static int[] hetu = new int[10];//全局变量，用于存储九宫格每个格子的状态
    // Use this for initialization
    void Start()
    {
        hetu[0] = 1;
        for (int i = 1; i < 10; i++)
        {
            hetu[i] = 0;//初始化每个格子的状态
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
