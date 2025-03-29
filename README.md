

# 🎸 MusicBox – An Interactive Instrument Shop Console Application  

---

**MusicBox** is an interactive C# **console application** that simulates a **music instrument shop**, allowing users to explore and play various instruments. This project showcases key **Object-Oriented Programming (OOP)** principles through an engaging and user-friendly interface.  

### ✨ Key OOP Concepts Demonstrated:
- ✅ **Encapsulation** – Protecting data using private fields with public properties.  
- ✅ **Inheritance** – Establishing a class hierarchy with base and derived classes.  
- ✅ **Polymorphism** – Overriding methods to customize behavior in child classes.  
- ✅ **Object Creation** – Instantiating objects from both base and derived classes.  

---

## 📺 **Program Demo**  

Check out the **MusicBox** Instrument Store in action! 🎶  
Click the link below to see the interactive console application, including the instrument selection and audio playback:  

[**🎥 MusicBox Demo - Nicko James E. Barata - Lab Exercise 2**](https://youtu.be/JAhx2Ega_mA)

---

## 📂 Class Structure  
![instrument_class_heirarchy](https://github.com/user-attachments/assets/5089254e-a24a-4f42-b3ed-012f63c6da10)

---

## 📖 Class Descriptions  

### 🎼 `Instrument` (Base Class)  

- **Fields (Encapsulated):**  
  - `string _brand` – Instrument brand  
  - `string _model` – Instrument model  
  - `double _price` – Instrument price  
  - `string _sampleFile` – Path to the sample sound file  

- **Methods:**  
  - `GetInfo()` – Displays instrument details  
  - `GetDescription()` – Returns a generic description ("Instruments make you feel more alive!")  
  - `Play()` – Simulates playing the instrument using sound files  

---

## 🎸 `Guitar` (Derived from Instrument)  

- **Additional Field:**  
  - `int _numberOfStrings` – Number of guitar strings  

- **Overridden Methods:**  
  - `Play()` – Plays an audio of a guitar sound  
  - `GetDescription()` – Returns a description of the guitar  

---

### 🎶 `AcousticGuitar` (Derived from Guitar)  

- **Unique Feature:**  
  - Simulates a warm, resonant sound of an acoustic guitar.  

- **Overridden Methods:**  
  - `Play()` – Plays an audio of an acoustic guitar sound  
  - `GetDescription()` – Returns a description of the acoustic guitar  

---

### 🎶 `ElectricGuitar` (Derived from Guitar)  

- **Unique Feature:**  
  - Emulates the amplified, distorted sound of an electric guitar.  

- **Overridden Methods:**  
  - `Play()` – Plays an audio of an electric guitar sound  
  - `GetDescription()` – Returns a description of the electric guitar  

---

### 🎶 `Ukulele` (Derived from Guitar)  

- **Unique Feature:**  
  - Simulates the light and cheerful sound of a ukulele.  

- **Overridden Methods:**  
  - `Play()` – Plays an audio of a ukulele sound  
  - `GetDescription()` – Returns a description of the ukulele  

---

## 🎹 `Piano` (Derived from Instrument)  

- **Additional Field:**  
  - `int _numberOfKeys` – Number of piano keys  

- **Overridden Methods:**  
  - `Play()` – Plays an audio of a piano sound  
  - `GetDescription()` – Returns a description of the piano  

---

### 🎼 `GrandPiano` (Derived from Piano)  

- **Unique Feature:**  
  - Simulates the rich, full-bodied sound of a grand piano.  

- **Overridden Methods:**  
  - `Play()` – Plays an audio of a grand piano sound  
  - `GetDescription()` – Returns a description of the grand piano  

---

### 🎼 `Keyboard` (Derived from Piano)  

- **Unique Feature:**  
  - Mimics the versatile electronic sounds of a keyboard.  

- **Overridden Methods:**  
  - `Play()` – Plays an audio of a keyboard sound  
  - `GetDescription()` – Returns a description of the keyboard  

---

### 🎼 `Organ` (Derived from Piano)  

- **Unique Feature:**  
  - Emulates the deep, harmonic tones of an organ.  

- **Overridden Methods:**  
  - `Play()` – Plays an audio of an organ sound  
  - `GetDescription()` – Returns a description of the organ  

---

## 🥁 `Drums` (Derived from Instrument)  

- **Additional Field:**  
  - `string _drumType` – Type of drum  

- **Overridden Methods:**  
  - `Play()` – Plays an audio of a drum sound  
  - `GetDescription()` – Returns a description of the drum  

---

### 🥁 `SnareDrum` (Derived from Drums)  

- **Unique Feature:**  
  - Simulates the sharp, crisp sound of a snare drum.  

- **Overridden Methods:**  
  - `Play()` – Plays an audio of a snare drum sound  
  - `GetDescription()` – Returns a description of the snare drum  

---

### 🥁 `BassDrum` (Derived from Drums)  

- **Unique Feature:**  
  - Mimics the deep, low-frequency thump of a bass drum.  

- **Overridden Methods:**  
  - `Play()` – Plays an audio of a bass drum sound  
  - `GetDescription()` – Returns a description of the bass drum  

---

### 🥁 `TomToms` (Derived from Drums)  

- **Unique Feature:**  
  - Emulates the resonant, melodic tones of tom-tom drums.  

- **Overridden Methods:**  
  - `Play()` – Plays an audio of a tom-tom drum sound  
  - `GetDescription()` – Returns a description of the tom-tom drums  


---

## 🚀 Interactive Features  

✅ **Browse Instruments** – Explore available guitars, pianos, and drums.  
✅ **Play Instrument Samples** – Simulate the sound of each instrument using **.wav audio files** for a more interactive experience.  
✅ **Read Descriptions** – Learn unique characteristics of each instrument.  

---

## 📊 Example Output  
![image](https://github.com/user-attachments/assets/82033650-bcd7-4dbd-8539-8f494b7840bb)
![image](https://github.com/user-attachments/assets/df1d8745-dd2c-40c6-a56f-6f0849117a6c)
![image](https://github.com/user-attachments/assets/02cdbbcd-1f81-4356-bf88-0a2a7515f2a6)
![image](https://github.com/user-attachments/assets/fed6a223-a5e1-4525-9099-9be0d7f6e472)


---

## 📋 Requirements  

a. **The base class should have at least 2 private fields, 2 public methods, and a constructor.** Use getters and setters to access and modify the private fields (Encapsulation).  
- ✅ Achieved: The `Instrument` base class has 4 private fields (`brand`, `model`, `price`, `sampleFile`), 2 public methods (`GetDescription()` and `Play()`), and a constructor.  

b. **The derived class should inherit from the base class (Inheritance).** Add at least 1 additional field and 1 additional method specific to the derived class. Override at least 1 method from the base class.  
- ✅ Achieved: The `Guitar`, `Piano`, and `Drums` classes inherit from `Instrument`. Each derived class adds at least 1 additional field and 1 method, and overrides the `Play()` method.  

c. **Write a simple main method to demonstrate the use of both classes.** Showcase method overriding, encapsulated data access, and the creation of objects using both the base and derived classes.  
- ✅ Achieved: A simple `Main` method demonstrates creating objects from both the base (`Instrument`) on line 373-374 and derived classes on line 377-459, showcasing method overriding, encapsulated data access, and object creation.


