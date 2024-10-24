using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuContrller : MonoBehaviour
{
    [SerializeField] string GameScene = "GameScene";
    [SerializeField] string MainMenu = "MainMenuScene";

    public void StartGame()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(GameScene);
    }
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
    public void GameExit()
    {
        Cursor.visible = true;
        SceneManager.LoadScene(MainMenu);
    }
}
