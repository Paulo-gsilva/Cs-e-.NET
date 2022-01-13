namespace encapsulamento{
    public class Retangulo{
        
        private double comprimento;
        private double largura;
        private bool validade;

        public void defineMedida(double comprimento, double largura){
            
            if(comprimento > 0 && largura > 0){
                this.comprimento = comprimento;
                this.largura = largura;
                validade = true;
            }
            else
                System.Console.WriteLine("Valores Invalidos");
        }

        public double calcularArea(){
            
            if(validade){
                return comprimento * largura;
            }
            else    
                System.Console.WriteLine("Preencha Com Valores Válidos");
                return 0;
        }

    }
}