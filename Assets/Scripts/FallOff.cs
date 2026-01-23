using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallOff : MonoBehaviour
{
    [SerializeField] GameObject playerControl;
    [SerializeField] AudioSource levelJingle;
    [SerializeField] GameObject levelBGM;
    [SerializeField] GameObject fadeOut;

    void OnTriggerEnter(Collider other)
    {
        playerControl.GetComponent<Animator>().Play("Falling");
        levelBGM.SetActive(false);
        levelJingle.Play();
        fadeOut.SetActive(true);
        StartCoroutine(Respawn());
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(3);
    }
}
