#include <LiquidCrystal.h>
LiquidCrystal lcd(12,11,5,4,3,2);
#define AGV1 7
#define AGV2 8
#define AGV3 9
#define startbyteOffset 0
#define frameLength 1
#define senderOffset 2
#define receiverOffset 3
#define messageTypeOffset 4
#define payloadOffset 5
#define startByte 0x7A
#define endByte 0x7F
void UpdateStatus()
{
  int n = Serial.available();
    int j;
   byte data[n];
    for(j=0;j<n;j++)
   {
      data[j]=Serial.read();
   }
 
         if(digitalRead(AGV1)==LOW && digitalRead(AGV2)==LOW&& digitalRead(AGV3)==LOW)
         Serial.print('0');
         if(digitalRead(AGV1)==LOW && digitalRead(AGV2)==LOW&& digitalRead(AGV3)==HIGH)
         Serial.print('1');
         if(digitalRead(AGV1)==LOW && digitalRead(AGV2)==HIGH&& digitalRead(AGV3)==LOW)
         Serial.print('2');
         if(digitalRead(AGV1)==LOW && digitalRead(AGV2)==HIGH&& digitalRead(AGV3)==HIGH)
         Serial.print('3');
         if(digitalRead(AGV1)==HIGH && digitalRead(AGV2)==LOW&& digitalRead(AGV3)==LOW)
         Serial.print('4');
         if(digitalRead(AGV1)==HIGH && digitalRead(AGV2)==LOW&& digitalRead(AGV3)==HIGH)
         Serial.print('5');
         if(digitalRead(AGV1)==HIGH&& digitalRead(AGV2)==HIGH&& digitalRead(AGV3)==LOW)
         Serial.print('6');
         if(digitalRead(AGV1)==HIGH && digitalRead(AGV2)==HIGH&& digitalRead(AGV3)==HIGH)
         Serial.print('7');       
}
void param_packet(byte* a){
*a=startByte;
*(a+1)= 11;
*(a+2)=0x01;
*(a+3)=0xFE;
*(a+4)=0x03;
*(a+5)=5;
*(a+10)=endByte;

}
void AGVStatus(byte a)
{
  switch(a)
  {
      case 0x04 : Serial.print('0'); break;
      case 0x05 : Serial.print('1'); break;
      case 0x06 :  Serial.print('2');break;
      case 0x07 : Serial.print('3'); break;
      case 0x08 : Serial.print('4'); break;
      case 0x09 : Serial.print('5'); break;
      case 0xAA : Serial.print('6'); break;
      case 0x10 :  Serial.print('7');break; 
  }
}
void Transmitt(byte* data, int count1)
{
  if(data[count1+1] == 0x04 || data[count1+1] == 0x05 || data[count1+1]==0x06)
  {
    byte a[11];
     param_packet(a);
     a[6] = data[count1];
    a[7] = data[count1+1]; 
     a[8] = 0x00;
    a[9] = 0x05;
     byte b[11];
     param_packet(b);
     b[6] = data[count1];
     b[7] = 0x0A;
     b[8] = 0x05;
     b[9] = 0x50;
     Serial.write(a,11);
     delay(3000);
    Serial.write(b,11);
     delay(3000);    
  }
  else
  {
    
    byte a[11];
   param_packet(a);
   a[6] = data[count1];
   a[7] = data[count1+1];
   if(data[count1]==0x01)
   {a[8] = 0x00;}
   else
  { a[8] = 0x05;}
   a[9] = 0x50;
    Serial.write(a,11);
     delay(3000);
  }
  
  

   
}
void setup() {
  // put your setup code here, to run once:
  lcd.begin(16,2);
  pinMode(13,OUTPUT);
  pinMode(7,INPUT);
  pinMode(8,INPUT);
  pinMode(9,INPUT);
  Serial.begin(9600);
  lcd.print("Hello");

}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(13,HIGH);
  delay(500);
  digitalWrite(13,LOW);
  delay(500);
   int length1 ;
   if(Serial.available())
   {
      delay(1000);
       int n = Serial.available();
       length1 = n;
       byte data[n];
       int count;
       for(count=0;count<n;count++)
       {
        data[count] = Serial.read();
        delay(50);
       }
      if(n==1  && data[0] == 0x99)
       {
          UpdateStatus();  
       }
       int count1 ;
   if(n!=1)
   {
    for(count1 = 6 ;count1 < length1-2 ; count1 = count1 + 2)
       {
    lcd.clear();
    lcd.print("TAG ");
    lcd.print(data[count1],HEX);
    lcd.print(" ");
    //lcd.setCursor(0,5); 
    switch (data[count1+1])
        {
    
      //case 0x0" : lcd.print("??"); break;
      case 0x01 :   lcd.print("Go Straight");Transmitt(data,count1);break;
      case 0x02 :   lcd.print("Turn Left"); Transmitt(data,count1); break;
      case 0x03 :   lcd.print("Turn Right");Transmitt(data,count1);break;
      case 0x04 :   lcd.print("Collect 1");delay(1000); Transmitt(data,count1); lcd.print("Go"); break;
      case 0x05 :   lcd.print("Collect 2"); delay(1000); Transmitt(data,count1); lcd.print("Go"); break;
      case 0x06 :   lcd.print("Delivery");delay(1000); Transmitt(data,count1);lcd.print("Go"); break;
      case 0x07 :   lcd.print("Reverse");Transmitt(data,count1);break;
      case 0x08 :   lcd.print("Start");Transmitt(data,count1); break;
      case 0x09 :   lcd.print("Stop");Transmitt(data,count1);break;

        }
      

 
   }
}
}
