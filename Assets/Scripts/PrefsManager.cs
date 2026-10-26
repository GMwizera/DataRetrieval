using UnityEngine;
using TMPro;

public class PrefsManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_Text nameText, scoreText, timeText, statusText;

    int score;
    float playTime;

    void Start() => LoadData();

    void Update()
    {
        playTime += Time.deltaTime;
        timeText.text = "Play time: " + playTime.ToString("F1") + "s";
    }

    public void AddScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("PlayerName", nameInput.text);
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetFloat("PlayTime", playTime);
        PlayerPrefs.Save();
        nameText.text = "Name: " + nameInput.text;
        statusText.text = "Saved";
    }

    public void LoadData()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Guest");
        nameText.text = "Name: " + playerName;
        nameInput.text = playerName;
        score = PlayerPrefs.GetInt("Score", 0);
        playTime = PlayerPrefs.GetFloat("PlayTime", 0f);
        scoreText.text = "Score: " + score;
        statusText.text = "Loaded";
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        score = 0;
        playTime = 0;
        LoadData();
    }

    void OnApplicationQuit() => SaveData();
}