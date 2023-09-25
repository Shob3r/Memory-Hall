using UnityEngine;

public class MusicSwitcher : MonoBehaviour
{
    public AudioClip[] Music;
    public AudioSource PlaySource;
    public GameObject MusicChangerUI, GameUI;
    private void Start()
    {
        PlaySource = GetComponent<AudioSource>();
    }
    public void SetMusic_HigherThanTheSky()
    {
        if(PlaySource.mute == true)
        {
            PlaySource.mute = false;
        }
        PlaySource.clip = Music[0];
        HideMusicSelectGUI();
        PlaySource.Play();
    }

    public void SetMusic_FujiyuNoNaka()
    {
        if (PlaySource.mute == true)
        {
            PlaySource.mute = false;
        }
        PlaySource.clip = Music[1];
        HideMusicSelectGUI();
        PlaySource.Play();
    }

    public void SetMusic_IllBeYourBell()
    {
        if (PlaySource.mute == true)
        {
            PlaySource.mute = false;
        }
        PlaySource.clip = Music[2];
        HideMusicSelectGUI();
        PlaySource.Play();
    }

    public void SetMusic_CityOfLove()
    {
        if (PlaySource.mute == true)
        {
            PlaySource.mute = false;
        }
        PlaySource.clip = Music[3];
        HideMusicSelectGUI();
        PlaySource.Play();
    }

    public void HideMusicSelectGUI()
    {
        MusicChangerUI.SetActive(false);
        GameUI.SetActive(true);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void MuteMusic()
    {
        bool Unmute = false;
        if (Unmute == true)
        {
            PlaySource.mute = false;
            Unmute = false;
            HideMusicSelectGUI();
            return;
        }
        else
        {
            PlaySource.mute = true;
            Unmute = true;
            HideMusicSelectGUI();
            return;
        }
    }
}
