using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System;

/// <summary>
/// Handles messages received from network clients on a socket.
/// Add code to the bytesReceived method to handle messages.
/// </summary>
public class SocketBehavior : MonoBehaviour
{
    private int port = 1000;
    private TcpServer server;
    private bool _newMessagesReceived = false;
    private byte[] bytes=null;

    void Start()
    {
        server = new TcpServer(10, 100);
        server.Init(ReceiveCompleted);
        server.Start(new IPEndPoint(IPAddress.Loopback, port));
    }

    // Don't modify this code for message handling.  Instead, add code to the bytesReceived method below.
    internal void ReceiveCompleted(SocketAsyncEventArgs e)
    {
        lock(server)
        {
            int bytesSoFar = bytes == null ? 0 : bytes.Length;
            Array.Resize<byte>(ref bytes, e.BytesTransferred + bytesSoFar);
            Array.Copy(e.Buffer, e.Offset, bytes, bytesSoFar, e.BytesTransferred);
            _newMessagesReceived = true;
        }
    }
    

    void Update()
    {
        // Don't modify this code for message handling.  Instead, add code to the bytesReceived method below.
        lock (server)
        {
            if (_newMessagesReceived)
            {
                bytesReceived(bytes);
                bytes = null;
                _newMessagesReceived = false;
            }
        }
    }

    /// <summary>
    /// Called when new bytes are received on the socket.
    /// Add code to this method to handle messages.  
    /// 
    /// Note that you might receive partial messages in this method -- newBytes simply contains 
    /// whatever bytes have been received since the server last notified us and we don't control 
    /// when it chooses to do that.
    /// </summary>
    /// <param name="newBytes">the bytes that were received on the socket</param>
    void bytesReceived(byte[] newBytes)
    {
        Debug.Log("bytesReceived: " + System.Text.Encoding.ASCII.GetString(bytes));
    }
}
