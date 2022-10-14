using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillbar : MonoBehaviour
{
    public float skillMeter = 80.0f;
    public float skillPoints = 100.0f;
    public Image skillPoint;
    public GameObject BulletPrefab;//�ӵ�Ԥ����
    public GameObject Bullets;//�ӵ����弯
    public Camera PlayerCamera;//�������ͷ
    public GameObject player;
    public int BulletSpeed = 8;//�ӵ��ٶ�
    private int index = 0;//�ӵ�����
    public void Harm()
    {
        skillMeter += -5;
        Amount();

        Debug.Log("����-5");
    }
    public void Amount()
    {
        skillPoint.fillAmount = skillMeter / skillPoints;
    }
    public void Fire()
    {
        Harm();
        index++;//�ӵ�����
        GameObject BulletGameObject = Instantiate(BulletPrefab);//����Ԥ����
        BulletGameObject.name = "Bullet";
        BulletGameObject.transform.localPosition = player.transform.position;//��ָ�����������ӵ�
        BulletGameObject.transform.rotation = player.transform.rotation;
        //Bullets.transform.DetachChildren();//������ӹ�ϵ
        Destroy(BulletGameObject, 2);//�����ӵ�����
    }
    // Start is called before the first frame update
    void Start()
    {
        Harm();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && skillMeter > 0)
        {
            Fire();
        }
        Amount();
    }
}

