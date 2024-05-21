namespace EspacioDeClases
{
    public class Calculadora{

        private double dato;
        public double Resultado{
            get=>dato;
        }

        //Constructor por defecto
        // public Calculadora(){
        // }
        
        //Constructor sin parametros
        public Calculadora(){
            dato = 0;
        }
        //Contructor por parametro
        public Calculadora(double valorInicial){
            dato = valorInicial;
        }

        public void Sumar(double termino){
            dato+=termino;
        }
        public void Restar(double termino){
            dato-=termino;
        }
        public void Multiplicar(double termino){
            dato*=termino;
        }
        public void Dividir(double termino){
            dato/=termino;
        }
        public void Limpiar(){
            dato=0;
        }
    }
}