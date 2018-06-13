using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope : MonoBehaviour {

    // Use this for initialization
    private bool hasPeople = false;//标志位，用于判断是否有人抓住绳子
    private GameObject otherObject;//用于存储抓住绳子的角色
    Rigidbody rigi;//自身的刚体
    HingeJoint joint;//自身的铰链
    public float halfDegree;
	void Start () {
        rigi = GetComponent<Rigidbody>();
        joint = GetComponent<HingeJoint>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)&&hasPeople==true)
        {
            Rigidbody otherrigi = otherObject.GetComponent<Rigidbody>();
            otherrigi.useGravity = true;//对人物角色添加重力
            /* 判断绳子当前的摆动角度，根据摆动的角度在松手的时候对人物加不同方向的水平力*/
            if (joint.angle > halfDegree)
            {
                otherrigi.AddForce(Vector3.right, ForceMode.Impulse);
            }
            else
            {
                otherrigi.AddForce(Vector3.left, ForceMode.Impulse);
            }
            this.transform.DetachChildren();//解除绳子和角色的父子关系
            hasPeople = false;//表明人脱离了绳子
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer==9)
        {
            otherObject = other.gameObject;
            other.gameObject.transform.parent = this.transform;//将人物设置为绳子的子组件
            rigi.AddForce(Vector3.right, ForceMode.Impulse);//对绳子添加一个水平力使其摆动
            hasPeople = true;//表明当前有人抓住了绳子
        }
        
    }
}
