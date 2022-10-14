using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillbar : MonoBehaviour
{
    public float skillMeter = 80.0f;
    public float skillPoints = 100.0f;
    public Image skillPoint;
    public GameObject BulletPrefab;//子弹预制体
    public GameObject Bullets;//子弹物体集
    public Camera PlayerCamera;//玩家摄像头
    public GameObject player;
    public int BulletSpeed = 8;//子弹速度
    private int index = 0;//子弹计数
    public void Harm()
    {
        skillMeter += -5;
        Amount();

        Debug.Log("技能-5");
    }
    public void Amount()
    {
        skillPoint.fillAmount = skillMeter / skillPoints;
    }
    public void Fire()
    {
        Harm();
        index++;//子弹计数
        GameObject BulletGameObject = Instantiate(BulletPrefab);//加载预制体
        BulletGameObject.name = "Bullet";
        BulletGameObject.transform.localPosition = player.transform.position;//在指定坐标生成子弹
        BulletGameObject.transform.rotation = player.transform.rotation;
        //Bullets.transform.DetachChildren();//解除父子关系
        Destroy(BulletGameObject, 2);//销毁子弹物体
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

