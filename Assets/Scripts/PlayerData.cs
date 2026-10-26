using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerData", menuName = "Game/Player Data")]
public class PlayerData : ScriptableObject
{
    public string playerName = "Gisele";
    public int level = 1;
    public float speed = 50f;
    public Color themeColor = Color.cyan;
}