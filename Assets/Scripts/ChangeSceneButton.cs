using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string sceneName; // Название сцены для загрузки

    public void LoadScene()
    {
        Debug.Log("Пытаемся загрузить сцену: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
