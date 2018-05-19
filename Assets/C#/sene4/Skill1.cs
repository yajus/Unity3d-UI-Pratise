using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill1 : MonoBehaviour {

	public float ColdTimeStart=2;
	public float ColdTimeEnd=0;
	public Image CoolDown;
	private bool StartTime = false;
	public KeyCode SkillKey_1;

	// Use this for initialization
	void Start () {
		CoolDown=transform.Find("CoolDown").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (SkillKey_1)) {
			StartTime = true;
		}
		if (StartTime)
		{
			ColdTimeEnd += Time.deltaTime;
			CoolDown.fillAmount=(ColdTimeStart - ColdTimeEnd) / ColdTimeStart;
		}
		if (ColdTimeEnd >= ColdTimeStart) {
			CoolDown.fillAmount = 0;
			ColdTimeEnd = 0;
			StartTime = false;

		}
	}

	public void Onclick()
	{
		StartTime = true;
	}
}
