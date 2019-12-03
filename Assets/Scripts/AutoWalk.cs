using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoWalk : MonoBehaviour
{
    public int speed = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
    }

    public void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.CompareTag("trophyTag")) {
            SceneManager.LoadScene("EndScene");
        }
    }
}
