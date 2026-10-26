using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    public ItemData[] items;
    public TMP_Text[] titles;
    public Image[] icons;

    void Start()
    {
        for (int i = 0; i < items.Length; i++)
        {
            titles[i].text = items[i].title;
            icons[i].sprite = items[i].icon;
        }
    }
}