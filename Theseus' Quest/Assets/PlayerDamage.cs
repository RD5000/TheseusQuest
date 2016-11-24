using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour {

    private GameObject _gameControllerObject;
    private GameController _gameController;

	// Use this for initialization
	void Start () {
        this._gameControllerObject = GameObject.Find("GameController");
        this._gameController = this._gameControllerObject.GetComponent<GameController>() as GameController;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollsionEnter(BoxCollider other)
    {
        Debug.Log("Collide!");
        if (other.gameObject.CompareTag("Enemy"))
        {
            this._gameController.LivesValue -= 10;
        }
    }
}
