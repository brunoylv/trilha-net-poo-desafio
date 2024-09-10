using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program{

static void Main(string[] args){

Nokia MeuNokia = new Nokia("99836-4587", 128, "00132/21445/50024/02", "Nokia N-2024");

Iphone MeuIphone = new Iphone("99857-2364", 512, "47732/56858/02268/05", "Iphone 15");

MeuNokia.ExibirInformacoes();

MeuIphone.ExibirInformacoes();

MeuIphone.InstalarAplicativo("Apple Music");

MeuIphone.InstalarAplicativo("Netflix");

MeuNokia.InstalarAplicativo("Threads");

MeuNokia.InstalarAplicativo("Prime Video");

MeuNokia.InstalarAplicativo("Spotify");

MeuNokia.InstalarAplicativo("Bluesky");



}
}