using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField] GameObject _pauseUI, _UIBG;
    [SerializeField] Base[] _base;

    Ball _ball;
    SpawnManager _spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        _ball = GameObject.Find("Ball").GetComponent<Ball>();
        _spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();

        _scoreText.text = "Score: " + 0.ToString();
        _pauseUI.SetActive(false);
        _UIBG.SetActive(false);

        InvokeRepeating("IncresingSpeed", 0.1f, 10);
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = "Score: " + _ball.Score.ToString();
    }

   void IncresingSpeed()
    {
        if(_base[0].Speed <= 10f)
        {
             _base[0].Speed += 0.01f;
        }

        if (_base[1].Speed <= 10f)
        {
            _base[1].Speed += 0.01f;
        }

        if (_base[2].Speed <= 10f)
        {
            _base[2].Speed += 0.01f;
        }

        if (_base[3].Speed <= 10f)
        {
            _base[3].Speed += 0.01f;
        }

        if (_spawnManager.TimeBetweenSpawns >= 0.2f)
        {
            _spawnManager.TimeBetweenSpawns -= 0.01f;
        }
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        _pauseUI.SetActive(true);
        _UIBG.SetActive(true);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
        _pauseUI.SetActive(false);
        _UIBG.SetActive(false);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
