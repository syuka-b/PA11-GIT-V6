using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager thisManager = null;
    [SerializeField] private Text Txt_Score = null;
    private int Score = 0;
    private int value;
    // Start is called before the first frame update
    void Start()
    {
        thisManager = this;

    }

    // Update is called once per frame
    void Update()
    {
                Score += value;
        Txt_Score.text = "SCORE : " + Score;
    }
    public void UpdateScore(int value)
    {
        Score += value;
        Txt_Score.text = "SCORE : " + Score;
    }
    public void restarting()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
