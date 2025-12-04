using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    public TMP_InputField emailInput;
    public TMP_InputField passwordInput;
    public GameObject errorText;   // TMP object for error

    public string correctEmail = "test@gmail.com";
    public string correctPassword = "1234";

    public string sceneToLoad = "SampleScene";

    public void TryLogin()
    {
        if (emailInput.text == correctEmail && passwordInput.text == correctPassword)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            errorText.SetActive(true);
        }
    }
}