using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
       
    }
}
