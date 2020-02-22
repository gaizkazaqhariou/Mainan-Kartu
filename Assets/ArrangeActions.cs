using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class ArrangeActions : MonoBehaviour {
	private RectTransform panelRectTransform;
	// Use this for initialization
	void Start () {
		panelRectTransform = GetComponent<RectTransform> ();
	}

	public void MoveDownOne(){
		print ("(before change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex ());
		int currentSiblingIndex = panelRectTransform.GetSiblingIndex();
		panelRectTransform.SetSiblingIndex(currentSiblingIndex - 1);
		print ("(after change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex ());
	}
	public void MoveUpOne(){
		print ("(before change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex ());
		int currentSiblingIndex = panelRectTransform.GetSiblingIndex();
		panelRectTransform.SetSiblingIndex(currentSiblingIndex + 1);
		print ("(after change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex ());
	}
	public void MoveToFront(){
		print ("(before change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex ());
		int currentSiblingIndex = panelRectTransform.GetSiblingIndex();
		panelRectTransform.SetSiblingIndex(currentSiblingIndex + 2);
		print ("(after change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex ());
	}
	public void MoveToBack(){
		print ("(before change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex ());
		int currentSiblingIndex = panelRectTransform.GetSiblingIndex();
		panelRectTransform.SetSiblingIndex(currentSiblingIndex - 2);
		print ("(after change) " + gameObject.name + "sibling index = " + panelRectTransform.GetSiblingIndex ());
	}
}
