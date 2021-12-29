# ZombiePatientUDP
Project Description: 

The aim of this project is to develop game-like tasks in Unity for patients to complete with the aim of helping them restore their balance as the TPAD (medical robotic device) fixes their posture.

The game/task will be projected on a screen, while the markers are attached to a patient’s hands to control the cursor on the screen. The game is designed so that the patient’s movement is fixed in conjunction with the TPAD fixing their posture.

The aim of the game is to beat the zombie. The zombie on the screen approaches the patient by walking towards them; this signals to the patient that it is time to stand up as the TPAD helps them with their movement. Once the patient has stood up and the zombie stops walking, they can start attacking the zombie. The patient can attack the zombie by moving their hand and placing it over the zombie’s head — the movement being synchronized with the marker on their hand. If they miss, and aim for the zombie’s body instead, the zombie gets visibly angry. If they aim correctly, the zombie flies back, and a counter maintains how many they got right.

Running the Project: 

The ZombiePatientUDP project uploaded in this repository is the version that works with the TPAD, which uses a UDP connection to transfer the positions of the hand markers to the unity project through a program called LabVIEW.

To view the version that works with the computer’s mouse or trackpad, go to the ZombiePatientCursor repository, which can be run locally from a computer machine (without the need of a TPAD and hand markers). The cursor can be controlled with a mouse or trackpad.

To run the project, you will need access to the TPAD in a medical center, hand markers, and LabVIEW, in addition to downloading Unity, importing the project, and then running it.

The video below demonstrates the version that utilizes the position of the hand markers sent through a UDP connection from LabVIEW. The video only demonstrates that the data points/ positions are correctly sent and can control the behavior of the zombie. To view the full functionality of the project, go watch the video under the ZombiePatientCursor repository that shows the full game, although through the control of the mouse and/or trackpad.

https://user-images.githubusercontent.com/78284219/147650451-927de812-75cf-498b-85a9-a32461b89d39.mp4


