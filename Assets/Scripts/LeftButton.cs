using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] GameObject _ball;
    [SerializeField] float _speed = 10;

    bool _isPressed = false;

    // Update is called once per frame
    void Update()
    {
        if(_isPressed)
        {
            _ball.transform.Translate(Vector2.left * Time.deltaTime * _speed); 
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _isPressed = false;
    }
}
