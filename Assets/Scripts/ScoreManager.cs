using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [HideInInspector] public int Score = 0;

    private Text text = null;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        if (Score >= 10)
        {
            SceneManager.LoadScene("");
            return;
        }
        text.text = Score.ToString() + "/10";
    }
}
