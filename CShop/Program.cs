// See https://aka.ms/new-console-template for more information
/*
Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.
Un prodotto è caratterizzato da:
codice(numero intero)
nome
descrizione
prezzo
iva
Usate opportunamente ai modificatori di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.
Il codice prodotto sia accessibile solo in lettura
Gli altri attributi siano accessibili sia in lettura che in scrittura
Il prodotto esponga sia un metodo per avere il prezzo base
uno per avere il prezzo comprensivo di iva
Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
Nel vostro programma principale, testate tutte le funzionalità della classe Prodotto, creando vari prodotti e stampandone il loro contenuto.
*/
using CShop;
Console.WriteLine("Inserisci il nome del prodotto");
string nome1=Console.ReadLine();
Console.WriteLine("Inserisci a descrizione del prodotto");
string descrizione1 = Console.ReadLine();
Console.WriteLine("Inserisci il prezzo del prodotto");
double prezzo1 =int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci l'iva del prodotto");
double iva1 = int.Parse(Console.ReadLine());



Prodotto nuovoprodotto = new Prodotto();
int codice1= nuovoprodotto.CodeRandom();
nuovoprodotto.nome = nome1;
nuovoprodotto.descrizione=descrizione1;
nuovoprodotto.prezzo=prezzo1;
nuovoprodotto. iva=iva1;
nuovoprodotto.StampaTutto();