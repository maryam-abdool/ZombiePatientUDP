using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * ref:https://social.msdn.microsoft.com/Forums/en-US/92846ccb-fad3-469a-baf7-bb153ce2d82b/simple-udp-example-code?forum=netfxnetcom
 
    -----------------------
    UDP-Send
    -----------------------
    // [url]http://msdn.microsoft.com/de-de/library/bb979228.aspx#ID0E3BAC[/url]
   
    // > gesendetes unter
    // 127.0.0.1 : 8050 empfangen
   
    // nc -lu 127.0.0.1 8050
 
        // todo: shutdown thread at the end
*/
using UnityEngine;
using System.Collections;

using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class SendUDP : MonoBehaviour
{

    //// read Thread
    //Thread thread;

    // udpclient object
    UdpClient client;

    private static int localPort;

    // prefs
    public string IP;  // define in init
    public int port;  // define in init
    public string messageToSend;

    // "connection" things
    IPEndPoint remoteEndPoint;

    // gui
    string strMessage = "";


    // call it from shell (as program)s
    private static void Main()
    {
        SendUDP sendObj = new SendUDP();
        sendObj.init();

        // testing via console
        // sendObj.inputFromConsole();


    }
    // start from unity3d
    public void Start()
    {
        init();
        strMessage = messageToSend;
    }


    // init
    public void init()
    {
        // Endpoint to which the messages are sent.
        print("SendUDP.init()");
        //// define
        //IP = "127.0.0.1";
        //port = 8051;

        remoteEndPoint = new IPEndPoint(IPAddress.Parse(IP), port);
        client = new UdpClient();

        // status
        print("Sending to " + IP + " : " + port);
        print("Testing: nc -lu " + IP + " : " + port);

    }

    // sendData
    private void sendString(string message)
    {
        //Boolean exception_thrown = false;

        try
        {
            if (message != "")
            {

                // Data with the UTF8 encoding into the binary format.
                byte[] send_buffer = Encoding.UTF8.GetBytes(message);
                // Send the message to the remote client.
                client.Send(send_buffer, send_buffer.Length, remoteEndPoint);
            }
        }
        catch (Exception send_exception)
        {
            //exception_thrown = true;

            Debug.Log(string.Format("Exception {0}", send_exception.Message));
        }
        //if (exception_thrown == false)
        //{
        //    Console.WriteLine("Message has been sent to the broadcast address");
        //    Debug.Log("Message has been sent to the broadcast address");
        //}
        //else
        //{
        //    exception_thrown = false;
        //    Console.WriteLine("The exception indicates the message was not sent.");
        //}
    }

    private void Update()
    {
        if (strMessage != messageToSend)
        {
            strMessage = messageToSend;
            sendString(messageToSend);

            //Debug.Log(messageToSend);
        }
    }

    void OnApplicationQuit()
    {
        client.Close();
    }
}