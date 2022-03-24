using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    [SerializeField] float _speed = 10;
    [SerializeField] float _border = 2.6f;
    [SerializeField] GameObject _UIBG, _gameoverUI;
    [SerializeField] TextMeshProUGUI _finalScore;

    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        _UIBG.SetActive(false);
        _gameoverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if(transform.position.y < -5)
        {
            EndGame();
        }
    }

    private void Movement()
    {
        var horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(new Vector2(horizontalInput, 0) * Time.deltaTime * _speed);

        if (transform.position.x > _border)
        {
            transform.position = new Vector2(_border, transform.position.y);
        }

        if (transform.position.x < -_border)
        {
            transform.position = new Vector2(-_border, transform.position.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EndPoint")
        {
            EndGame();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Base")
        {
            Score += 1;
            var Collider = other.GetComponent<BoxCollider2D>();
            Destroy(Collider);
        }
    }
    private void EndGame()
    {
        Time.timeScale = 0;
        _finalScore.text = "Your Score: " + Score.ToString();
        _UIBG.SetActive(true);
        _gameoverUI.SetActive(true);
    }
}
