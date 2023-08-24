using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("StageOne");//ボタンクリックで1Stageに移動
    }
}
