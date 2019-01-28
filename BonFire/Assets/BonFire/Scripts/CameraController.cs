using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    Vector3 target;
    public float followSpeed;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(true);
        transform.position = GameObject.FindGameObjectWithTag("Player").transform.position + new Vector3(-3.5f, 8, -6);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform.position;
        transform.position = Vector3.Lerp(transform.position, target + new Vector3(-3.5f,8,-6), followSpeed * Time.deltaTime);
    }
}
