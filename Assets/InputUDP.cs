using System.Collections.Generic;

using UnityEngine;
using System.Collections;
using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text;


public class InputUDP : MonoBehaviour
{
    // read Thread
    Thread thread;

    // udpclient object
    UdpClient client;

    // port number
    public int port = -1;
    public string ipAdressConnect = "";

    // UDP packet store
    public string lastReceivedPacket = "";
    public bool startReceving = false;
    private bool _startReceving = false;
    private IPEndPoint anyIP;
    // not start from unity3d
    public void StartReceive()
    {
        if (port == -1 || ipAdressConnect == "")
        {
            Debug.Log("Connection port or IP address not configured");
        }
        startReceving = true;
        // create thread for reading UDP messages
        thread = new Thread(new ThreadStart(ReceiveData));
        thread.IsBackground = true;
        thread.Start();
    }

    void Start()
    {
        Application.runInBackground = true;
        //anyIP = new IPEndPoint(IPAddress.Parse(ipAdressConnect), port);
        anyIP = new IPEndPoint(IPAddress.Any, port);
        StartReceive();
    }

    //void Update()
    //{
    //    // check button "s" to abort the read-thread
    //    if (startReceving && (!_startReceving))
    //    {
    //        StartReceive();
    //    }
    //    else if (_startReceving && ((!startReceving) || Input.GetKeyDown("q")))
    //    {
    //        stopThread();
    //    }
    //    _startReceving = startReceving;
    //}

    void OnDisable()
    {
        if (thread != null)
        {
            thread.Abort();
            client.Close();
        }
    }

    // Unity Application Quit Function
    void OnApplicationQuit()
    {
        stopThread();
    }

    // Stop reading UDP messages
    public void stopThread()
    {
        if (thread != null)
        {
            if (thread.IsAlive)
            { thread.Abort(); }
            client.Close();
            startReceving = false;
            lastReceivedPacket = "";
        }
    }

    // receive thread function
    private void ReceiveData()
    {
        

        client = new UdpClient(port);
        //client.Client.Blocking = false;
        while (true)
        {
            if (!startReceving)
                
            break;
            try
            {
                //Debug.Log("Test");
                // receive bytes
                //IPEndPoint anyIP = new IPEndPoint(IPAddress.Parse(ipAdressConnect), port);
                // IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, port);
                byte[] data = client.Receive(ref anyIP);
                

                //string text;
                // encode UTF8-coded bytes to text format
                //if (use8)
                //text = Encoding.UTF8.GetString(data);
                //else
                //text = Encoding.UTF32.GetString(data);


                // store new massage as latest message
                //lastReceivedPacket = text;
                lastReceivedPacket = Encoding.UTF8.GetString(data);
                // show received message
                print(">>" + lastReceivedPacket);
                //Debug.Log(">>" + lastReceivedPacket);
            }
            catch (Exception err)
            {
                //Debug.Log("Test");
                print(err.ToString());
            }
        }
    }

    // return the latest message
    public string getLatestPacket()
    {
        return lastReceivedPacket;
    }


}