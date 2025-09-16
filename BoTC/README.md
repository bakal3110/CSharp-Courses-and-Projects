For developing a game in C#, you can use several packages and libraries that can help with networking and room creation. Here's a general guide to get you started:

Networking in C#
Network Library:

Socket Programming: You can use the System.Net.Sockets namespace for low-level network programming.
SignalR: This is a library for ASP.NET that simplifies the process of adding real-time web functionality to applications. It can be used to create connections between a server and multiple clients.
Game Development Frameworks:

Unity: While primarily a game engine, Unity allows you to use C# and has integrated networking support. You can use Unity's multiplayer networking solutions such as Unity Networking (UNet) or third-party solutions like Photon.
Data Serialization:

JSON.NET: Useful for serializing and deserializing data that you might want to send over the network.
Protobuf: A more efficient way to serialize structured data for network communication.
Steps to Create a Room-Based Game
Server Setup:

Use either a dedicated server application using System.Net.Sockets or host a small web server using SignalR if you prefer a higher-level API.
The server will manage room creation and handle connections.
Client Connection:

Implement a client app that connects to the server via TCP/IP or through HTTP/WebSockets if using SignalR.
Ensure client devices (phones) have authentication methods to securely join rooms.
Room Management:

Design a system to create, join, and leave rooms. This includes handling user sessions and game state synchronization.
Game Logic:

Implement game logic to be processed on the server or distribute it across clients depending on your game design.
Testing and Debugging:

Test connectivity and data transfer between devices.
Debug issues related to latency and synchronization.
Resources for Learning
Online Tutorials: Look for tutorials specific to networking in C# on platforms like YouTube or Udemy.
Official Documentation: Review the documentation for libraries like SignalR or any chosen networking package.
Community Forums: Participate in community forums such as Stack Overflow or Unity Forums for practical advice and problem-solving.
Books: Consider books on C# that focus on game development or networking.
Feel free to ask more detailed questions if you need further assistance on any specific part!
