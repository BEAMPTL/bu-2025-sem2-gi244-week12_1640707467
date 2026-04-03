// notice ... List class requires System.Collections.Generic namespace
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;

    [Header("UI Elements")]
    // NOTE: TextMeshProUGUI requires "using TMPro"
    public TextMeshProUGUI scoreText;
    // NOTE: TextMeshProUGUI requires "using TMPro"
    public TextMeshProUGUI gameOverText;
    public Button restartButton;

    public GameObject titleScreen;
    public GameObject gameOverScreen;
    public Button easyButton;
    public Button mediumButton;
    public Button hardButton;

    private int score;
    private bool isGameActive = true;
    private float spawnRate = 1.0f;

    void Awake()
    {

    }

    void Start()
    {
        scoreText.text ="Score" + score;
        StartGame();
    }
    public void UpdateScore(int score_)
    {
        score += score_;
        scoreText.text = "Score" + score;
    }

    void StartGame()
    {
        StartCoroutine(SpawnTargets());
    }

    IEnumerator SpawnTargets()
    {
        while (true)
        {
            int idex = Random.Range(0, targets.Count);
            var prefab = targets[idex];
            Instantiate(prefab);
            yield return new WaitForSeconds(spawnRate);
        }
    }
}

