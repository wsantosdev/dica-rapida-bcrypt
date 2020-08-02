using System;
using BCrypt.Net;
using static BCrypt.Net.BCrypt;

namespace DicaRapida.Bcrypt.Password
{
    class Program
    {
        private const int WorkFactor = 12;

        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua nova senha: ");
            var cleanPassword = Console.ReadLine();
            var hashedPassword = HashPassword(cleanPassword, WorkFactor);
            Console.WriteLine($"O hash para sua senha é: {hashedPassword}");
            
            Console.WriteLine("Confirme sua nova senha: ");
            var passwordsMatch = Verify(Console.ReadLine(), hashedPassword);
            Console.WriteLine($"A verificação foi {(passwordsMatch ? "positiva" : "negativa")}");
        }
    }
}
