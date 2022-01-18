namespace Projeto{
    class Program{

        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args){
            
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "x"){
                switch (opcaoUsuario){
                    case "1":
                        ListarSerie();
                        break;

                    case "2":
                        InserirSerie();
                        break;

                    case "3":
                        //AtualizarSerie();
                        break;

                    case "4":
                        //ExcluirSerie();
                        break;

                    case "5":
                        //VisualizarSerie();
                        break;

                    case "D":
                        Console.Clear();
                        break;
                        
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void ListarSerie(){
            System.Console.WriteLine("Listar Série");

            var lista = repositorio.Lista();

            if(lista.Count == 0){
                System.Console.WriteLine("Nenhuma série encontrada");
                return;
            }

            foreach (var serie in lista){
                System.Console.WriteLine("#ID {0}: - {1}", serie.retornaID(), serie.retornaTitulo());
            }
        }

        private static void InserirSerie(){
            System.Console.WriteLine("Inserir nova série");

            foreach(int i in Enum.GetValues(typeof(Genero))){
                System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            System.Console.WriteLine("Digite o gênero: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o título: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o Ano: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a descriçõ: ");
            string entradaDescricao = Console.ReadLine();

            Series novaSerie = new Series(id: repositorio.ProximoId(),
                                                genero: (Genero)entradaGenero,
                                                titulo: entradaTitulo,
                                                ano: entradaAno,
                                                descricao: entradaDescricao);
            repositorio.Insere(novaSerie);

        }

        private static string ObterOpcaoUsuario(){

            System.Console.WriteLine();
            System.Console.WriteLine("Informe a Opção Desejada:");

            System.Console.WriteLine("1 - Listar Séries");
            System.Console.WriteLine("2 - Nova Série");
            System.Console.WriteLine("3 - Atualizar Série");
            System.Console.WriteLine("4 - Excluir Série");
            System.Console.WriteLine("5 - Ver Série");
            System.Console.WriteLine("D - Limpar Tela");
            System.Console.WriteLine("X - Sair");

            string opcaoUsurio = Console.ReadLine().ToUpper(); 
            System.Console.WriteLine();
            return opcaoUsurio;
        }
    }
}