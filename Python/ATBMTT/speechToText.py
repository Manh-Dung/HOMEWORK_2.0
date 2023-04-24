import playsound  # 1.2.2
from gtts import gTTS
import speech_recognition as sr
import os
import time

r = sr.Recognizer()


def textToSpeech(text):
    tts = gTTS(text=text, lang='vi')
    fileName = 'output.mp3'
    tts.save(fileName)
    playsound.playsound(fileName)
    os.remove(fileName)


with sr.Microphone() as source:
    print("Nói")
    audio_text = r.listen(source, 2)

    print("Rồi! Dừng!")

    recognized_text = r.recognize_google(audio_text, language='vi-VN')
    print("Text: " + recognized_text)
    textToSpeech(recognized_text)
