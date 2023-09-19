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
        //       ī�޶��� ������ �� - �÷��̾��� ������ ��
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
