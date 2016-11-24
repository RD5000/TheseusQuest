using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerAttack : MonoBehaviour {

    private GameObject _gameControllerObject;
    private GameController _gameController;
    private int _comboCounter;

    public Transform PlayerCam;
    public float SwingRange = 3f;

    // Use this for initialization
    void Start () {
        this._gameControllerObject = GameObject.Find("GameController");
        this._gameController = this._gameControllerObject.GetComponent<GameController>() as GameController;

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;

            // if raycast hits an object then do something...
            if (Physics.Raycast(this.PlayerCam.position, this.PlayerCam.forward,  out hit, this.SwingRange))
            {
                Debug.DrawLine(this.PlayerCam.position, hit.point);
                Debug.Log("Swing");
                if (hit.transform.gameObject.CompareTag("Enemy"))
                {
                    if (_comboCounter > 25000)
                    {
                        Debug.Log("Enemy");
                        Destroy(hit.transform.gameObject);
                        this._gameController.ScoreValue += 200;
                        this._gameController.ComboValue = 2;
                        _comboCounter += 50000;
                    }
                    else if (_comboCounter > 50000)
                    {
                        Debug.Log("Enemy");
                        Destroy(hit.transform.gameObject);
                        this._gameController.ScoreValue += 300;
                        this._gameController.ComboValue = 3;
                        _comboCounter += 50000;
                    }
                    else
                    {
                        Debug.Log("Enemy");
                        Destroy(hit.transform.gameObject);
                        this._gameController.ScoreValue += 100;
                        _comboCounter += 50000;
                    }
                }
                else
                {
                    Debug.Log("Hit");
                }
            }
        }
        while (_comboCounter != 0)
        {
            _comboCounter -= 1;
        }
    }
}
