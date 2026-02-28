using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private int gameOverSceneIndex = 2;

    public int CurrentScore { get; private set; }
    public bool DidWin { get; private set; }

    // Singleton pattern:
    // declare a variable of same type that is static
    public static ScoreManager Instance { get; private set; }


    private void Awake()
    {
        // Check if there is already an Instance
        if (Instance != null)
        {
            // IF there is already an existing, destroy self
            // Isa lang pwede, wag nang ipagsisikan ang sarili. 
            Destroy(this.gameObject);
            return;
        }
        else
        {
            // assign self as the instance
            Instance = this;
            // make sure this gameobject (which is the instance) doesnt get destroyed when loading a level
            DontDestroyOnLoad(this.gameObject);
        }

    }

    public void AddScore(int scorePoints)
    {
        CurrentScore += scorePoints;
    }

    public void ResetScore()
    {
        CurrentScore = 0;
    }

    public void SetWinState(bool didWin)
    {
        DidWin = didWin;
        SceneManager.LoadScene(gameOverSceneIndex);
    }
}
