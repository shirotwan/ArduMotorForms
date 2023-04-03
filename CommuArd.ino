int hash[4][4]={
  {1,0,0,0},
  {0,1,0,0},
  {0,0,1,0},
  {0,0,0,1}
};
char dato = '0';
bool ver;
void setup() {
Serial.begin(9600);
pinMode(4,OUTPUT);
for(int i = 7; i < 13; i++){
  pinMode(i,OUTPUT);
}
}
void mec1(){

for(int t = 0; t < 501;t++){
for(int w = 0; w < 4;w++){
  digitalWrite(8,hash[w][0]);
  digitalWrite(9,hash[w][1]);
  digitalWrite(10,hash[w][2]);
  digitalWrite(11,hash[w][3]);
  delay(4);
}
delay(4);
}

}
void mec2(){

for(int t = 0; t < 501;t++){
for(int w = 0; w < 4;w++){
  digitalWrite(8,hash[w][3]);
  digitalWrite(9,hash[w][2]);
  digitalWrite(10,hash[w][1]);
  digitalWrite(11,hash[w][0]);
  delay(4);
}
delay(4);
}

}
void loop() {
if(Serial.available()){
  dato = Serial.read();
}
if(dato == '1'){
digitalWrite(7,1);
mec1();
dato = '0';
digitalWrite(7,0);
}
if(dato == '2'){
digitalWrite(4,1);
mec2();
dato = '0';
digitalWrite(4,0);
}
}