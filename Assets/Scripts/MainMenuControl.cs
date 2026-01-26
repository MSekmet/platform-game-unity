using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControl : MonoBehaviour
{

    [SerializeField] AudioSource ButtonPress;
    [SerializeField] GameObject fadeOut;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        
        ButtonPress.Play();
        fadeOut.SetActive(true);
        StartCoroutine(PlayTheGame());
    }

    public void QuitGame()
    {
        Application.Quit();
    }


    IEnumerator PlayTheGame()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(4);
    }
}
