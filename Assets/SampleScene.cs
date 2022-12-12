using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
public class SampleScene : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Lobby", new RoomOptions(), TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        var position = new Vector3(Random.Range(-3f, 3f), 4, Random.Range(-3f, 3f));
        PhotonNetwork.Instantiate("Avatar", position, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
