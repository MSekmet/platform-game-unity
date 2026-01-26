using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeLevel : MonoBehaviour
{
    [SerializeField] GameObject timeBox;
    [SerializeField] int timeLeft = 60;
    [SerializeField] bool takingSeconds = false;
    [SerializeField] bool isRespawning = false;
    [SerializeField] AudioSource timeUpSound;
    [SerializeField] GameObject levelBGM;
    [SerializeField] GameObject fadeOut;
    [SerializeField] GameObject timeUp;
    [SerializeField] GameObject playerControl;

    void Update()
    {
        timeBox.GetComponent<TMPro.TMP_Text>().text = "TIME LEFT: " + timeLeft;
        if (takingSeconds == false)
        {
            StartCoroutine(RemoveSecond());
        }
        if (timeLeft == 0 && isRespawning == false)
        {
            isRespawning = true;
            takingSeconds = true;
            levelBGM.SetActive(false);
            timeUpSound.Play();
            fadeOut.SetActive(true);
            timeUp.SetActive(true);
            playerControl.GetComponent<PlayerControls>().enabled = false;
            playerControl.GetComponent<Animator>().Play("Idle");
            StartCoroutine(Respawn());

        }
    }

    IEnumerator RemoveSecond()
    {
        takingSeconds = true;
        yield return new WaitForSeconds(1);
        timeLeft -= 1;
        takingSeconds = false;
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(3);
    }
}
