using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move: MonoBehaviour
{
    private Transform weizhi;  //变换组件类型变量

    void Start()
    {
        weizhi = gameObject.GetComponent<Transform>();   //当前游戏物体身上.获取Transform组件并用weizhi来保存它的引用
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))  //获取键盘输入，键码为W键
        {
            weizhi.Translate(Vector3.forward * 0.1f, Space.World);   //引用weizhi使用Translate移动（方向向前速度帧数乘以0.1，位置沿着世界坐标系）
        }
        //同理复制上面的代码
        if (Input.GetKey(KeyCode.S))  //获取键盘输入，键码为s键
        {
            weizhi.Translate(Vector3.back * 0.1f, Space.World);   //引用weizhi使用Translate移动（方向向后速度帧数乘以0.1，位置沿着世界坐标系）
        }
        if (Input.GetKey(KeyCode.A))  //获取键盘输入，键码为A键
        {
            weizhi.Translate(Vector3.left * 0.1f, Space.World); //引用weizhi使用Translate移动（方向向左速度帧数乘以0.1，位置沿着世界坐标系）
        }
        if (Input.GetKey(KeyCode.D))  //获取键盘输入，键码为D键
        {
            weizhi.Translate(Vector3.right * 0.1f, Space.World); //引用weizhi使用Translate移动（方向向右度帧数乘以0.1，位置沿着世界坐标系）
        }
        if (Input.GetKey(KeyCode.Q))
        {
            weizhi.Rotate(Vector3.up * 0.1f, Space.World);
        }
        if (Input.GetKey(KeyCode.E))
        {
            weizhi.Rotate(Vector3.down * 0.1f, Space.World);
        }
    }
}