using ExemplosExplorando.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "gustavo";
// p1.Idade = -1;
// p1.Apresentar();

//usando construtor.
Pessoa p1 = new Pessoa(nome:"Leonardo", sobrenome:"Buta");
Pessoa p2 = new Pessoa(nome:"Beatriz", sobrenome:"Gabriella");

// Console.WriteLine($"Nome completo é {p1.NomeCompleto}");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "iNGLES";

cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
