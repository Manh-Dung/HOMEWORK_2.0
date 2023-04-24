from gtts import gTTS
import playsound
import os
import time

def text_to_speech(text):
    tts = gTTS(text=text, lang='en')
    fileName = 'output.mp3'
    tts.save(fileName)
    playsound.playsound(fileName)
    os.remove(fileName) 
text_to_speech("Hello, this is a sample text to speech conversion")

