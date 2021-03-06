﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnBtnEvent : ButtonControlled
{
    private void Start()
    {
        initListener();

        this.gameObject.SetActive(false);
    }

    protected override void activate()
    {
        this.gameObject.SetActive(true);
    }

    protected override void deactivate()
    {
        this.gameObject.SetActive(false);
    }
}
