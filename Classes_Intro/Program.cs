using Classes_Intro;

Parrot parrot = new Parrot();
parrot.Name = "Denny";
parrot.OwnerName = "Sofia";
Console.WriteLine(parrot.SayHello(parrot));   
Parrot parrot2 = new Parrot("Kesha", "Alina");
Console.WriteLine(parrot.SayHello(parrot2));
