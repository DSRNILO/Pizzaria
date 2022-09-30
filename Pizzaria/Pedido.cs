public class Pedido{
    private int ID_Pedido;
    private string ID_Cliente; 
    
    List<string> Pizzas = new List<string>();

    public void Alterarpedido(){
            //Adicionar ou Remover algum item da Comanda(lista)
    }
     public void FinalizarPedido( DetalhesdeP CalcularTotal ){
            //Calcular os valores totais de pedido 
    }
}
public class DetalhesdeP{
    private int ID_Pedido,QTD_itens;
    private float preço; 
    private string Complementos;

    public void ValorEntrada(){
        //caso o cliente tenha pagando um valor de entrada.
    }

    public void CalcularTotal(){
        //somar todos os valores e Retornar seu resultado
    }


}
