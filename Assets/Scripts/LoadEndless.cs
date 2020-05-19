using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadEndless : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(LoadEndlessMode);
    }

    public void LoadEndlessMode()
    {
        SceneManager.LoadScene(1);
    }
}
