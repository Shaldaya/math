﻿using UnityEngine;
using System.Collections;

public class math : MonoBehaviour {
	
	void Start () {

	// calculating the area, diameter, circumference and volume of a circle/ sphere
		float pi = 3.14f;
		float radius = 4f;
		float diameter = radius * 2f;
		float circumference = 2f * pi * radius;
		float areaS = pi * radius;
		float volume = ( 4 / 3 ) * pi * radius;
		//wasnt sure if there is a better way to do exponents, hope this makes sense
		float areaSSquared = areaS * areaS;
		float volumeCubed = volume * volume * volume;
		Debug.Log (diameter);
		Debug.Log (circumference);
		Debug.Log (areaSSquared);
		Debug.Log (volumeCubed);
	
	
	//calculating perimeter and area of a rectangle
		float lengthR = 38f;
		float width = 49f;
		float perimeter = lengthR + lengthR + width + width;
		float areaR = lengthR * width;
		Debug.Log (perimeter);
		Debug.Log (areaR);

	//calculating area of triangle
		float tBase = 9f;
		float height = 4f;
		float areaT = ( tBase * height ) / 2f;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
