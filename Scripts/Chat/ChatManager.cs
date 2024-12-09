using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using TMPro;

public class ChatManager : NetworkBehaviour
{
    public static ChatManager Singleton;
    string pezzo;

    [SerializeField] ChatMessage chatMessagePrefab;
    [SerializeField] CanvasGroup chatContent;
    [SerializeField] TMP_InputField chatInput;

    public string playerName;

    void Awake() 
    { ChatManager.Singleton = this; }

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SendChatMessage(chatInput.text, playerName);
            chatInput.text = "";
        }
        else if (Input.GetKeyDown(KeyCode.F3))   //se si preme F3 viene inviato l'id del pezzo passato
        {
            SendTetrisPiece(PickUpTetrisPlayer.istance.pezzopassato);
        }
    }

    public void SendChatMessage(string _message, string _fromWho = null)
    { 
        if(string.IsNullOrWhiteSpace(_message)) return;
        
        string S = _fromWho + " > " +  _message;
        SendChatMessageServerRpc(S); 
    }
    public void SendTetrisPiece(string _message)
    {
        string S = _message;
        SendChatMessageServerRpc(S); 
    }
   
    void AddMessage(string msg) //si evita di scrivere nella finestra di chat se si tratta di una trasmissione di pezzi del tetris
    {
        if(msg.Equals("p3"))
        {
            Remote.istance.pezzoricevuto = "p3";
        }
        else if (msg.Equals("p7"))
        {
            Remote.istance.pezzoricevuto = "p7";
        }
        else
        {
            ChatMessage CM = Instantiate(chatMessagePrefab, chatContent.transform);
            CM.SetText(msg);
        }
    }

    [ServerRpc(RequireOwnership = false)]
    void SendChatMessageServerRpc(string message)
    {
        ReceiveChatMessageClientRpc(message);
    }

    [ClientRpc]
    void ReceiveChatMessageClientRpc(string message)
    {
        ChatManager.Singleton.AddMessage(message);
    }
}
