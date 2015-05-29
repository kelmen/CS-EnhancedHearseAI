using System;
using System.Collections.Generic;
using System.Threading;

using ICities;
using ColossalFramework;
using ColossalFramework.Math;
using ColossalFramework.UI;
using UnityEngine;

namespace EnhancedHearseAI
{
    public class Loader : ILoadingExtension
    {
        Helper _helper;

        public Loader()
        {
            _helper = Helper.Instance;
        }

        public void OnCreated(ILoading loading)
        {
            _helper.GameLoaded = loading.loadingComplete;
        }

        public void OnLevelLoaded(LoadMode mode)
        {
            if (mode == LoadMode.NewGame || mode == LoadMode.LoadGame)
                _helper.GameLoaded = true;
        }

        public void OnLevelUnloading()
        {
            _helper.GameLoaded = false;
        }

        public void OnReleased()
        {
        }
    }
}