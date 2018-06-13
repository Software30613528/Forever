using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hetu : MonoBehaviour
{

    public float durning;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }





    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("in" + int.Parse(gameObject.name));
        if(collision.gameObject.layer==9)//判断是否是玩家碰撞
        {
            if (GlobalData.hetu[int.Parse(gameObject.name) - 1] == 1)//判断前一个格子是否有人踩住
            {
                GlobalData.hetu[int.Parse(gameObject.name)] = 1;//设置当前格子的状态
            }

            if (this.transform.position.y > -.1 && GlobalData.hetu[int.Parse(gameObject.name) - 1] == 1)
            {
                this.transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * durning);//将当前格子下移
            }
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == 9)
        {
            GlobalData.hetu[int.Parse(gameObject.name)] = 0;//当人物离开后，设置当前格子状态是没有人踩住
            Debug.Log("out" + int.Parse(gameObject.name));
        }
        
    }
}
