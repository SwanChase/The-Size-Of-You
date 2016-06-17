using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class PauseMenu : MonoBehaviour {

    [SerializeField] GameObject panel;
    bool escape;

    void Update()
    {
        PauseGame();
    }

    public void PauseGame()
    {
        
        if (escape = Input.GetKey(KeyCode.Escape))
        {
            panel.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
    public void TogglePause()
    {
        panel.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1.0f;
    }
    public void Quit()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}