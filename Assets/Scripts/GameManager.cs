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

        var minutes = time / 60;
        var seconds = time % 60;
        var fraction = (time * 100) % 100;

        timerLabel.text = string.Format ("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);
        
        if(enemies <= 0){
            victory = true;
            VictoryMessage();
        }
        if((time <= 0 && victory != true) || !(player.activeSelf)){
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
