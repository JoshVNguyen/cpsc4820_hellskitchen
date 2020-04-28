using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int enemies;
    public GameObject player;
    public Text timerLabel;
    public Text messageText;
    private bool victory;

    public float time;

    void Start() {
        Invoke("HideMessage", 5f);
        victory = false;
    }

    void Update() {
        time -= Time.deltaTime;

        float minutes = Mathf.Floor(time / 60f);
        float seconds = time % 60f;
        float fraction = (time * 100f) % 100f;

        timerLabel.text = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);

        if (enemies <= 0)
        {
            victory = true;
            VictoryMessage();
        }
        if ((time <= 0 && victory != true) || !(player.activeSelf))
        {
            DefeatMessage();
        }

    }

    public void removeEnemy(){
        enemies -= 1;
    }

    void HideMessage(){
        messageText.text = " ";
    }

    void DefeatMessage(){
        messageText.text = "GAME OVER";
    }

    void VictoryMessage(){
        messageText.text = "YOU WIN!";
    }
}
