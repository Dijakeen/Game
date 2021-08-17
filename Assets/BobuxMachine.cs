using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class BobuxMachine : MonoBehaviour
{
    private Text text
    {
        get
        {
            return GetComponent<Text>();
        }
    }
    int coins;
    public float timer = 2f;
    float tmp;

    private void Awake()
    {
        tmp = timer;
    }

    private void Update()
    {
        if(tmp <= 0)
        {
            GetCoin();
            tmp = timer;
        }
        tmp -= Time.deltaTime;
    }

    void GetCoin()
    {
        coins += 1;
        text.text = coins.ToString();
    }
}
