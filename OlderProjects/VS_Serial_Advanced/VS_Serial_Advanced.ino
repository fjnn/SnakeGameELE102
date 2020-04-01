const int ledPins[] = {9,10,11};
#define POTPIN A0

#define MAX_MILLIS_TO_WAIT 1000
int dataSize = 6;

uint8_t receivedData[] = {0,0,0,0,0,0};

unsigned long starttime;

void setup() {
  Serial.begin(9600);
  for(int i=0; i<3; i++)
    pinMode(ledPins[i], OUTPUT);
}

void loop() {
  while(Serial.available())
  {
    uint8_t headerByte = Serial.read();
    if(headerByte == 5)
    {
      // we have found the starting byte
      // check for the incoming data is valid
      Serial.readBytes(receivedData, dataSize-1);
    }

    if(receivedData[0] == 1) // LED manipulation
    {
      if(receivedData[1] == 0) // OFF Button pressed
      {
        for(int i=0; i<3; i++)
          if(receivedData[i+2] == 1) 
            digitalWrite(ledPins[i], LOW);
      }

      else if(receivedData[1] == 1) // ON Button pressed
      {
        for(int i=0; i<3; i++)
          if(receivedData[i+2] == 1) 
            digitalWrite(ledPins[i], HIGH);
      }

      else if(receivedData[1] == 2) // TOGGLE Button pressed
      {
        for(int i=0; i<3; i++)
          if(receivedData[i+2] == 1) 
            digitalWrite(ledPins[i], !digitalRead(ledPins[i]));
      }
    }
    
    else if(receivedData[0] == 2) // pot reading
    {
      float voltage = analogRead(POTPIN);
      Serial.write(voltage);
    }
  }
}
