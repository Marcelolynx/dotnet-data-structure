
 static void Main(string[] args)
{
    var frase = "  C# é uma linguagem de programação orientada a objetos.  " + 
                "Com C# é possível criar aplicativos para Windows, Web, " +
                "serviços e dispositivos móveis.  ";
    
    var tamanho = frase.Length;

    var vazio = string.Empty;
    
    var paragrafoMinusculo = frase.ToLower();
    var paragrafoMaiusculo = frase.ToUpper();
    
    var paragrafoSplit = frase.Split(' ');
    
    var isNullOrWhiteSpace = string.IsNullOrWhiteSpace(frase);
    
    var paragrafoCsharp = frase.Replace("C#", "C Sharp");
    
    Console.WriteLine("Tamanho da frase: " + tamanho);
    Console.WriteLine("Frase vazia: " + vazio);
    Console.WriteLine("Frase minuscula: " + paragrafoMinusculo);
    Thread.Sleep(5000);
    Console.WriteLine("Frase maiuscula: " + paragrafoMaiusculo);
    Console.WriteLine("Frase split: " + paragrafoSplit);
    Console.WriteLine("Frase isNullOrWhiteSpace: " + isNullOrWhiteSpace);
    Console.WriteLine("Frase replace: " + paragrafoCsharp);
    
}