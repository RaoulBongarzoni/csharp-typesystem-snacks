using Microsoft.VisualBasic;
using System.Xml.Linq;
using System;
using System.Xml.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.CodeAnalysis;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //importo il random mi servirà dopo
            Random rnd = new Random();

            //switch per evitare di impazzire dovendo ogni volta far partire tutti gli snack
            Console.WriteLine("BENVENUTO, INSERISCI LO SNACK CHE VUOI TESTARE");
            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {



                case 1:
                    /*Snack 1
                    L’utente inserisce due numeri in successione.
                    Il software stampa il maggiore.*/

                    {
                        int firstNumber, secondNumber, answer;
                        Console.WriteLine("Inserisci 2 numeri per conoscere il maggiore");
                        Console.WriteLine("Primo numero");
                        firstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Secondo numero");
                        secondNumber = Convert.ToInt32(Console.ReadLine());
                        answer = Math.Max(firstNumber, secondNumber);
                        Console.WriteLine($"il più grande tra {firstNumber} e {secondNumber} è : {answer}");
                    }

                    break;

                case 2:
                    //second snack
                    //L’utente inserisce due parole in successione.
                    //Il software stampa prima la parola più corta, poi la parola più lunga.

                    {
                        string firstWord, secondWord;
                        Console.WriteLine("inserisci 2 parole in successione");
                        firstWord = Console.ReadLine();
                        secondWord = Console.ReadLine();

                        string[] answer = new string[2];
                        if (firstWord.Length > secondWord.Length)
                        {
                            answer[1] = firstWord;
                            answer[0] = secondWord;
                        }
                        else if (firstWord.Length <= secondWord.Length)
                        {
                            answer[0] = firstWord;
                            answer[1] = secondWord;
                        }
                        Console.WriteLine("in ordine dalla più piccola alla più grande");
                        foreach (string word in answer)
                        {
                            Console.WriteLine(word);
                        }
                    }
                    break;

                case 3:
                    //third snack
                    /*Il software deve chiedere per 10 volte all’utente di inserire un numero.
                    Il programma stampa la somma di tutti i numeri inseriti.*/

                    {

                        Console.WriteLine(" inserisci 10 numeri e ti restituisce la somma");

                        int sum = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write($" {i + 1}o numero : ");
                            sum += Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine($"la somma dei 10 numeri è : {sum} ");

                    }
                    break;



                case 4:
                    //fourth snack
                    /* 
                    Calcola la somma e la media dei numeri da 2 a 10.
                    */

                    {

                        Console.WriteLine("somma e media dei numeri da 2 a 10 ( compresi ;) ) :");
                        int sum = 0;

                        for (int i = 2; i <= 10; i++)
                        {
                            sum += i;
                        }
                        Console.WriteLine($"la somma dei unmeri da 2 a 10 è {sum} e la media è {sum / 9} ");

                }
                break;
               
                case 5:
                    //fifth snack
                    /*
                    Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
                    */
                    {

                        Console.WriteLine("Inserisci un numero,  Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.");
                        int number = Convert.ToInt32(Console.ReadLine());
                        if (number % 2 == 0)
                        {
                            Console.WriteLine($"Complimenti: hai inserito un numero pari ... {number}");
                        }
                        else
                        {
                            Console.WriteLine($"Complimenti: hai inserito un numero dispari ... {number + 1} è il successivo ;)");

                        }

                }
                break;

                case 6:

                    /*Snack 6
                    In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa. */
                {

                    Console.WriteLine("benvenuto, sei in lista? Dimmi il tuo nome così controllo (mi raccomando di dirmelo con la maiuscola!)");

                    //questa lista di nomi ci è stata gentilmente offerta da chat gpt (volevo rimanere in tema grande gatsby)

                    string guestName;
                    string[] englishNames = new string[]{
                        "Alessandro",
                        "Giulia",
                        "Francesco",
                        "Chiara",
                        "Lorenzo",
                        "Martina",
                        "Matteo",
                        "Sofia",
                        "Giovanni",
                        "Elisa",
                        "Marco",
                        "Valentina",
                        "Luca",
                        "Paola",
                        "Antonio",
                        "Anna",
                        "Riccardo",
                        "Elena",
                        "Andrea",
                        "Laura",
                        "Davide",
                        "Roberta",
                        "Simone",
                        "Federica",
                        "Fabio",
                        "Silvia",
                        "Enrico",
                        "Monica",
                        "Stefano",
                        "Veronica",
                        "Massimo",
                        "Cristina",
                        "Claudio",
                        "Serena",
                        "Alberto",
                        "Marta",
                        "Emanuele",
                        "Sara",
                        "Leonardo",
                        "Alessia",
                        "Gabriele",
                        "Federico",
                        "Giorgio",
                        "Eleonora",
                        "Giacomo",
                        "Beatrice",
                        "Nicola",
                        "Caterina",
                        "Tommaso",
                        "Angela"
                    };

                    guestName = Console.ReadLine();

                    if (Array.IndexOf(englishNames, guestName) != -1)
                    {
                        Console.WriteLine("prego entri pure");

                    }
                    else
                    {
                        Console.WriteLine("mi dispiace non la conosciamo");
                    }
                }
                
                break;

                case 7:

                    /*
                     Snack 7
                        Crea un array vuoto.
                        Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.*/
                    {

                        int[] arraytoFill = new int[6];

                        Console.WriteLine("inserisci 6 numeri, se sono dispari li inserisco nell'array");
                        for (int i = 0; i < 6; i++)
                        {
                            int currentNumber = Convert.ToInt32(Console.ReadLine());
                            if (currentNumber % 2 != 0)
                            {
                                arraytoFill[i] = currentNumber;
                            }
                        }
                        Console.WriteLine("i numeri dispari da te inseriti dovrebbero essere:");
                        foreach (int number in arraytoFill)
                            {
                            if (number != 0) {
                                Console.Write($"{number} - ");                        
                                } 
                            }


                    }
                break;

                case 8:
                    //Snack 8
                    //Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

                    {
                        
                        Console.WriteLine("restituisce la somma dei numeri in posizione dispara in un array generato random, quanto vuoi sia lungo l'array da analizzare?");
                        int i = Convert.ToInt32(Console.ReadLine());
                        //int[] tenRandomNumbers = new int[i];  risparmio memoria senza allocare l'array stampo a schermo direttamente  anche se ho perso il filo dell'esercizio scusate :(
                        int somma = 0;
                        Console.WriteLine("L'array corrente è: ");
                        for (int j = 0; j < i; j++)
                        {
                            int currentNumber = rnd.Next(1, 100);
                            Console.WriteLine($"{currentNumber}-");
                            //tenRandomNumbers[j] = currentNumber;
                            if (j % 2 != 0) {
                                somma += currentNumber;
                            }
                        }
                        Console.WriteLine($" la somma delle posizioni dispare è: {somma} ");

                    }
                break;


                case 9: 
                    //Snack 9
                    //Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
                    {
                        int[] arrayToFill = new int[100];
                        int sum = 0;
                        Console.WriteLine("inserisci un numero e continua a inserir, quando la somma dei numeri è maggiore di 50 mi fermo");
                        do
                        {
                            sum += Convert.ToInt32(Console.ReadLine());


                        } while (sum <= 50);
                        Console.WriteLine("sembra che siamo arrivati a capolinea");
                    
                    
                    }
                    break;

                case 10:
                    /*Snack 10
                    Fai inserire un numero, che chiameremo N, all’utente.
                    Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
                    Ogni volta che ne crei uno, stampalo a schermo.*/
                    {
                        Console.WriteLine("inserisci un numero ..");
                        int N = Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i < N; i++)
                        {
                            Console.WriteLine( $"\n questo è il {i +1}o :  ");

                            int[] arrayTemp = new int[10];
                            for( int j = 0; j <10; j++) //ottimizzabile togliendo l'allocazione dell'array temporaneo e stampando direttamente a schermo o generando N * 10 numeri e stampandoli in righe da dieci
                            {
                                arrayTemp[j] = rnd.Next(1, 101);

                            }
                            foreach (int element in arrayTemp)
                            {
                                Console.Write($"-{element}- ");

                            }

                            
                        }


                    }
                    break;

                default:
                    {
                        Console.WriteLine("ops sembra che hai selezionato uno snack che non esiste....");
                    }
                    break;
            }
            
        }
    }
}
