const int buttons[] = {2,3,4,5}; // up, right, down, left
uint8_t data_array[] = {0,0,0,0};
uint8_t data_sent = 0;

void setup() {
  Serial.begin(9600);
}

void loop() {
  int data = 0;
  for(int i = 0; i<4; i++)
  {
    if(digitalRead(buttons[i]))
      {data_array[i] = 0;}
    else
      {data_array[i] = 1;
      data = buttons[i];}
  //Serial.print(data_array[i]);
  }
  //Serial.print(" = ");
  Serial.println(data);
  delay(100);

}
