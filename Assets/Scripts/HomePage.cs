using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePage : MonoBehaviour
{
    public void OnBackButtonClicked()
    {
        Debug.Log("Back button clicked, loading MainMenu...");
        SceneLoader.Instance.LoadScene("MainMenu");  // This will call the LoadScene method of SceneLoader.
    }
}