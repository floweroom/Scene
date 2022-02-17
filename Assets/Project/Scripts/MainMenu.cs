using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Settings;
    public InputField input;
    public string PlayerName;
    public AudioMixer Mixer;
    public float Valum;
    public Slider VolSlider;

    // Start is called before the first frame update
    void Start()
    {
        ShowMenu(true);
        if (PlayerPrefs.HasKey("PlayerName"))
            {
            input.text = PlayerPrefs.GetString("PlayerName");
        }
        if (PlayerPrefs.HasKey("PlayerVolume"))
            {
            VolSlider.value = PlayerPrefs.GetFloat("PlayerVolume");
        }
        SetValum(VolSlider.value);
    }
    public void ShowMenu(bool var)
    {
        Menu.SetActive(var);
        Settings.SetActive(!var);
        if (!var)
        {
            PlayerPrefs.Save();
        }
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }
    public void GetText()
    {
        PlayerName = input.text;
        PlayerPrefs.SetString("PlayerName", PlayerName);

    }
    public void SetValum(float valum)
        {
        Valum = valum;
        Mixer.SetFloat("PlayerVolum", Valum);
        PlayerPrefs.SetFloat("PlayerVolum", Valum);

        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
