using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public CharacterSpawner spawner;
    public GameObject WinGameUI;
    public AudioClip[] backgroundMusic;
    public AudioClip victoryMusic;
    
    public AudioSource audioPlayer;

    void Start()
    {
        int randomIndex = Random.Range(0,backgroundMusic.Length);
        audioPlayer.clip = backgroundMusic[randomIndex];
        audioPlayer.Play();
        spawner.SpawnCharacters();
    }
    public void EndGame()
    {
        audioPlayer.Pause();
        audioPlayer.clip = victoryMusic;
        audioPlayer.Play();
        Time.timeScale = 0;
        WinGameUI.SetActive(true);
    }

    public void RestartGame()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        Time.timeScale = 1;
        SceneManager.LoadScene(currentScene.name);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
