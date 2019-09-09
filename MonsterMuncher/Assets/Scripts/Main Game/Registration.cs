using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;
    public Button submitButton;
    [Header ("Login Field")]
    public InputField inputUser;
    public InputField inputPassword;
    [Header ("Create Field")]
    //public UsernameObj username;
    public ScoreObj score;



    //private string regUserURL = "http://localhost/monstermuncher/registerUser.php";
    private string regUserURL = "https://monstermuncher.000webhostapp.com/registerUser.php";
    //private string loginUserURL = "http://localhost/monstermuncher/loginUser.php";
    private string loginUserURL = "https://monstermuncher.000webhostapp.com/loginUser.php";
    //Unity's inbuilt class to communicate and give information url's

    public void CallRegister()
    {
        StartCoroutine(Register(nameField.text, passwordField.text));
    }
    public void CallLogin()
    {
        StartCoroutine(Login(nameField.text, passwordField.text));
    }

    public IEnumerator Register(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("password", password);
        
        WWW www = new WWW(regUserURL, form);
        yield return www;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        Debug.Log("Registration Successful");

        
        //Debug.Log(www.text);

    }
    public void Login()
    {
        if (inputUser.text != "" && inputPassword.text != "")
        {
            StartCoroutine(Login(inputUser.text, inputPassword.text));
            Debug.LogWarning("Started DBLogin");

            score.userName = inputUser.text;
            Debug.LogWarning("Username Stored");
        }
    }
    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("playerUsername", username);
        form.AddField("playerPassword", password);
        
        WWW dbLink = new WWW(loginUserURL, form);
        yield return dbLink;
        
        Debug.Log(dbLink.text);
        if (dbLink.text == "Login Success")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(4);
        }
        else if (dbLink.text == "User Not Found")
        {
            Debug.Log("User Does Not Exist");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            
            yield return null;
        }
        else if (dbLink.text == "Password is Wrong")
        {
            Debug.Log("Password is Incorrect");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            yield return null;
        } 

        //UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        //Debug.Log("Login Successful");
        //Debug.Log(www.text);
    }
    public void VerifyInputs()
    {
        //This is to make it so if the input conditions are not met, the button will not be interactable
        submitButton.interactable = (nameField.text.Length >= 4 && passwordField.text.Length >= 4);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
