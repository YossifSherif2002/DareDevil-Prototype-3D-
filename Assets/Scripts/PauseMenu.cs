using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pausemenu;
    [SerializeField] private AudioMixer master_mixer;
    [SerializeField] private GameObject playerHUD;
    [SerializeField] private GameObject player;
 

    private bool ispaused;
    private void Start()
    {
        ispaused = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) )
        {
            if (!ispaused)
            {
                Pause();
            }
            else if (ispaused)
            {
                Resume();
            }
        }
    }

    public void Pause()
    {
        pausemenu.SetActive(true);
        playerHUD.SetActive(false);
        ispaused = true;
        Time.timeScale = 0;
        master_mixer.SetFloat("MasterVolume", -80);
    }

    public void Resume()
    {
        pausemenu.SetActive(false);
        playerHUD.SetActive(true);
        ispaused = false;
        Time.timeScale = 1;
        master_mixer.SetFloat("MasterVolume", 0);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        master_mixer.SetFloat("MasterVolume", 0);
    }

    public void Reset()
    {
        SceneManager.LoadScene(1);
    }

    public void DestroyPlayer()
    {
        Destroy(player);
    }
}
