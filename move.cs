using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move: MonoBehaviour
{
    private Transform weizhi;  //�任������ͱ���

    void Start()
    {
        weizhi = gameObject.GetComponent<Transform>();   //��ǰ��Ϸ��������.��ȡTransform�������weizhi��������������
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))  //��ȡ�������룬����ΪW��
        {
            weizhi.Translate(Vector3.forward * 0.1f, Space.World);   //����weizhiʹ��Translate�ƶ���������ǰ�ٶ�֡������0.1��λ��������������ϵ��
        }
        //ͬ��������Ĵ���
        if (Input.GetKey(KeyCode.S))  //��ȡ�������룬����Ϊs��
        {
            weizhi.Translate(Vector3.back * 0.1f, Space.World);   //����weizhiʹ��Translate�ƶ�����������ٶ�֡������0.1��λ��������������ϵ��
        }
        if (Input.GetKey(KeyCode.A))  //��ȡ�������룬����ΪA��
        {
            weizhi.Translate(Vector3.left * 0.1f, Space.World); //����weizhiʹ��Translate�ƶ������������ٶ�֡������0.1��λ��������������ϵ��
        }
        if (Input.GetKey(KeyCode.D))  //��ȡ�������룬����ΪD��
        {
            weizhi.Translate(Vector3.right * 0.1f, Space.World); //����weizhiʹ��Translate�ƶ����������Ҷ�֡������0.1��λ��������������ϵ��
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