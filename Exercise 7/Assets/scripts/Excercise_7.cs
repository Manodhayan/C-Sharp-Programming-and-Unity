using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excercise_7 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        double input_body_temperature_fahrenheit = 0;
        //print(input_body_temperature_fahrenheit * 5 / 9);
        double fahrenheitToCelcuis = (float)(input_body_temperature_fahrenheit - 32) * 5 / 9;
        double CelciusToFahrenheit = (float)(fahrenheitToCelcuis * 9 / 5 ) + 32;
        print("Celcius:" + fahrenheitToCelcuis + " Fahrenheit: "+ CelciusToFahrenheit);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
