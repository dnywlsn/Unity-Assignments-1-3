using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerProfile : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_Dropdown colorDropdown;
    public Toggle soundToggle;
    public Toggle musicToggle;

    void Start()
    {
        nameInput.text = PlayerPrefs.GetString("PlayerName", "");
        colorDropdown.value = PlayerPrefs.GetInt("PlayerColor", 0);
        soundToggle.isOn = PlayerPrefs.GetInt("SoundOn", 1) == 1;
        musicToggle.isOn = PlayerPrefs.GetInt("MusicOn", 1) == 1;
    }

    public void SaveProfile()
    {
        PlayerPrefs.SetString("PlayerName", nameInput.text);
        PlayerPrefs.SetInt("PlayerColor", colorDropdown.value);
        PlayerPrefs.SetInt("SoundOn", soundToggle.isOn ? 1 : 0);
        PlayerPrefs.SetInt("MusicOn", musicToggle.isOn ? 1 : 0);
        PlayerPrefs.Save();
        gameObject.transform.parent.gameObject.SetActive(false);
    }
}

