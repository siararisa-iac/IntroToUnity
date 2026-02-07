using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    private int targetBuildIndex;

    public void LoadScene()
    {
        SceneManager.LoadScene(targetBuildIndex);
    }

    public void LoadSceneAtIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
}
