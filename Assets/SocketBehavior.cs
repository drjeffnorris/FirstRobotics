using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;

public class SocketBehavior : MonoBehaviour
{
 
  private bool toggle = false;

    private int port = 10999;
    private TcpServer s;

    void Start()
    {
        s = new TcpServer(10, 100);
        s.Init(ReceiveCompleted);
        s.Start(new IPEndPoint(IPAddress.Loopback, port));
    }

    internal void ReceiveCompleted()
    {
        toggle = true;
    }

    void Update()
    {
        if (toggle)
        {
            Debug.Log("Received.");
            toggle = false;
        }
    }
}
