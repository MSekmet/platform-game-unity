using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallA : MonoBehaviour
{
    [SerializeField] GameObject playerControl;
    [SerializeField] GameObject levelBGM;

    void OnTriggerEnter(Collider other)
    {
        playerControl.GetComponent<Animator>().Play("Falling");
        levelBGM.SetActive(false);
    }
}
