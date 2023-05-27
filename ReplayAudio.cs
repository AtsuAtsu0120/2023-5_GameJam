using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;
using TMPro;

public class ReplayAudio : MonoBehaviour
{
    [SerializeField] CharacterController2D player;
    [SerializeField] AudioSource source;
    [SerializeField] Transform start;
    [SerializeField] TextMeshProUGUI text;

    public List<ReplayData> list = new List<ReplayData>();

    public async void OnStartReplay() 
    {
        source.time = 0.1f;
        await StartReplay();
    }
    public async UniTask StartReplay() {
        list.Add(new ReplayData(0.0f, 0));
        list.RemoveAt(0);
        int i = 0;
        foreach(var data in list)
        {
            source.pitch = data.pitch;
            if(i == list.Count - 2) {
                break;
                Debug.Log("a");
            }
            float waitMiliseconds = 0.0f;
            waitMiliseconds = (list[i + 1].time - list[i].time) * 1000;
            Debug.Log(waitMiliseconds + ":" + i);
            await UniTask.Delay((int)waitMiliseconds);
            i++; 
        }
        text.text = "Good luck!";
        await UniTask.Delay(5000);
        SceneManager.LoadScene("Title");
    }
    public void ResetAll() {
        player.transform.position = start.position;
        source.time = 0.1f;
    }
}
public class ReplayData {
    public ReplayData(float time, int pitch) {
        this.time = time;
        this.pitch = pitch;
    }

    public float time;
    public int pitch;
}
