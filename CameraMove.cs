using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //       카메라의 포지션 값 - 플레이어의 포지션 값
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
