/*
 * 1 potentiometer connected to A0
 * 
 * 3 LEDs connected to pin 9,10,11
 * 
 */

const int ledPins[] = {9, 10, 11};
#define POTPIN A0

uint8_t receivedData[] = {0,0,0,0,0,0};  // --> uint8_t receivedData[] = {0,0,0,0,0}
int dataSize = 6;

void setup() {
  Serial.begin(9600);
  for(int i = 0; i < 3; i++)
    pinMode(ledPins[i], OUTPUT);
}

void loop() {

  while(Serial.available())
  {
    uint8_t headerByte = Serial.read();

    if(headerByte == 5)
    {
      // this is my header, Found it, YAY.
      Serial.readBytes(receivedData, dataSize);
    }

    if(receivedData[0] == 1) // LED Manipulation -- the first element of my sub array = 1
    {
      if(receivedData[1] == 0) // Button Related -- OFF Button is pressed
      {
        for(int i = 0; i < 3; i++)
          if(receivedData[i+2] == 1)  // Example array: {header,1,0, L1, L2, L3}
            digitalWrite(ledPins[i], LOW);
      }

      else if(receivedData[1] == 1) // Button Related -- ON Button is pressed
      {
        for(int i = 0; i < 3; i++)
          if(receivedData[i+2] == 1)  // Example array: {header,1,1, L1, L2, L3}
            digitalWrite(ledPins[i], HIGH);
      }

      else if(receivedData[1] == 2) // Button Related -- TOGGLE Button is pressed
      {
        for(int i = 0; i < 3; i++)
          if(receivedData[i+2] == 1)  // Example array: {header,1,2, L1, L2, L3}
            digitalWrite(ledPins[i], !digitalRead(ledPins[i]));
      }
    }

    else if(receivedData[0] == 2) // Example array: {header,2,*, *, *, *}
    {
      int voltage = analogRead(POTPIN); // 0 - 1023
      Serial.println(voltage);
    }
    
  }

}
