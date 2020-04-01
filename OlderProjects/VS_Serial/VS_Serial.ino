const int ledPin = 9;
#define POTPIN A0

void setup() {
  Serial.begin(9600);
  pinMode(ledPin, OUTPUT);
}

void loop() {
  if(Serial.available())
  {
    String serialInput = Serial.readString();

    if(serialInput == "led")
    {
      digitalWrite(ledPin, !digitalRead(ledPin));
    }
    else if(serialInput == "voltage")
    {
      float voltage = analogRead(POTPIN);
      Serial.print(voltage);
    }
  }
}
