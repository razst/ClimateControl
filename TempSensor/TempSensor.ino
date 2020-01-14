#include "DHT.h"
//http://www.circuitbasics.com/how-to-set-up-the-dht11-humidity-sensor-on-an-arduino/
//http://www.circuitbasics.com/wp-content/uploads/2015/10/Arduino-DHT11-Tutorial-4-Pin-DHT11-Wiring-Diagram.png
#define DHTPIN 7
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);

void setup() {
  Serial.begin(9600);
  Serial.println(F("DHTxx test!"));

  dht.begin();
}

void loop() {
  delay(2000);

  float h = dht.readHumidity();
  float t = dht.readTemperature();

  if (isnan(h) || isnan(t)) {
    Serial.println(F("Failed to read from DHT sensor!"));
    return;
  }

  Serial.print(h);
  Serial.print(",");
  Serial.println(t);

}
