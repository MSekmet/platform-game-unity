using UnityEngine;

public class LevelFinish : MonoBehaviour
{
    [SerializeField] GameObject playerControl;
    [SerializeField] AudioSource levelJingle;
    [SerializeField] GameObject levelBGM;
    [SerializeField] GameObject fadeOut;

    void OnTriggerEnter(Collider other)
    {
        playerControl.GetComponent<PlayerControls>().enabled = false;
        playerControl.GetComponent<Animator>().Play("Bboy Hip Hop Move");
        levelBGM.SetActive(false);
        levelJingle.Play();
        fadeOut.SetActive(true);
    }
}
