using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifebar : MonoBehaviour
{
    public GameObject player;
    public float healthMeter = 80.0f;
    public float HealthPoints = 100.0f;
    public Image healthPoint;
    public void Harm()
    {
        healthMeter += -5;
        Amount();

        Debug.Log("¿ÛÑª-5");
    }
    public void Amount()
    {
        healthPoint.fillAmount = healthMeter / HealthPoints;
    }
    // Start is called before the first frame update
    void Start()
    {
        Harm();
    }

    // Update is called once per frame
    void Update()
    {
        Amount();
        if (player.transform.position.y < -10)
            healthMeter = 0;//µôÏÂÐüÑÂ
    }
}
