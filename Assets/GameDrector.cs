using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDrector : MonoBehaviour
{
    public Text distanceLabel; //距離を表示するUI-Textオブジェクト
    public static float distance; //距離を保存する変数

    public static float lastTime; //残り時間を保存する変数

    public Image TimeGauge; //タイムゲージを表示するUI

    void Start()
    {
        distance = 0;

        lastTime = 100;
    }

    void Update()
    {
        //残り時間を減らす処理
        lastTime -= Time.deltaTime;
        TimeGauge.fillAmount = lastTime / 100f;

        //のこり時間が0になったらリロード
        if (lastTime < 0)
        {
            SceneManager.LoadScene("GameScene");
        }

        //進んだ距離を表示
        distance += 1000 * Time.deltaTime;
        distanceLabel.text += distance + "m";
    }
}
