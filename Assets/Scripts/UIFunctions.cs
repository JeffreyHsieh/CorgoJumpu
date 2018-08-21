using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunctions : MonoBehaviour {
    public GameManager gameManager;
    public ObjectPooling objectPooling;

    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public void retry()
    {
        gameManager.retry();
        objectPooling.deleteList();
    }
}
