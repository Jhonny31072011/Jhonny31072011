using System;
using System.Globalization;
using System.Threading;

class MenuExercicios
{
    static void Main()
    {
        int opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    MENU DE EXERCÍCIOS - PROGRAMAÇÃO EM C#                      ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n📋 SLIDE - MENU GERAL DE EXERCÍCIOS");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("1  - Soma dos Pares: soma números pares fornecidos pelo usuário até negativo");
            Console.WriteLine("2  - Contador Maior que 100: conta quantos números maiores que 100 são inseridos");
            Console.WriteLine("\n📊 BÁSICO - OPERAÇÕES FUNDAMENTAIS");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("3  - Entrada e Saída: lê nome e ano, calcula e exibe idade do usuário");
            Console.WriteLine("4  - Inversão de Números: lê dois números e exibe-os em ordem invertida");
            Console.WriteLine("5  - Salário com Desconto: calcula salário bruto, descontos e salário líquido");
            Console.WriteLine("6  - Conversor Celsius-Fahrenheit: converte temperatura de graus Celsius");
            Console.WriteLine("7  - Média Aritmética: calcula média entre dois valores inseridos");
            Console.WriteLine("8  - Conversor Km/h para m/s: converte velocidade de quilômetros para metros");
            Console.WriteLine("9  - Salário com Previdência: calcula descontos de previdência e imposto");
            Console.WriteLine("10 - Inversor de Algarismos: inverte um número de 3 dígitos automaticamente");
            Console.WriteLine("\n⚡ CONDICIONAIS - IF/ELSE E SWITCH");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("11 - Aumento Condicional de Salário: se salário ≤ 150, adiciona 30 reais");
            Console.WriteLine("12 - Aprovação/Reprovação: valida média de notas (maior/igual 7 aprovado)");
            Console.WriteLine("13 - Comparador de Números: compara dois números e indica o maior ou iguais");
            Console.WriteLine("14 - Dias da Semana: exibe dia da semana baseado em número de 1 a 7");
            Console.WriteLine("15 - Validador de Vogais: identifica se uma letra é vogal ou consoante");
            Console.WriteLine("16 - Menu de Produtos: exibe código, nome e preço de lanches com seleção");
            Console.WriteLine("17 - Selecionador de Classe RPG: escolhe classe e exibe item inicial");
            Console.WriteLine("18 - Avaliador de Atendimento: classifica avaliação de 1 a 5 do restaurante");
            Console.WriteLine("19 - Conversor de Números: transforma número (1-5) para extenso por switch");
            Console.WriteLine("20 - Calculadora Básica: realiza operações (+, -, *, /) com validação divisão");
            Console.WriteLine("21 - Classificador de Idade: categoriza idade em infantil, juvenil ou sênior");
            Console.WriteLine("22 - Menu Lanchonete: seleciona produto, quantidade e calcula total a pagar");
            Console.WriteLine("23 - Calculador de Imposto: aplica taxa de imposto por estado (SP,RJ,MG,ES)");
            Console.WriteLine("24 - Calculador de Peso Planetário: calcula peso em diferentes planetas");
            Console.WriteLine("25 - Estações do Ano: exibe estação conforme número do mês (1-12)");
            Console.WriteLine("\n💰 DESAFIO RH - SISTEMA COMPLETO");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("26 - Sistema de RH TechCorp: calcula salário final com bônus por cargo");
            Console.WriteLine("\n🔄 LOOPS - WHILE E DO-WHILE");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("27 - Soma de Números Menores 20: soma valores até 0, ignorando maiores");
            Console.WriteLine("28 - Média de Idades: calcula média de idades até inserir número negativo");
            Console.WriteLine("29 - Validador de Senha: solicita senha até acertar a correta (1234)");
            Console.WriteLine("30 - Maior Número: encontra o maior entre vários números inseridos");
            Console.WriteLine("31 - Validador de Notas: valida nota entre 0-10 com tentativas ilimitadas");
            Console.WriteLine("32 - Menu Interativo While: menu simples com opções (Olá, Ano, Sair)");
            Console.WriteLine("33 - Contagem Regressiva: conta de trás para frente com som de foguete");
            Console.WriteLine("34 - Somador com Acumulador: soma números inseridos até digitar 0");
            Console.WriteLine("\n0  - SAIR DO PROGRAMA");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════");
            Console.Write("\nDigite a opção desejada: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("❌ Opção inválida! Tente novamente.");
                Console.ReadKey();
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    SomaDosParesSlide();
                    break;
                case 2:
                    Console.Clear();
                    ContadorMaiorQue100Slide();
                    break;
                case 3:
                    Console.Clear();
                    EntradaSaida();
                    break;
                case 4:
                    Console.Clear();
                    InversaoDois();
                    break;
                case 5:
                    Console.Clear();
                    SalarioComDesconto();
                    break;
                case 6:
                    Console.Clear();
                    ConversorCelsiusFahrenheit();
                    break;
                case 7:
                    Console.Clear();
                    MediaAritmetica();
                    break;
                case 8:
                    Console.Clear();
                    ConversorVelocidade();
                    break;
                case 9:
                    Console.Clear();
                    SalarioComPrevidencia();
                    break;
                case 10:
                    Console.Clear();
                    InversorAlgarismos();
                    break;
                case 11:
                    Console.Clear();
                    AumentoCondicional();
                    break;
                case 12:
                    Console.Clear();
                    AprovacaoReprovacao();
                    break;
                case 13:
                    Console.Clear();
                    ComparadorNumeros();
                    break;
                case 14:
                    Console.Clear();
                    DiasDaSemana();
                    break;
                case 15:
                    Console.Clear();
                    ValidadorVogais();
                    break;
                case 16:
                    Console.Clear();
                    MenuProdutos();
                    break;
                case 17:
                    Console.Clear();
                    SeletorClasseRPG();
                    break;
                case 18:
                    Console.Clear();
                    AvaliadorAtendimento();
                    break;
                case 19:
                    Console.Clear();
                    ConversorNumeros();
                    break;
                case 20:
                    Console.Clear();
                    CalculadoraBasica();
                    break;
                case 21:
                    Console.Clear();
                    ClassificadorIdade();
                    break;
                case 22:
                    Console.Clear();
                    MenuLanchonete();
                    break;
                case 23:
                    Console.Clear();
                    CalculadorImposto();
                    break;
                case 24:
                    Console.Clear();
                    CalculadorPesoPlanetario();
                    break;
                case 25:
                    Console.Clear();
                    EstacoesAno();
                    break;
                case 26:
                    Console.Clear();
                    SistemaRHTechCorp();
                    break;
                case 27:
                    Console.Clear();
                    SomaMenor20();
                    break;
                case 28:
                    Console.Clear();
                    MediaIdades();
                    break;
                case 29:
                    Console.Clear();
                    ValidadorSenha();
                    break;
                case 30:
                    Console.Clear();
                    MaiorNumero();
                    break;
                case 31:
                    Console.Clear();
                    ValidadorNotas();
                    break;
                case 32:
                    Console.Clear();
                    MenuInterativoWhile();
                    break;
                case 33:
                    Console.Clear();
                    ContagemRegressiva();
                    break;
                case 34:
                    Console.Clear();
                    SomadorAcumulador();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║                      OBRIGADO POR USAR O MENU! ATÉ LOGO! 👋                   ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════╝");
                    return;
                default:
                    Console.WriteLine("❌ Opção inválida! Tente novamente.");
                    Console.ReadKey();
                    break;
            }
        } while (true);
    }

    // ==================== EXERCÍCIOS SLIDE ====================
    static void SomaDosParesSlide()
    {
        Console.WriteLine("📌 SOMA DOS PARES");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int numero;
        int soma = 0;

        Console.Write("Informe um número (negativo para sair): ");
        numero = int.Parse(Console.ReadLine());

        do
        {
            if (numero >= 0 && numero % 2 == 0)
            {
                soma = soma + numero;
            }
            Console.Write("Informe um número (negativo para sair): ");
            numero = int.Parse(Console.ReadLine());
        } while (numero >= 0);

        Console.WriteLine($"\n✅ A soma dos pares é: {soma}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ContadorMaiorQue100Slide()
    {
        Console.WriteLine("📌 CONTADOR MAIOR QUE 100");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int numero;
        int contador = 0;

        Console.Write("Digite um número inteiro (0 para SAIR): ");
        numero = int.Parse(Console.ReadLine());

        do
        {
            if (numero > 100)
            {
                contador++;
            }
            if (numero != 0)
            {
                Console.Write("Digite um número inteiro (0 para SAIR): ");
                numero = int.Parse(Console.ReadLine());
            }
        } while (numero != 0);

        Console.WriteLine($"\n✅ A quantidade de números maiores que 100 é: {contador}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    // ==================== EXERCÍCIOS BÁSICOS ====================
    static void EntradaSaida()
    {
        Console.WriteLine("📌 ENTRADA E SAÍDA - CÁLCULO DE IDADE");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        string nome;
        int ano;

        Console.Write("Informe seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Informe seu ano de nascimento: ");
        ano = int.Parse(Console.ReadLine());

        int idade = 2026 - ano;

        Console.WriteLine($"\n✅ Bom dia, {nome}, seja bem-vindo!");
        Console.WriteLine($"{nome}, você tem {idade} anos!");
        Console.WriteLine($"Ano que vem você fará {idade + 1} anos!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void InversaoDois()
    {
        Console.WriteLine("📌 INVERSÃO DE DOIS NÚMEROS");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int numA, numB;

        Console.Write("Informe o primeiro número: ");
        numA = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        numB = int.Parse(Console.ReadLine());

        Console.WriteLine($"\n✅ Os números que você digitou foram: {numB} e {numA}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void SalarioComDesconto()
    {
        Console.WriteLine("📌 CÁLCULO DE SALÁRIO COM DESCONTO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        double HT, VH, PD, SB, TD, SL;

        Console.Write("Informe a quantidade de horas trabalhadas no mês: ");
        HT = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor da hora trabalhada: ");
        VH = double.Parse(Console.ReadLine());
        Console.Write("Informe o percentual de desconto: ");
        PD = double.Parse(Console.ReadLine());

        SB = HT * VH;
        TD = (PD / 100) * SB;
        SL = SB - TD;

        Console.WriteLine("\n╔════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                        ✅ RESUMO                             ║");
        Console.WriteLine("╠════════════════════════════════════════════════════════════════╣");
        Console.WriteLine($"║ Horas trabalhadas: {HT} horas");
        Console.WriteLine($"║ Salário Bruto: R$ {SB:F2}");
        Console.WriteLine($"║ Total de descontos: R$ {TD:F2}");
        Console.WriteLine($"║ Salário Líquido: R$ {SL:F2}");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ConversorCelsiusFahrenheit()
    {
        Console.WriteLine("📌 CONVERSOR CELSIUS PARA FAHRENHEIT");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        double C, F;

        Console.Write("Informe a temperatura em Graus Celsius: ");
        C = double.Parse(Console.ReadLine());

        F = (9 * C + 160) / 5;

        Console.WriteLine($"\n✅ {C}° Graus Celsius são {F}° Fahrenheit");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void MediaAritmetica()
    {
        Console.WriteLine("📌 CÁLCULO DE MÉDIA ARITMÉTICA");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        double val1, val2, media;

        Console.Write("Informe o primeiro valor: ");
        val1 = double.Parse(Console.ReadLine());
        Console.Write("Informe o segundo valor: ");
        val2 = double.Parse(Console.ReadLine());

        media = (val1 + val2) / 2;

        Console.WriteLine($"\n✅ A média entre {val1} e {val2} é {media}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ConversorVelocidade()
    {
        Console.WriteLine("📌 CONVERSOR VELOCIDADE KM/H PARA M/S");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        double velocidadeKmh, velocidadems;

        Console.Write("Informe a velocidade em m/s: ");
        velocidadems = double.Parse(Console.ReadLine());

        velocidadeKmh = velocidadems / 3.6;

        Console.WriteLine($"\n✅ {velocidadems} m/s são {velocidadeKmh} Km/h");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void SalarioComPrevidencia()
    {
        Console.WriteLine("📌 SALÁRIO COM PREVIDÊNCIA SOCIAL E IMPOSTO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        double SB, PrevSocial, Imposto, SL;

        Console.Write("Informe o seu salário bruto: ");
        SB = double.Parse(Console.ReadLine());

        PrevSocial = SB * 0.10;
        Imposto = (SB - PrevSocial) * 0.05;
        SL = SB - PrevSocial - Imposto;

        Console.WriteLine("\n╔════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                    ✅ RESUMO FINAL                           ║");
        Console.WriteLine("╠════════════════════════════════════════════════════════════════╣");
        Console.WriteLine($"║ Salário Bruto: R$ {SB:F2}");
        Console.WriteLine($"║ Previdência Social: R$ {PrevSocial:F2}");
        Console.WriteLine($"║ Imposto: R$ {Imposto:F2}");
        Console.WriteLine($"║ Salário Líquido: R$ {SL:F2}");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void InversorAlgarismos()
    {
        Console.WriteLine("📌 INVERSOR DE 3 ALGARISMOS");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int N, C, D, U, M;

        Console.Write("Informe um número com 3 algarismos: ");
        N = int.Parse(Console.ReadLine());

        C = N / 100;
        D = (N % 100) / 10;
        U = (N % 100) % 10;

        M = (U * 100) + (D * 10) + C;

        Console.WriteLine($"\n✅ O número inverso é: {M}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    // ==================== CONDICIONAIS ====================
    static void AumentoCondicional()
    {
        Console.WriteLine("📌 AUMENTO CONDICIONAL DE SALÁRIO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        string nome;
        double salario;

        Console.Write("Informe seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Informe o seu salário: ");
        salario = double.Parse(Console.ReadLine());

        if (salario <= 150)
        {
            salario = salario + 30;
        }

        Console.WriteLine($"\n✅ {nome}, seu novo salário é: R$ {salario:F2}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void AprovacaoReprovacao()
    {
        Console.WriteLine("📌 APROVAÇÃO/REPROVAÇÃO POR MÉDIA");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        double nota1, nota2, nota3, media;

        Console.Write("Informe a sua 1ª nota: ");
        nota1 = double.Parse(Console.ReadLine());
        Console.Write("Informe a sua 2ª nota: ");
        nota2 = double.Parse(Console.ReadLine());
        Console.Write("Informe a sua 3ª nota: ");
        nota3 = double.Parse(Console.ReadLine());

        media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7)
        {
            Console.WriteLine($"\n✅ Aluno APROVADO com média {media:F2}");
        }
        else
        {
            Console.WriteLine($"\n❌ Aluno REPROVADO com média {media:F2}");
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ComparadorNumeros()
    {
        Console.WriteLine("📌 COMPARADOR DE NÚMEROS");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int num1, num2;

        Console.Write("Informe o primeiro valor: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo valor: ");
        num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"\n✅ O número {num1} é o maior!");
        }
        else if (num2 > num1)
        {
            Console.WriteLine($"\n✅ O número {num2} é o maior!");
        }
        else
        {
            Console.WriteLine($"\n✅ Os números {num1} e {num2} são iguais!");
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void DiasDaSemana()
    {
        Console.WriteLine("📌 DIAS DA SEMANA");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int numero;

        Console.Write("Informe o número para o dia da semana (1-7): ");
        numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("\n✅ Domingo");
                break;
            case 2:
                Console.WriteLine("\n✅ Segunda-feira");
                break;
            case 3:
                Console.WriteLine("\n✅ Terça-feira");
                break;
            case 4:
                Console.WriteLine("\n✅ Quarta-feira");
                break;
            case 5:
                Console.WriteLine("\n✅ Quinta-feira");
                break;
            case 6:
                Console.WriteLine("\n✅ Sexta-feira");
                break;
            case 7:
                Console.WriteLine("\n✅ Sábado");
                break;
            default:
                Console.WriteLine("\n❌ Número inválido. Informe um número entre 1 e 7.");
                break;
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ValidadorVogais()
    {
        Console.WriteLine("📌 VALIDADOR DE VOGAIS");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        char letra;

        Console.Write("Informe uma letra: ");
        letra = char.ToUpper(Console.ReadLine()[0]);

        switch (letra)
        {
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine("\n✅ A letra é uma VOGAL.");
                break;
            default:
                Console.WriteLine("\n❌ A letra é uma CONSOANTE!");
                break;
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void MenuProdutos()
    {
        Console.WriteLine("📌 MENU DE PRODUTOS");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.WriteLine("Cachorro-Quente.....001");
        Console.WriteLine("X-Salada.....002");
        Console.WriteLine("X-Bacon.....003");
        Console.WriteLine("Bauru.....004");
        Console.WriteLine("Refrigerante.....005");

        Console.Write("\nInforme o código do produto: ");
        double codigoProduto = double.Parse(Console.ReadLine());
        Console.Clear();

        string nomeProduto = "";
        double preço = 0;

        switch (codigoProduto)
        {
            case 1:
                nomeProduto = "Cachorro Quente";
                preço = 10.00;
                break;
            case 2:
                nomeProduto = "X-Salada";
                preço = 15.00;
                break;
            case 3:
                nomeProduto = "X-Bacon";
                preço = 18.00;
                break;
            case 4:
                nomeProduto = "Bauru";
                preço = 12.00;
                break;
            case 5:
                nomeProduto = "Refrigerante";
                preço = 8.00;
                break;
            default:
                Console.WriteLine("\n❌ Código de produto inválido.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
        }

        Console.WriteLine($"\n✅ Produto: {nomeProduto}");
        Console.WriteLine($"💰 Preço: R$ {preço:F2}");
        Console.WriteLine("\n✅ Obrigado pela preferência!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void SeletorClasseRPG()
    {
        Console.WriteLine("📌 SELETOR DE CLASSE RPG");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.WriteLine("Bem-vindo ao mundo de RPG!");
        Console.WriteLine("═════════════════════════════");
        Console.WriteLine("G - Guerreiro");
        Console.WriteLine("M - Mago");
        Console.WriteLine("A - Arqueiro");

        Console.Write("\nDigite a letra correspondente à classe: ");
        string classe = Console.ReadLine().ToUpper();

        switch (classe)
        {
            case "G":
                Console.WriteLine("\n✅ Bem-vindo, Guerreiro! Você começa com uma ESPADA.");
                break;
            case "M":
                Console.WriteLine("\n✅ Bem-vindo, Mago! Você começa com um CAJADO.");
                break;
            case "A":
                Console.WriteLine("\n✅ Bem-vindo, Arqueiro! Você começa com um ARCO.");
                break;
            default:
                Console.WriteLine("\n❌ Opção inválida. Por favor, escolha G, M ou A.");
                break;
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void AvaliadorAtendimento()
    {
        Console.WriteLine("📌 AVALIADOR DE ATENDIMENTO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int numero;

        Console.Write("Informe uma nota de 1 a 5 para avaliar nosso atendimento: ");
        numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("\n✅ Atendimento avaliado como: PÉSSIMO!");
                break;
            case 2:
                Console.WriteLine("\n✅ Atendimento avaliado como: RUIM!");
                break;
            case 3:
                Console.WriteLine("\n✅ Atendimento avaliado como: RAZOÁVEL!");
                break;
            case 4:
                Console.WriteLine("\n✅ Atendimento avaliado como: BOM!");
                break;
            case 5:
                Console.WriteLine("\n✅ Atendimento avaliado como: EXCELENTE!");
                break;
            default:
                Console.WriteLine("\n❌ Nota fora do intervalo. Informe um número entre 1 e 5.");
                break;
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ConversorNumeros()
    {
        Console.WriteLine("📌 CONVERSOR DE NÚMEROS (1-5)");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int numero;

        Console.Write("Digite um número de 1 a 5: ");
        numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("\n✅ Um");
                break;
            case 2:
                Console.WriteLine("\n✅ Dois");
                break;
            case 3:
                Console.WriteLine("\n✅ Três");
                break;
            case 4:
                Console.WriteLine("\n✅ Quatro");
                break;
            case 5:
                Console.WriteLine("\n✅ Cinco");
                break;
            default:
                Console.WriteLine("\n❌ Número fora do limite. Informe um número entre 1 e 5.");
                break;
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void CalculadoraBasica()
    {
        Console.WriteLine("📌 CALCULADORA BÁSICA");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        double num1, num2, resultado = 0;
        char operador;
        bool operadorValido = true;

        Console.Write("Digite o primeiro número: ");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o operador (+, -, *, /): ");
        operador = char.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                {
                    Console.WriteLine("\n❌ Erro: Divisão por zero não permitida.");
                    operadorValido = false;
                }
                break;
            default:
                Console.WriteLine("\n❌ Operador inválido.");
                operadorValido = false;
                break;
        }

        if (operadorValido)
        {
            Console.WriteLine($"\n✅ Resultado: {num1} {operador} {num2} = {resultado}");
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ClassificadorIdade()
    {
        Console.WriteLine("📌 CLASSIFICADOR DE IDADE");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.Write("Digite a idade: ");
        if (int.TryParse(Console.ReadLine(), out int idade))
        {
            string categoria;

            if (idade >= 0 && idade <= 12)
            {
                categoria = "Infantil";
            }
            else if (idade >= 13 && idade <= 17)
            {
                categoria = "Juvenil";
            }
            else if (idade >= 18)
            {
                categoria = "Sênior";
            }
            else
            {
                categoria = "Idade inválida";
            }

            Console.WriteLine($"\n✅ A categoria é: {categoria}");
        }
        else
        {
            Console.WriteLine("\n❌ Por favor, insira um número válido.");
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void MenuLanchonete()
    {
        Console.WriteLine("📌 MENU LANCHONETE");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.WriteLine("Bem-vindo à Lanchonete!");
        Console.WriteLine("═════════════════════════════════════════════════════════════════");
        Console.WriteLine("Código - Produto - Preço");
        Console.WriteLine("100 - Cachorro Quente - R$ 15,00");
        Console.WriteLine("101 - Bauru - R$ 18,00");
        Console.WriteLine("102 - Hambúrguer - R$ 20,00");
        Console.WriteLine("103 - Cheeseburguer - R$ 22,00");
        Console.WriteLine("104 - Refrigerante - R$ 8,00");

        Console.Write("\nDigite o código do produto: ");
        int codigoProduto = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade desejada: ");
        int quantidade = int.Parse(Console.ReadLine());

        double preço = 0;
        switch (codigoProduto)
        {
            case 100:
                preço = 15.00;
                break;
            case 101:
                preço = 18.00;
                break;
            case 102:
                preço = 20.00;
                break;
            case 103:
                preço = 22.00;
                break;
            case 104:
                preço = 8.00;
                break;
            default:
                Console.WriteLine("\n❌ Código de produto inválido.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
        }

        double valorTotal = preço * quantidade;
        Console.WriteLine($"\n✅ O valor total a ser pago é: R$ {valorTotal:F2}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void CalculadorImposto()
    {
        Console.WriteLine("📌 CALCULADOR DE IMPOSTO POR ESTADO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.WriteLine("Estados: SP (+10%), RJ (+15%), MG (+12%), ES (+8%)");

        Console.Write("\nInfome o valor base do produto: ");
        string entradaValor = Console.ReadLine().Trim().Replace(',', '.');
        if (!decimal.TryParse(entradaValor, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal valorBase) || valorBase < 0)
        {
            Console.WriteLine("\n❌ Valor inválido.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            return;
        }

        Console.Write("Informe a sigla do estado (SP, RJ, MG, ES): ");
        string estado = Console.ReadLine()?.Trim().ToUpperInvariant();

        decimal taxa;
        switch (estado)
        {
            case "SP":
                taxa = 0.10m;
                break;
            case "RJ":
                taxa = 0.15m;
                break;
            case "MG":
                taxa = 0.12m;
                break;
            case "ES":
                taxa = 0.08m;
                break;
            default:
                Console.WriteLine("\n❌ Estado inválido. Use: SP, RJ, MG ou ES.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
        }

        decimal valorImposto = Math.Round(valorBase * taxa, 2);
        decimal valorFinal = Math.Round(valorBase + valorImposto, 2);

        Console.WriteLine("\n╔════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                      ✅ RESULTADO                            ║");
        Console.WriteLine($"║ Estado: {estado}");
        Console.WriteLine($"║ Valor base: R$ {valorBase:F2}");
        Console.WriteLine($"║ Imposto ({taxa * 100:F0}%): R$ {valorImposto:F2}");
        Console.WriteLine($"║ Valor final: R$ {valorFinal:F2}");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void CalculadorPesoPlanetario()
    {
        Console.WriteLine("📌 CALCULADOR DE PESO PLANETÁRIO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");

        Console.Write("Informe seu peso na Terra (kg): ");
        string entradaPeso = Console.ReadLine().Trim().Replace(',', '.');
        if (!double.TryParse(entradaPeso, NumberStyles.Number, CultureInfo.InvariantCulture, out double pesoTerra) || pesoTerra < 0)
        {
            Console.WriteLine("\n❌ Peso inválido.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("\nEscolha o planeta:");
        Console.WriteLine("1 - Mercúrio (Gravidade: 0.37)");
        Console.WriteLine("2 - Vênus    (Gravidade: 0.88)");
        Console.WriteLine("3 - Marte    (Gravidade: 0.38)");
        Console.WriteLine("4 - Júpiter  (Gravidade: 2.64)");
        Console.WriteLine("5 - Saturno  (Gravidade: 1.15)");
        Console.WriteLine("6 - Urano    (Gravidade: 1.17)");

        Console.Write("Digite o número (1-6): ");
        string entradaOpcao = Console.ReadLine();
        if (!int.TryParse(entradaOpcao, out int opcao))
        {
            Console.WriteLine("\n❌ Opção inválida.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            return;
        }

        double gravidade;
        string nomePlaneta = "";
        switch (opcao)
        {
            case 1:
                gravidade = 0.37;
                nomePlaneta = "Mercúrio";
                break;
            case 2:
                gravidade = 0.88;
                nomePlaneta = "Vênus";
                break;
            case 3:
                gravidade = 0.38;
                nomePlaneta = "Marte";
                break;
            case 4:
                gravidade = 2.64;
                nomePlaneta = "Júpiter";
                break;
            case 5:
                gravidade = 1.15;
                nomePlaneta = "Saturno";
                break;
            case 6:
                gravidade = 1.17;
                nomePlaneta = "Urano";
                break;
            default:
                Console.WriteLine("\n❌ Opção inválida. Escolha um número de 1 a 6.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
        }

        double novoPeso = Math.Round(pesoTerra * gravidade, 2);
        Console.WriteLine($"\n✅ Seu peso em {nomePlaneta} seria de {novoPeso:F2} kg");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void EstacoesAno()
    {
        Console.WriteLine("📌 ESTAÇÕES DO ANO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.WriteLine("1-Janeiro   | 2-Fevereiro | 3-Março");
        Console.WriteLine("4-Abril     | 5-Maio      | 6-Junho");
        Console.WriteLine("7-Julho     | 8-Agosto    | 9-Setembro");
        Console.WriteLine("10-Outubro  | 11-Novembro | 12-Dezembro");

        Console.Write("\nInforme o número de um mês (1-12): ");
        int mês = int.Parse(Console.ReadLine());

        string estacao = "";
        switch (mês)
        {
            case 12:
            case 1:
            case 2:
                estacao = "VERÃO";
                break;
            case 3:
            case 4:
            case 5:
                estacao = "OUTONO";
                break;
            case 6:
            case 7:
            case 8:
                estacao = "INVERNO";
                break;
            case 9:
            case 10:
            case 11:
                estacao = "PRIMAVERA";
                break;
            default:
                Console.WriteLine("\n❌ Número inválido. Informe um número entre 1 e 12.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
        }

        Console.WriteLine($"\n✅ Estação correspondente: {estacao}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    // ==================== DESAFIO RH ====================
    static void SistemaRHTechCorp()
    {
        Console.WriteLine("📌 SISTEMA DE RH - TECHCORP");
        Console.WriteLine("════════════════════════════════════════════════════════════════");

        Console.Write("Digite o nome do funcionário: ");
        string nomeFuncionario = Console.ReadLine();
        Console.Write("Digite o salário base: ");
        double salarioBase = double.Parse(Console.ReadLine());

        Console.WriteLine("\n1 - Desenvolvedor Júnior");
        Console.WriteLine("2 - Desenvolvedor Pleno");
        Console.WriteLine("3 - Desenvolvedor Sênior");
        Console.WriteLine("4 - Gerente de Projetos");
        Console.Write("\nDigite o código do cargo: ");
        int codigoCargo = int.Parse(Console.ReadLine());

        string nomeCargo = "";
        double salarioFinal = 0;

        switch (codigoCargo)
        {
            case 1:
                nomeCargo = "Desenvolvedor Júnior";
                Console.Write("Possui certificação C#? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();
                salarioFinal = (resposta == "S") 
                    ? salarioBase + (salarioBase * 0.15)
                    : salarioBase + (salarioBase * 0.05);
                break;
            case 2:
                nomeCargo = "Desenvolvedor Pleno";
                Console.Write("Quantos anos de empresa? ");
                int anos = int.Parse(Console.ReadLine());
                salarioFinal = (anos >= 3)
                    ? salarioBase + (salarioBase * 0.20)
                    : salarioBase + (salarioBase * 0.10);
                break;
            case 3:
                nomeCargo = "Desenvolvedor Sênior";
                Console.Write("É Líder Técnico? (S/N): ");
                string respLider = Console.ReadLine().ToUpper();
                salarioFinal = (respLider == "S")
                    ? salarioBase + (salarioBase * 0.30) + 500
                    : salarioBase + (salarioBase * 0.25);
                break;
            case 4:
                nomeCargo = "Gerente de Projetos";
                Console.Write("Bateu a meta de entregas? (S/N): ");
                string respMeta = Console.ReadLine().ToUpper();
                salarioFinal = (respMeta == "S")
                    ? salarioBase + (salarioBase * 0.40)
                    : salarioBase + (salarioBase * 0.10);
                break;
            default:
                Console.WriteLine("\n❌ Erro: Código de cargo inexistente.");
                salarioFinal = 0;
                break;
        }

        Console.Clear();
        Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                    ✅ HOLERITE RESUMIDO                       ║");
        Console.WriteLine("╠════════════════════════════════════════════════════════════════╣");
        Console.WriteLine($"║ Funcionário: {nomeFuncionario}");
        Console.WriteLine($"║ Cargo: {nomeCargo}");
        Console.WriteLine($"║ Salário Base: R$ {salarioBase:F2}");
        Console.WriteLine($"║ Salário Final: R$ {salarioFinal:F2}");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    // ==================== LOOPS WHILE ====================
    static void SomaMenor20()
    {
        Console.WriteLine("📌 SOMA DE NÚMEROS MENORES QUE 20");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int valor;
        int soma = 0;

        Console.Write("Informe um valor inicial: ");
        valor = int.Parse(Console.ReadLine());

        while (valor != 0)
        {
            if (valor < 20)
            {
                soma += valor;
            }
            Console.Write("Informe outro valor (0 para sair): ");
            valor = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"\n✅ A soma dos números menores que 20 é: {soma}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void MediaIdades()
    {
        Console.WriteLine("📌 MÉDIA DE IDADES");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int idade;
        double media;
        int soma = 0, qtde = 0;

        Console.Write("Informe uma idade: ");
        idade = int.Parse(Console.ReadLine());

        while (idade >= 0)
        {
            soma += idade;
            qtde++;
            Console.Write("Informe outra idade (negativa para sair): ");
            idade = int.Parse(Console.ReadLine());
        }

        media = (qtde > 0) ? soma / (double)qtde : 0;

        Console.WriteLine($"\n✅ A média de todas as idades é: {media:F2}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ValidadorSenha()
    {
        Console.WriteLine("📌 VALIDADOR DE SENHA");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int senha = 1234;
        int senhaInformada;

        Console.Write("Informe a senha: ");
        senhaInformada = int.Parse(Console.ReadLine());

        while (senhaInformada != senha)
        {
            Console.WriteLine("❌ Senha incorreta, tente novamente:");
            senhaInformada = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n✅ Senha correta, acesso liberado!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void MaiorNumero()
    {
        Console.WriteLine("📌 MAIOR NÚMERO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int numero, maior;

        Console.Write("Informe um número para começar: ");
        numero = int.Parse(Console.ReadLine());
        maior = numero;

        while (numero >= 0)
        {
            Console.Write("Informe outro número (NEGATIVO PARA SAIR): ");
            numero = int.Parse(Console.ReadLine());

            if (numero > maior)
            {
                maior = numero;
            }
        }

        Console.WriteLine($"\n✅ O maior número digitado é: {maior}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ValidadorNotas()
    {
        Console.WriteLine("📌 VALIDADOR DE NOTAS (0-10)");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int nota;

        do
        {
            Console.Write("Digite uma nota (0 a 10): ");
            nota = int.Parse(Console.ReadLine());
            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("❌ Nota inválida. Tente novamente.");
            }
        } while (nota < 0 || nota > 10);

        Console.WriteLine($"\n✅ Nota válida: {nota}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void MenuInterativoWhile()
    {
        Console.WriteLine("📌 MENU INTERATIVO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int opcao = 1;
        int anoAtual = 2026;

        while (opcao != 3)
        {
            Console.WriteLine("\n1- Dizer Olá");
            Console.WriteLine("2- Mostrar Ano");
            Console.WriteLine("3- Sair");
            Console.Write("\nDigite a opção desejada: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\n✅ Olá!");
                    break;
                case 2:
                    Console.WriteLine($"\n✅ O ano atual é {anoAtual}");
                    break;
                case 3:
                    Console.WriteLine("\n✅ Encerrando...");
                    break;
                default:
                    Console.WriteLine("\n❌ Opção inválida, tente novamente.");
                    break;
            }
        }

        Console.WriteLine("✅ Programa encerrado. Até mais!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ContagemRegressiva()
    {
        Console.WriteLine("📌 CONTAGEM REGRESSIVA COM FOGUETE");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.Write("Informe o número para iniciar a contagem: ");
        int numero = int.Parse(Console.ReadLine());

        while (numero >= 0)
        {
            Console.WriteLine($"{numero}");
            Console.Beep(165, 10000);
            Thread.Sleep(1000);
            numero--;
        }

        Console.WriteLine("\n🚀 FOGUETE LANÇADO!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void SomadorAcumulador()
    {
        Console.WriteLine("📌 SOMADOR COM ACUMULADOR");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.WriteLine("Digite números para somar (0 para parar):");
        
        int soma = 0;
        int numero;

        do
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            soma += numero;
        } while (numero != 0);

        Console.WriteLine($"\n✅ A soma total é: {soma}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}
