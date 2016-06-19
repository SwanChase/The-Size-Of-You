using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void Play() {
        SceneManager.LoadScene("Chase_Scene");
    }
    public void Options() {
        SceneManager.LoadScene("Options");
    }
    public void Exit()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

}
