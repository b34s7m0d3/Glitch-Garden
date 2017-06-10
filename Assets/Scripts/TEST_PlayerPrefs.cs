using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        //Master volume test
        print (PlayerPrefsManager.GetMasterVolume());
        PlayerPrefsManager.SetMasterVolume (0.3f);
        print (PlayerPrefsManager.GetMasterVolume());

        //Level unlock test
        print(PlayerPrefsManager.IsLevelUnlocked (2));
        PlayerPrefsManager.UnlockLevel(2);
        print(PlayerPrefsManager.IsLevelUnlocked(2));

        //Difficulty test
        print(PlayerPrefsManager.GetDifficulty());
        PlayerPrefsManager.SetDifficulty(0.3f);
        print(PlayerPrefsManager.GetDifficulty());

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
