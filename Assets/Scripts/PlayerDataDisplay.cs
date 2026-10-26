using UnityEngine;
using TMPro;

public class PlayerDataDisplay : MonoBehaviour
{
    public PlayerData data;
    public TMP_Text nameText, levelText, speedText;
    public Transform cube;

    void Start()
    {
        nameText.text = "Name: " + data.playerName;
        nameText.color = data.themeColor;
        levelText.text = "Level: " + data.level;
        speedText.text = "Speed: " + data.speed;
    }

    void Update()
    {
        cube.Rotate(0, data.speed * Time.deltaTime, 0); // float drives behaviour
    }
}