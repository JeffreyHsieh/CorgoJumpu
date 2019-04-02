using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    // Player score
    private float _score;
    public float score
    {
        get
        {
            return _score;
        }
    }

    // UI variables
    public Text currentScore;
    public Button retryButton;

    // Game states
    enum GameStates {Energized, Exhausted};
    GameStates state;
    public bool end;

    // Methods
    public void gameOver()
    {
        end = true;
        Debug.Log("Game Over!");
        state = GameStates.Exhausted;
        retryButton.gameObject.SetActive(true);
    }

    public void addPoint(int point)
    {
        Debug.Log("+1 Point!");
        _score += point;
    }

    public void retry()
    {
        end = false;
        state = GameStates.Energized;
        retryButton.gameObject.SetActive(false);
        _score = 0;
    }

    void Start () {
        end = false;
        _score = 0;
        state = GameStates.Energized;
	}
    
	void Update () {
        switch (state)
        {
            case GameStates.Energized:
                _score += 7f * Time.deltaTime;
                int cs = (int)_score;
                currentScore.text = cs.ToString();
                break;
            case GameStates.Exhausted:
                break;
        }
	}
}
