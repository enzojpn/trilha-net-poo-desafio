using DesafioPOO.Models;

Nokia nokia = new Nokia("1234", "A42", "aj314r99", 4);
Iphone iphone = new Iphone("4321", "iphone5", "135m0329", 8);

nokia.ReceberLigacao();
iphone.ReceberLigacao();

nokia.InstalarAplicativo("Instragram");
iphone.InstalarAplicativo("DetranSP");

nokia.Ligar();
iphone.Ligar();