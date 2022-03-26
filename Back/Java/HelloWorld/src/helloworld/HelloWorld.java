package helloworld;

import java.util.Scanner;

/**
 * @author Tarso
 */
public class HelloWorld 
{   
    static String frase = "";

    public static String getFrase() {
        return frase;
    }

    public static void setFrase(String frase) {
        frase = frase;
    }
    
    public static void main(String[] args)
    {
        menu(); 
    }

    public static void menu() throws AssertionError {       
        Scanner scannerMenu  = new Scanner(System.in);
        Scanner scannerFrase = new Scanner(System.in);        
        System.out.println("******M E N U **********");
        System.out.println("1-Ler Frase");
        System.out.println("2-Exibir Frase");
        System.out.println("3-Sair");        
        Integer Opcao = scannerMenu.nextInt();       
        switch (Opcao) 
        {
            case 1: 
            {    
                System.out.println("Digite a Frase");
                frase = scannerFrase.nextLine();
                menu();
                break;
            }
            case 2:
            {
                System.out.println(frase);
                menu();
            }    
            case 3:
            {    
                System.exit(0);
                break;
            }    
            default:
            throw new AssertionError();
        }
    }
    
}
