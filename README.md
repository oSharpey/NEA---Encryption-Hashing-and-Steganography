# NEA---Encryption-Hashing-and-Steganography
NEA Project for A Level comp sci

## Overview 

The main purpose of this project is to demonstrate and teach about different types of cryptography and how cryptography has developed over time. 

The key aspects of my project are the different encryption methods that make up the learning aspect of the program, the hash function, enigma sim, caesar and atbash ciphers and steganography. Although all of the key aspects of the program are independent from one another, they are all necessary to build the picture of how cryptography has developed. 

Each one of the encryption methods is accessible via the main menu form with each of the encryption methods being handled with one or more classes. This allows each encryption method to be independent of each other allowing the user to learn about each method separately without being bound by having to understand multiple methods at once. It also means that you cannot have more than 1 cryptography method open at once, this was a conscious decision as due to the amount of classes that would have to be instantiated for all the forms to be open at once may cause memory and performance issues. This is especially prevalent on older machines like those in schools, where my program will most likely run. It ensures all systems will be able to run my program. The hierarchy chart also gives you an idea of what the call stack would look like. Having the elements lowest down on the graph being higher up on the call stack. As is quite obvious in the graph that there is not much vertical branching, this reduces the risk of the call stack exceeding the stack buffer causing a stack overflow.  Although it is not shown in this diagram, it is important to note that the main menu is also accessible from each of the different forms in the program, as well as having each form accessible from the main menu. This traversal of my program is very important as it means that my program does not finish executing when it reaches the end of a branch. This was a problem in the first draft of my GUI.

## Choice of Language And Libraries 

Before I started coding my cryptography methods I needed to decide on a programming language to use, specifically a high level language. Although I had some experience with coding in python I decided it would not be suitable for my use case. I ended up going with Visual Basic as I am much more familiar with the language. Visual Basic also has some very useful features for my project, its compatibility with windows forms allowed me to use a graphical user interface (GUI) for my project. This was very important for the steganography portion of my project, if i was only limited to the console it would have been very difficult to display an image to the user which is the main point of that element. 

Visual Basic also has a very intuitive class system which will allow me to very efficiently code the classes I need for my program, especially for the Enigma Simulator.

For my program I decided to use a library called ‘FontAwesome.Sharp’. This gave me useful GUI features like icon buttons which I implemented into the main menu sidebar.

## SHA 256 Hash Function

For the hash function I will be using the SHA-256 Hash function. The SHA256 hash function scrambles a given message to make it completely unreadable, producing a 256 bit long digest hence the name.

## Enigma

The Enigma Machine was a physical device used in WW2 by the Germans to encrypt messages. It used a series of rotors, a reflector and a plugboard to encrypt and decrypt messages based on a selection of daily settings. 

### The Rotors

Each rotor takes in a letter input and outputs a different letter based on the position of the rotors at the time, after each letter on the keyboard was pressed the rotor shifted 1 letter. This removed the vulnerability of letter frequencies as an A could be encoded as F or a Q, for example, in the same message. When the first rotor has turned through all 26 positions, the second rotor clicks round, and when that’s made it round all the way, the third does the same, leading to more than 17,000 different combinations before the encryption process repeats itself.

The rotors also had a second layer of security, the ring setting or Ringstellung in German. This allowed you to change the internal wiring of the rotor. For example, where rotor I in the A-position normally encodes an A into an E, with a ring setting offset B-02 it will be encoded into K


### The Plugboard

The plugboard’s job is to simply switch a letter to another letter by hooking them up with a wire.

Say you have the plugboard set up as shown above, before the electrical signal goes through the rotors it gets sent through the plugboard. For example, if the user hit the letter ‘A’ on the keyboard the signal would be sent to the plugboard and it would be switched into a ‘Z’, if you pressed ‘C’ it would be changed to a ‘H’. The enigma allowed for 10 possible letter pairs which means there are around 150,000,000,000,000 different combinations of letters. 

This physical pairing is achieved through code by the use of a dictionary that gets created by the user's specified plugboard pairing. The letter would get passed into the dictionary and the paired letter would be returned to be passed into the rotors. 

### The Reflector

In the physical machine, at the opposite end of the rotor is something called the reflector which causes the circuit to follow paths back through the rotors. Similarly to the plugboard the reflector consisted of pairs of letters, so if the signal in position ‘A’ got passed into the reflector the signal could be changed to a ‘H’ for example. Exactly like the plugboard this is also handled by a dictionary. 

### Rotating The Rotors

Each rotor has a set notch corresponding to a letter on the wheel. The notches are designed in a way where once the notch on one rotor is reached it links up with the rotor to the left and rotates both itself and the rotor to the left. This mechanism helped ensure that the machine kept changing the encryption settings further and further with each key press.


## Steganography 

### Encoding the message into the image

The method of steganography I used is least significant bit (LSB) steganography. This method hides each bit of the message into the least significant bit of the target image. 

An image would be imported into my program and then the user would be able to enter the message they want hidden, this aspect is further developed in the GUI section of the chapter

Once the image has been imported into the program, the code reads the pixel data for each pixel in the image. 

For example the pixel in the (0,0) position has an RGB value of : (139, 95, 60) which in binary is: 


**R: 10001011**

**G: 01011111**

**B: 00111100**


The program will then convert the message into binary, for example ‘Hi’ would become: **01001000 01101001**

Starting from the first bit in the message, the program takes the first 7 bits of the each colour value and adds one bit of the message onto the end, this produces a new red colour value that can be added to a new image 

**1000101 + 0 → 10001010,   0101111 + 1 → 01011111,   0011110 + 0 → 00111100**

This creates a new pixel value of (138, 95, 60) with the LSBs containing the first 3 bits of the message, **010**

However  we don’t just encode the message typed into the image, we have to add a delimiter to the end of the message we want to encode. This is usually an uncommon ASCII character like a ~. So instead of ‘Hi’ being encoded ‘Hi~’ is encoded in binary this would look like: 

**01001000 01101001 01111110**

Having this at the end of the message allows the program to not have to loop through the entire image. Once the delimiter is reached, the program exits out of the for loop, making the algorithm much faster and saving computational resources. 

### Extracting the message into the image

Unlike encoding the message into the image, when we extract the message from the image we don't have to physically change the image, only read the data from each pixel. Specifically the least significant bit of each value in each pixel of the image. 

Lets take the image we encoded a message into before in this section. 

The pixel at position (0,0) now has the RGB value of 

(138, 95, 60). In binary this is shown as: 


**R: 10001010**

**G: 01011111**

**B: 00111100**


To extract the data out of each value in the pixel, we would convert the red, green and blue values to a binary string and then read the least significant bits of each value in the pixel. After the value is read it gets added to a new binary string which will contain the message. After 8 bits of data from the image are extracted, the program will convert that into an ASCII character. This newly converted character is then checked to see if it matches the delimiter If it matches the program exits the for loop and displays the message, if it does not match the program will repeat the process with another 8 bits.  

For example if you encoded ‘Hi’ into the image, the message in binary would look like (the last 8 bits are the delimiter ‘~’: 

**01001000 01101001 01111110**
