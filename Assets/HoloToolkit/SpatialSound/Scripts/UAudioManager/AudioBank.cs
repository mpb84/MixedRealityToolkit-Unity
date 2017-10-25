﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HoloToolkit.Unity
{
    public abstract class AudioBank<T> : ScriptableObject
    {
        public T[] Events;
    }

}

