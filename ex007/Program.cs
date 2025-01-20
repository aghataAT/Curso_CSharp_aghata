namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
# Solicitar a velocidade do carro velocidade = float(input("Digite a velocidade do carro em km/h: ")) # Definir o limite de velocidade limite = 80 multa_por_km = 7.00 # Verificar se a velocidade ultrapassa o limite if velocidade > limite: # Calcular a multa excesso = velocidade - limite multa = excesso * multa_por_km print(f"Você foi multado! A multa é de R${multa:.2f} por exceder {excesso:.2f} km/h do limite.") else: print("Você está dentro do limite de velocidade. Boa viagem!")

        }
    }
}
