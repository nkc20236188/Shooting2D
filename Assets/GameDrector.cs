using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDrector : MonoBehaviour
{
    public Text distanceLabel; //������\������UI-Text�I�u�W�F�N�g
    public static float distance; //������ۑ�����ϐ�

    public static float lastTime; //�c�莞�Ԃ�ۑ�����ϐ�

    public Image TimeGauge; //�^�C���Q�[�W��\������UI

    void Start()
    {
        distance = 0;

        lastTime = 100;
    }

    void Update()
    {
        //�c�莞�Ԃ����炷����
        lastTime -= Time.deltaTime;
        TimeGauge.fillAmount = lastTime / 100f;

        //�̂��莞�Ԃ�0�ɂȂ����烊���[�h
        if (lastTime < 0)
        {
            SceneManager.LoadScene("GameScene");
        }

        //�i�񂾋�����\��
        distance += 1000 * Time.deltaTime;
        distanceLabel.text += distance + "m";
    }
}
