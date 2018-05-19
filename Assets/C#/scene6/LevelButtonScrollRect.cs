using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class LevelButtonScrollRect : MonoBehaviour ,IBeginDragHandler,IEndDragHandler{

	private ScrollRect scrollRect;
	private float[] pageArray = new float[]{ 0, 0.333333f, 0.666666f, 1 };
	public Toggle[] toggleArray;
	private float targetHorizontalPosition=0;
	private bool isDraging = false;
	// Use this for initialization
	void Start () {
		scrollRect=GetComponent<ScrollRect>();
	}
	
	// Update is called once per frame
	void Update () {
		if(isDraging==false)
		scrollRect.horizontalNormalizedPosition = Mathf.Lerp (scrollRect.horizontalNormalizedPosition, targetHorizontalPosition, Time.deltaTime*5);
	}
		

	public void OnBeginDrag (PointerEventData eventData)
	{
		isDraging = true;
	}


	public void OnEndDrag (PointerEventData eventData)
	{
		isDraging = false;
		float Posx = scrollRect.horizontalNormalizedPosition;
		int index = 0;
		float offset = Mathf.Abs (pageArray[index] - Posx);
		for(int i=1;i<pageArray.Length;i++)
			{
				float offsetTemp=Mathf.Abs(pageArray[i]-Posx);
			if (offsetTemp < offset) {
				index = i;
				offset = offsetTemp;
			}
			}
		targetHorizontalPosition = pageArray [index];
		toggleArray [index].isOn = true;
		//scrollRect.horizontalNormalizedPosition = pageArray [index];
	}

	public void MoveToPage1(bool isOn)
	{
		if(isOn)
			targetHorizontalPosition = pageArray [0];
			
	}
	public void MoveToPage2(bool isOn)
	{
		if(isOn)
		targetHorizontalPosition = pageArray [1];
	}
	public void MoveToPage3(bool isOn)
	{
		if(isOn)
		targetHorizontalPosition = pageArray [2];
	}
	public void MoveToPage4(bool isOn)
	{
		if(isOn)
		targetHorizontalPosition = pageArray [3];
	}
}
