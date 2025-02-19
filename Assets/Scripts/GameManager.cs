using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Button startButton; // Butonu Inspector'dan bağlayacağız

    void Start()
    {
        startButton.onClick.AddListener(LoadGameScene);
    }

    void LoadGameScene()
    {
        SceneManager.LoadScene("MainScene"); // GameScene'e geçiş yap
    }
}
