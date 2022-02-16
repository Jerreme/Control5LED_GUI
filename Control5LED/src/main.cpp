#include <Arduino.h>

#define led1 6
#define led2 5
#define led3 4
#define led4 3
#define led5 2

// --------------------------------------------------------------------------------------------------------------//

void offALL(int time) {
  for (int pin=led5; pin<=led1; pin++) {
    digitalWrite(pin, LOW);
  }
  if (time != 0) 
    delay(time);
}


void swapping(int speed, int repeat, int Delay) {
  bool redState;
  bool blueState;

  for (int i=0; i<repeat; i++) {
    if(i%2 == 0) {
      redState = HIGH;
      blueState = LOW;
    }else {
      redState = LOW;
      blueState = HIGH;
    }

    digitalWrite(led1, blueState);
    digitalWrite(led2, redState);
    digitalWrite(led3, blueState);
    digitalWrite(led4, redState);
    digitalWrite(led5, blueState);
    delay(speed);
  }

  delay(Delay);
  offALL(0);
}

void waveLights(int speed, bool state, int Delay) {
  int A = led3, C = led3;
  
  digitalWrite(led3, state);
  delay(speed);
  for (int i=0; i<2; i++) {
    A--; C++;
    digitalWrite(A, state);
    digitalWrite(C, state);
    delay(speed);
  }

  delay(Delay);
}

void leftToRight(int speed, bool stay, bool state, int Delay) {
  for (int pin=led1; pin>=led5; pin--) {
    digitalWrite(pin, state);
    delay(speed);
    if(!stay) 
      digitalWrite(pin, LOW);
  }

  if (Delay != 0) {
    delay(Delay);
  }
} 
void rightToLeft(int speed, bool stay, bool state, int Delay) {
  for (int pin=led5; pin<=led1; pin++) {
    digitalWrite(pin, state);
    delay(speed);
    if(!stay) 
      digitalWrite(pin, LOW);
  }

  if (Delay != 0) {
    delay(Delay);
  }
}

// --------------------------------------------------------------------------------------------------------------//

void sequence1() {
  for (int i=0; i<5; i++) {
    leftToRight(50, true, HIGH, 500);
    leftToRight(50, true, LOW, 200);
  }
  Serial.print("Sequence 1 has completed");
}

void sequence2() { 
  for (int i=0; i<5; i++) {
    waveLights(100, HIGH, 300);
    waveLights(100, LOW, 500);
  }
  Serial.print("Sequence 2 has completed");
}

void sequence3() {
  swapping(500, 6, 1000);
  Serial.print("Sequence 3 has completed");
}

// --------------------------------------------------------------------------------------------------------------//

void setup() {
  // put your setup code here, to run once:
  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(led3, OUTPUT);
  pinMode(led4, OUTPUT);
  pinMode(led5, OUTPUT);

  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available()) {
    int received = Serial.read();

    switch (received) {
      case 'A':
        digitalWrite(led1, HIGH);
        break;
      case 'a':
        digitalWrite(led1, LOW);
        break;

      case 'B':
        digitalWrite(led2, HIGH);
        break;
      case 'b':
        digitalWrite(led2, LOW);
        break;

      case 'C':
        digitalWrite(led3, HIGH);
        break;
      case 'c':
        digitalWrite(led3, LOW);
        break;

      case 'D':
        digitalWrite(led4, HIGH);
        break;
      case 'd':
        digitalWrite(led4, LOW);
        break;
      
      case 'E':
        digitalWrite(led5, HIGH);
        break;
      case 'e':
        digitalWrite(led5, LOW);
        break;


      case 'F':
        sequence1();
        break;
      case 'f':
        offALL(0);
        break;

      case 'G':
        sequence2();
        break;
      case 'g':
        offALL(0);
        break;

      case 'H':
        sequence3();
        break;
      case 'h':
        offALL(0);
        break;

      default:
        break;
    }
  }
}
