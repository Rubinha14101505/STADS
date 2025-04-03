//SERIAL TEMPERATURA
//IFACI-SENAI SÃO CARLOS
//CSTADS
//02/04/2025
//AUTOR: ANA RÚBIA DE ALMEIDA

int SENSOR = 0; //DEFINE O PINO ANALÓGICO A0 COMO ENTRADA DE SENSOR
float D = 0;    //VARIAVEL PARA ARMAZENAR O VALOR LIDO DO SENSOR (0-1023)
int T = 0;      //VARIAVEL PARA ARMAZENAR A TEMPERATURA CALCULADA

void setup() {
  Serial.begin(9600); //INICIA A COMUNICAÇÃO SERIAL COM TAXA DE 9600 BAUDS
}

void loop() {
  D = analogRead(SENSOR);
  T = (D * 5 * 100) / 1023;  //CONVERTE O VALOR LIDO PARA TEMPERATURA
  Serial.print(T);           //ENVIA O VALOR DA TEMPERATURA PARA O SERIAL
  delay(1000);               //AGUARDA 1 SEGUNDO ANTES DA PROXIMA LEITURA
}

int main(void) {
  init();  //INICIALIZA HARDWARE (FUNÇÃO INTERNA DO ARDUINO)
  setup(); //CHAMA A FUNÇÃO SETUP
  for(;;)  //LOOP INFINITO
    loop(); //CHAMA CONTINUAMENTE A FUNÇÃO LOOP()

  return 0;
}