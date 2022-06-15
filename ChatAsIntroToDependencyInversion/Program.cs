/*
 * 1: Lage eksempel ChatClient og ChatServer
 * 2: Vise hvordan gjensidig avhengighet gjør at de to klassene ikke kan deles i ulike prosjekter
 * 3: Dependency Inversion Principle generelt
 * 4: Dependency Inversion Principle for ChatServer og ChatClient
 * 5: Løsningen - et interface!
 * 6: Skrive om koden med interface
 */

using ChatAsIntroToDependencyInversion;

var server = new ChatServer();

var client1 = new ChatClient("Per", server);
var client2 = new ChatClient("Pål", server);
var client3 = new ChatClient("Espen", server);

client1.Say("Hello");
// Pål og Espen får beskjed "Per sier Hello"

client2.Say("Hello");
// Per og Espen får beskjed "Pål sier Hello"

client3.Say("Hello");
// Per og Pål får beskjed "Espen sier Hello"