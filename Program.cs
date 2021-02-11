

using System;

namespace StringSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            char delimiter;
            string input;
            string actWord;
            int actResultStringIndex=0;
            int cntDelimiter = 0;
            string[] resultStrings;

            Console.Write("Eingabetext:");
            text = Console.ReadLine();

            do //Trennzeichen einlesen solange bis Länge 1
            {
                Console.Write("Trennzeichen:");
                input = Console.ReadLine();
                if (input.Length != 1)
                    Console.WriteLine("Das Trennzeichen muss genau ein Zeichen sein!");
            } while (input.Length != 1);

            delimiter = Convert.ToChar(input);
      
            //Zählen wie oft das Trennzeichen im Text vorkommt. Anzahl der Teilstrings ist Trennzeichenanzahl+1
            for (int actIdx = 0; actIdx < text.Length; actIdx++)
            {
                if (text[actIdx]==delimiter)
                {
                    cntDelimiter++;
                }
            }

            //Array resultStrings in der benötigten Größe anlegen (Anzahl der Teilstrings+1)
            resultStrings = new string[cntDelimiter+1];

            actWord = ""; //Aktuelles Wort löschen
            //Teilstrings bilden und in die jeweiligen Arrayplätze des resultStrings legen
            for (int actIdx = 0; actIdx < text.Length; actIdx++) //Alle Zeichen des Eingabetextes prüfen
            {
                if (text[actIdx] == delimiter) //Trennzeichen gefunden
                {
                    //aktuellen Teiltext ausgeben und Teiltext wieder auf Leerstring setzen
                    resultStrings[actResultStringIndex] = actWord;  //Teilstring fertig (da Trennzeichen gefunden) --> in Array speichern
                    actResultStringIndex++; //Index für Ergebisarray um 1 erhöhen (für nächsten Teilstring)
                    actWord = ""; //Stringvariable des Teilstrings löschen, da nun der nächste Teilstring bis zum nächsten Trennzeichen gebildet wird
                }
                else
                {
                    //Kein Trennzeichen -> aktuelles Zeichen zum aktuellen Teiltext hinzufügen
                    actWord = actWord + text[actIdx];
                }
            }
            //Da am Ende kein Trennzeichen mehr angegeben wird. Muss der letzte Teilstring nach der Schleife ins Ergebnisarray geschrieben werden
            resultStrings[actResultStringIndex] = actWord;
            
            
            //Ergebnisarray ausgeben
            Console.WriteLine("Teilstings:");
            for (int i = 0; i < resultStrings.Length; i++)
            {
                Console.WriteLine(resultStrings[i]);
            }
            
        }
    }
}
