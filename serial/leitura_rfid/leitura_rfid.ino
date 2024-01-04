#include <SPI.h> //Biblioteca para utilização do protocolo SPI;
#include <MFRC522.h> //Biblioteca para utilização do circuito RFID MFRC522;
#include <SoftwareSerial.h>

SoftwareSerial canalSerial(13,12); //13 = RX; 12 = TX;

char info; 

#define C_SELECT 10 //Pino SDA do módulo;
#define RESET 9 //Pino RESET do módulo MFRC522;

MFRC522 rfid(C_SELECT, RESET); //Declaração do módulo com o nome "rfid" no sistema com os pinos do define;

String dados = ""; //String vazia para armazenar o endereço da tag/cartão RFID;

unsigned long tempo_anterior = 0;
unsigned long intervalo = 2000;

void setup() {
  Serial.begin(9600);
  SPI.begin(); //Inicialização do protocolo SPI;
canalSerial.begin(38400);
  rfid.PCD_Init(); //Inicialização do módulo RFID;
  Serial.println("RFID: Operacional");
}

void loop() {
  if(canalSerial.available()){ 
  unsigned long tempo_atual = millis(); //Variável para armazenar o valor da função millis();

  if (tempo_atual - tempo_anterior >= intervalo) { //Temporização que faz com que o RFID realize uma leitura a cada 2 seg;
    tempo_anterior = tempo_atual; //Variável tempo_anterior sendo "zerada";

    if (!rfid.PICC_IsNewCardPresent()){ //If para testar caso o módulo NÃO tenha lido nenhum cartão/tag;
      return;
    }

    if (!rfid.PICC_ReadCardSerial()){ //If para testar caso o módulo NÃO tenha conseguido ler o endereço do cartão/tag;
      return;
    }
  }

  if (rfid.PICC_IsNewCardPresent() && rfid.PICC_ReadCardSerial())  {
    Serial.print("Endereco da TAG (HEX): ");

    for (byte i = 0; i < rfid.uid.size; i++) { //Loop que percorre o endereço lido no RFID como um vetor;
      if (rfid.uid.uidByte[i] < 0x10) {
        Serial.print(" 0");
      } else {
        Serial.print(" ");
      }

      Serial.print(rfid.uid.uidByte[i], HEX); //Código para conversão dos dados lidos no módulo, de binário para HEX;

      if (rfid.uid.uidByte[i] < 0x10) {
        dados.concat(String(" 0"));
      } else {
        dados.concat(String(" "));
      }
      dados.concat(String(rfid.uid.uidByte[i], HEX));
    }

    dados.toUpperCase(); //Colocando todos os valores do endereço em caixa alta;
    Serial.println(); //Printa os valores de endereço no Console Serial;
    canalSerial.print(dados);
    if (dados.substring(1) == "10 21 1B A4") { //Testa se o endereço lido é igual ao contido entre " ";
      Serial.println("Acesso Permitido!"); 
      dados = ""; //Zera o valor da string para a próxima leitura; 
    }
  
  }
  } 
}