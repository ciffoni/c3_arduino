
int led =12;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(led,OUTPUT);

}

void loop() {
  // put your main code here, to run repeatedly:
if(Serial.available()){
 // switch(Serial.read()){
 //   case 'A':
 //     digitalWrite(led,!digitalRead(led));
       char c = Serial.read();   //le o byte disponivel
    Serial.write(c);           //retorna o que foi lido
 //   break;
  }
}
//}
