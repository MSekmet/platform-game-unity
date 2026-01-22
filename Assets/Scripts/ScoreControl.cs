using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    [SerializeField] GameObject scoreBox;
    public static int totalScore;

    void Update()
    {
        scoreBox.GetComponent<TMPro.TMP_Text>().text = "SCORE: " + totalScore;
    }
}
