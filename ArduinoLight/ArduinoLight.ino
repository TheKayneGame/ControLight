#include <FastLED.h>

#define LED_PIN     6
#define NUM_LEDS    60
#define LED_TYPE    WS2812B
#define COLOR_ORDER GRB

int BRIGHTNESS = 10;
CRGB leds[NUM_LEDS];

//int speed = 5;

String BuffCommands;
byte commandBuffer[5];

void setup()
{

	Serial.begin(115200); // opens serial port, sets data rate to 115200 bps
	pinMode(13, OUTPUT);
	pinMode(2, OUTPUT);
	pinMode(3, OUTPUT);
	pinMode(4, OUTPUT);
	FastLED.addLeds<LED_TYPE, LED_PIN, COLOR_ORDER>(leds, NUM_LEDS).setCorrection(TypicalLEDStrip);
	FastLED.setBrightness(BRIGHTNESS);
	Serial.setTimeout(10);


}

void loop()
{
	/*
	Serial.setTimeout(10);
	String state = "0";
	Serial.read();
	BuffCommands = Serial.readStringUntil('\0');
	for (int i = 0; i < BuffCommands.length(); i++) {
	if (BuffCommands.substring(i, i + 1) == ",") {
	commands[i] = BuffCommands.substring(0, i).toCharArray;
	commands[i +1] = BuffCommands.substring(i + 1).toCharArray;
	break;
	}
	BuffCommands = "";
	Serial.println(commands);
	}

	Serial.flush();
	*/
}

void serialEvent() {
	Serial.setTimeout(5);
	int bytes = Serial.available();
	Serial.readBytes(commandBuffer, bytes);

	for (int i = 0; i < bytes; i++)
	{
		Serial.println(commandBuffer[i]);
	}
}

/*for (int i = 0 ; i < a.toInt() ; i++)
{
Serial.println(a);
Serial.read();
String a = Serial.readStringUntil(';');//messages are formatted like "Function;commVal;StartsAt;EndsAt;R;G;B"
Serial.read();
String comVal = Serial.readStringUntil(';');
Serial.read();
String startAt = Serial.readStringUntil(';');
Serial.read();
String endAt = Serial.readStringUntil(';');
Serial.read();
String valRed = Serial.readStringUntil(';');
Serial.read();
String valGreen = Serial.readStringUntil(';');
Serial.read();
String valBlue = Serial.readStringUntil(';');



Serial.println(a);

/*if (a == "readVal")
{
for (int i = startAt.toInt(); i <= endAt.toInt(); i++) {
leds[i].red = valRed.toInt();
leds[i].green = valGreen.toInt();
leds[i].blue = valBlue.toInt();
digitalWrite(2, HIGH);
delay(1);
digitalWrite(2, LOW);
}
}


if (a == "displayColours")
{
FastLED.show();
digitalWrite(3, HIGH);
delay(1);
digitalWrite(3, LOW);

}

if (a == "setBrightness")
{
/*BRIGHTNESS = comVal.toInt();
FastLED.setBrightness(BRIGHTNESS);
}
digitalWrite(13, LOW);
}*/