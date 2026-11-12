using UnityEngine;
using System.IO.Ports;
public class ArduinoScript : MonoBehaviour
{
    SerialPort serial = new SerialPort("/dev/cu.usbmodem11101", 9600);  // this will be used to select the port where the inputs from the controller
                                                       // port name will vary based on device
    
    void Start()
    {
        serial.Open(); // enables the serial
        serial.ReadTimeout = 100; //100ms the serial will wait to read a command, need it to keep from reading too many inputs into unity, sorta like time.deltaTime

    }

    // Update is called once per frame
    void Update()
    {
        string data = serial.ReadLine();  // this records the data value with the string value from the serial port (the dial reading)
        
        int val = int.Parse(data); // this translates the value to an integer to be used in transforming the object in game
        
        transform.rotation = Quaternion.Euler(0, 0, (val * 360/1023)/2); // for the transform, this will rotate a cube right now
                                                                       //   the formula 'value * 360/1023' will make the value a valid degree value for rotating
                                                                       
                                                                       // this can be used on the burner for adjusting the temperature of the burner.
    }

    /* SUMMARY:
                 The burner dial will transform on the z-axis to most closely simulate a burner adjusting the heat.
                  A suggestion I have is to add a message about returning the burner to its off-state so that the 
                  gas doesn't stay on, as well as allowing the burner to start at zero for the next time the game
                  is ran.
                
                check it out, message me on discord or teams. preferably teams if you have it
                - email/teams: duckwalloc@g.cofc.edu
                - discord: Owen D
    
    
    
    
    */
}
