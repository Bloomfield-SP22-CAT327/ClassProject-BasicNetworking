using UnityEngine;
using Mirror;

public class GameNetworkManager : NetworkManager {
    public override void OnServerAddPlayer(NetworkConnectionToClient conn) {
        GameObject playerToSpawn = (GameObject)Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
        playerToSpawn.GetComponent<Player>().color = new Color(Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f));
        NetworkServer.AddPlayerForConnection(conn, playerToSpawn);
    }
}
