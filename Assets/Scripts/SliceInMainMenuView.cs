﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JoostenProductions;
using Tools;
using UnityEngine;

public class SliceInMainMenuView : MonoBehaviour
{
    [SerializeField] private TrailRenderer _trail;

    public void Initialize()
    {
        UpdateManager.SubscribeToUpdate(OnUpdate);
        _trail.emitting = true;
    }

    private void OnUpdate()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            var halfScreenWidth = Screen.width / 2f;

            if (touch.phase == TouchPhase.Moved)
            {
                _trail.gameObject.transform.position = touch.position;
                _trail.gameObject.SetActive(true);
            }
            if(touch.phase == TouchPhase.Ended)
            {
                _trail.gameObject.SetActive(false);
            }
        }
    }



    void OnDestroy()
    {
        UpdateManager.UnsubscribeFromUpdate(OnUpdate);
    }
}