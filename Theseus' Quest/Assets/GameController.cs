using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    private int _livesValue;
    private int _scoreValue;
    private int _comboValue;

    [Header("UI Objecterinos")]
    public Text LivesLabel;
    public Text ScoreLabel;
    public Text ComboLabel;

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {

            }
            else
            {
                this.LivesLabel.text = "Health: " + this._livesValue + "%";
            }
        }
    }

    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;
        }
    }

    public int ComboValue
    {
        get
        {
            return this._comboValue;
        }

        set
        {
            this._comboValue = value;
            this.ComboLabel.text = "COMBO!" + this._comboValue;
                
        }
    }

    // Use this for initialization
    void Start () {
        this.LivesValue = 100;
        this.ScoreValue = 0;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
