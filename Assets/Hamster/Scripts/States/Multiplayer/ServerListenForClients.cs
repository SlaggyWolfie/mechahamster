﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
namespace Hamster.States
{
    public class ServerListenForClients : BaseState
    {
        public NetworkManager manager;
        public bool bServerStarted = false;

        override public void Initialize()
        {
            //MultiplayerGame.instance.EnterServerStartupState(startLevel);  //  use this now instead of manager.StartServer()
            bServerStarted = true;// manager.StartServer();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}   //  Hamster.States