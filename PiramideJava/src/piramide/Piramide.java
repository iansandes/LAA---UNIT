package piramide;

public class Piramide {

    public static void main(String[] args) {
        int n = 25;
        int valores[] = new int[n];
        System.out.println(quantAndaresPiramide(valores));
        int busca = busca(valores, 12);
        System.out.println("Deve estar no andar " + busca);
    }
    
    public static int busca(int valores[], int n){
        
        int andares = quantAndaresPiramide(valores);
        
        int i = 0;
        for(int x = valores.length; x > 0; x--){
            valores[i] = x;
            i++;
        }
        
        int index = 1;
        
        int maiorValor[] = new int[andares];
        
        int contador = 0;
        while(contador < andares){
            maiorValor[contador] = valores[index - 1];
            index = index * 2; 
            contador++;
        }
        
        for (int j = 0; j < maiorValor.length; j++) {
            if (j == (maiorValor.length - 1)) {
                if (n <= maiorValor[j]) {
                    return j + 1;
                }
            }else{
                if ((maiorValor[j] >= n) && (n > maiorValor[j + 1])) {
                    return j + 1;
                }
            }        
        }  
        return 0;
    }
    
    public static int quantAndaresPiramide(int[] arr) {
        int andares = 0;
        int contador = 0;
        int index = 1;
        int aux;
                
        while (contador < arr.length) {       
            andares++;
            aux = index;
            index = index * 2;
            if (aux + index > arr.length) {
                break;
            }else{
                contador++;
            }
        }
	return andares;
    }
}
