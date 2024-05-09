using ExemplosExplorando.Models;
// using ExemplosExplorando.Models.Pessoa;

//aqui eu chamo o construtor 
Pessoa p1 = new Pessoa("Leonardo", "buta");
//aqui eu to usando o desconstruct
(string nome, string sobrenome) = p1;

Console.WriteLine( $"{nome} {sobrenome}");











// LeituraArquivo arquivo = new LeituraArquivo();

// //usando var nao preciso passar o tipo de dados para as variaveis
// var(sucesso,linhaArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivo/ArquivoLeitura.txt");
// // quando tiver algum retorno em tupla em que eu nao desejar retornar
// // eu posso usar o _ no lugar do nome da variavel como no ex abaixo.
// // a onde eu nao quero retornar a quantidade de linhas.
// // var(sucesso,linhaArquivo, _) = arquivo.LerArquivo("Arquivo/ArquivoLeitura.txt");

// if(sucesso)
// {
//     Console.WriteLine("Quantidade linhas arquivo" + quantidadeLinhas);
//     foreach (string linha in linhaArquivo)
//     {
//         Console.WriteLine(linha);        
//     }

// }
// else
// {
//     Console.WriteLine("Nãop foi possivel ler o arquivo");
// }



























// (int id, string nome,string sobrenome, decimal altura) tupla = (1,"Fernando", "Buta", 1.75M);

// //outra sintaxe tupla nesses exemplos nao consigo renomear meus itens
// ValueTuple<int,string,string,decimal> outroExemploTupla = (1,"FErnando", "Buta", 1.75m);
// //nesse terceiro exemplo nao precisa passar os tipos de dados. 
// var outroExemploTuplaCreate = Tuple.Create(1,"Fernando", "Buta", 1.75M);

// Console.WriteLine($"Id: {tupla.id}");
// Console.WriteLine($"Nome: {tupla.nome}");
// Console.WriteLine($"Sobrenome: {tupla.sobrenome}");
// Console.WriteLine($"Altura: {tupla.altura}");

























//trabalhando com dicionario

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// Console.WriteLine("----------------");
// //remove
// // estados.Remove("BA");
// //altera
// estados["SP"] = "São Paulo - Valor alterado";
// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// //obtendo valor existente

// Console.Writeline(estados["MG"]);

// string chave = "BA";

// Console.WriteLine($"Verificando elementos: {chave}")
// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"valor existente: {chave}")
// }
// else
// {
//     Console.WriteLine($"É seguro adicionar a {chave}")
// }
// //trabalhando com pilha

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }





// // trabalhando com filas

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);


// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }
// //remover elemento da fila, 
// //ele sempre vai remover o primeiro elemento
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }















//lendo arquivos de txt
// new ExemplosExcecao().Metodo1();
// try
// {
    
// string[] linhas = File.ReadAllLines("Arquivos/ArquivoLeitura.txt");

// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);    
// }
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não foi encontrado {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro no arquivo diretorio nao encontrado {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exeção generica {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui.");
// }
































































// Pessoa p1 = new Pessoa();
// p1.Nome = "gustavo";
// p1.Idade = -1;
// p1.Apresentar();

//usando construtor.
// Pessoa p1 = new Pessoa(nome:"Leonardo", sobrenome:"Buta");
// Pessoa p2 = new Pessoa(nome:"Beatriz", sobrenome:"Gabriella");

// // Console.WriteLine($"Nome completo é {p1.NomeCompleto}");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "iNGLES";

// cursoDeIngles.Alunos = new List<Pessoa>();
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();
// Pessoa p1 = new Pessoa();
// p1.Nome = "gustavo";
// p1.Idade = -1;
// p1.Apresentar();

//usando construtor.
// Pessoa p1 = new Pessoa(nome:"Leonardo", sobrenome:"Buta");
// Pessoa p2 = new Pessoa(nome:"Beatriz", sobrenome:"Gabriella");

// // Console.WriteLine($"Nome completo é {p1.NomeCompleto}");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "iNGLES";

// cursoDeIngles.Alunos = new List<Pessoa>();
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();
