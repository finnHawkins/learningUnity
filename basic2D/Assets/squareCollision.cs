using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class squareCollision : MonoBehaviour
{

  public Text infoText;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  void OnCollisionEnter2D(Collision2D collision) {

      Debug.Log(collision.gameObject.name);

  }

  private void OnTriggerEnter2D(Collider2D collision) {
    //Do something
    infoText.text = "Ow!";

  }

  private void OnTriggerExit2D(Collider2D collision) {
    //Do something
    infoText.text = "Ah!";
  }
}
