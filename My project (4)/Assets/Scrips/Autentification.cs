using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Auth;
using UnityEngine.UI;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using TMPro;
using UnityEngine.SceneManagement;

public class Autentification : MonoBehaviour
{
    [SerializeField] public TMP_InputField Name, email, password;
    [SerializeField] private ErrorManager errorManager;
    FirebaseAuth au;
    public TMP_Text textinfo;
    // Start is called before the first frame update

    public void Start()
    {
        au = FirebaseAuth.DefaultInstance;
        au.StateChanged += Au_StateChanged;
        Au_StateChanged(this,null);
        au.SignOut();
        textinfo.text = "";
    }

    private void Au_StateChanged(object sender, System.EventArgs e)
    {
        if(au.CurrentUser!=null)
        {
            textinfo.text = "норм";
            SceneManager.LoadScene(0);
        }
        else
        {
            textinfo.text = "неверный логин или пароль";
        }
    }

    public void ButtonLogin()
    {
        au.SignInWithEmailAndPasswordAsync(email.text, password.text);
    }

    public void ButtonRegister()
    {
        au.CreateUserWithEmailAndPasswordAsync(email.text, password.text);
    }
}
