using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadingModule : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}