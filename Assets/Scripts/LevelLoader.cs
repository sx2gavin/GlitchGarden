using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private int waitSeconds = 3;

    private int currentSceneIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        StartCoroutine(LoadNextSceneWithDelay());
    }

    private IEnumerator LoadNextSceneWithDelay()
    {
        yield return new WaitForSeconds(waitSeconds);
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
