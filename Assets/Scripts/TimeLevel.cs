using System.Collections;
using UnityEngine;

public class TimeLevel : MonoBehaviour
{
    [SerializeField] GameObject timeBox;
    [SerializeField] public static int timeLeft = 60;
    [SerializeField] bool takingSeconds = false;

    void Update()
    {
        timeBox.GetComponent<TMPro.TMP_Text>().text = "TIME LEFT: " + timeLeft;
        if (takingSeconds == false)
        {
            StartCoroutine(RemoveSecond());
        }
    }

    IEnumerator RemoveSecond()
    {
        takingSeconds = true;
        yield return new WaitForSeconds(1);
        timeLeft -= 1;
        takingSeconds = false;
    }
}
