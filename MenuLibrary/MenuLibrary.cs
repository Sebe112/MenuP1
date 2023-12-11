using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bøger; // Bruger bøger projected
using Biler; // Bruger biler projected
using Furniture; // Bruger furniture projected

namespace MenuLibrary{
    public class Menu {
        public static void HovedMenu() { // Her laver vi hovedmenuen hvor vi kan gå ind i de mange submenuer med opgaver eller stoppe proggrammet
            do { // Vi bruger et do while loop til at lade brugeren skrive forkert også genskabe hovemenuen hvis de gør
                Console.Clear(); // Ranser terminalen
                Console.WriteLine("Vælg submenu ved at skrive tilsvarende tal eller gå ud med 18"); // skriver noget tekst der forklare brugeren hvad de skal gøre
                Console.WriteLine("(1) Variabler");
                Console.WriteLine("(2) Strings");
                Console.WriteLine("(3) Artimetiske udtryk");
                Console.WriteLine("(4) Variabler i udtryk");
                Console.WriteLine("(5) Boolske variabler");
                Console.WriteLine("(6) If-else statement");
                Console.WriteLine("(7) Switch Case");
                Console.WriteLine("(8) Loops");
                Console.WriteLine("(9) Udvidet kontrolstrukturer");
                Console.WriteLine("(10) Metoder og instanser");
                Console.WriteLine("(11) Returtyper og parametre");
                Console.WriteLine("(12) Instancevariabler");
                Console.WriteLine("(13) Nedarvning");
                Console.WriteLine("(14) Konstruktors");
                Console.WriteLine("(15) Arrays");
                Console.WriteLine("(16) Gennemløb af arrays");
                Console.WriteLine("(17) Public, Private og Protected");
                Console.WriteLine("(18) EXIT");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) { // Laver et switch statement der lader brugeren gøre hvad de fik at vide de kan gøre (gå videre til submenuer)
                    case "1":
                        Variabler(); // Metode der indeholder en submenu
                        break;
                    case "2":
                        Strings();
                        break;
                    case "3":
                        AritmetiskeUdtryk();
                        break;
                    case "4":
                        VariablerIUdtryk();
                        break;
                    case "5":
                        BoolskeVariable();
                        break;
                    case "6":
                        IfElseStatements();
                        break;
                    case "7":
                        SwitchCase();
                        break;
                    case "8":
                        Loops();
                        break;
                    case "9":
                        UdvidetKontrolstrukturer();
                        break;
                    case "10":
                        MetoderOgInstanser();
                        break;
                    case "11":
                        ReturtyperOgParametre();
                        break;
                    case "12":
                        Instancevariabler();
                        break;
                    case "13":
                        Nedarvning();
                        break;
                    case "14":
                        Konstruktors();
                        break;
                    case "15":
                        Arrays();
                        break;
                    case "16":
                        GennemløbAfArrays();
                        break;
                    case "17":
                        PublicPrivateOgProtected();
                        break;
                    case "18":
                        Environment.Exit(0); // Stopper programmet
                        break;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool Variabler() { // Den første submenu
            string Navn = "Søren", skriv = ""; // initiere nogle variabler...
            int tal1 = 5, tal2 = 3, Alder = 16, tal = 0;
            double Kage = 23.56, Øl = 34.67, Pølse = 65.34, samlet = 0, Penge = 1234.34;
            samlet = Kage + Øl + Pølse;
            do {
                Console.Clear(); // Samme som i hovemenu'en men en submenu
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 7");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Opgave 2");
                Console.WriteLine("(3) Opgave 3");
                Console.WriteLine("(4) Opgave 4");
                Console.WriteLine("(5) Opgave 5");
                Console.WriteLine("(6) Opgave 6");
                Console.WriteLine("(7) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        Console.WriteLine(tal1); // Udskriver en variable
                        Console.WriteLine(tal2);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("tal1 er " + tal1); // Udskriver noget tekst og en variable
                        Console.WriteLine("tal2 er " + tal2);
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Jeg hedder " + Navn + ", er " + Alder + " år gammel og har tjent " + Penge + " kr. på at lappe cykler"); // Udskrvier mere tekst og flere variabler
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Kage    " + Kage + " Øl    " + Øl);
                        Console.WriteLine("Pølse   " + Pølse);
                        Console.WriteLine("I alt   " + samlet);
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Skriv dit navn"); // Beder brugern om at skrive deres navn
                        skriv = Console.ReadLine(); // Gemmer hvad brugeren skriver i skriv variablen
                        Console.WriteLine("Skriv din alder"); // Beder om brugerns alder
                        try { // bruger try til at stoppe proggrammet i at crashe hvis brugeren ikke skriver et tal i vores int
                            tal = Convert.ToInt32(Console.ReadLine()); // Gemmer brugerens indput i tal hvis der gives en int
                        }
                        catch (Exception) { // Hvis brugeren ikke ved hvad tal er kommer vi herned og går tilbage til submenuen
                            Console.WriteLine("Du skrev ikke et tal");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Jeg hedder " + skriv + " og er " + tal + " år gammel."); // Udskriver tekst og de variabler vi gemte brugeres svar i
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Write("Skriv radius for at udregne arealet af en cirkel: ");
                        try {
                            tal = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception) {
                            Console.WriteLine("Du skrev ikke et tal");
                            Console.ReadKey();
                            break;
                        }
                        samlet = Math.PI * Math.Pow(tal, 2); // Matematik
                        Console.WriteLine("Resultated er " + samlet);
                        Console.ReadKey();
                        break;
                    case "7":
                        return false; // Går ud af submenu'en og går tilbage til hovedmenu'en
                    default:
                        break;
                }
            } while (true);
        }
        public static bool Strings() {
            int tal = 5;
            string tekst = "hej", tekst1 = "I dag har vi den 24. December.", tekst2 = "Jeg har.", tekst3 = "kr. i banken.";
            double dec = 2.5, pris = 200.50;
            do {
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 5");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Opgave 2");
                Console.WriteLine("(3) Opgave 3");
                Console.WriteLine("(4) Opgave 4");
                Console.WriteLine("(5) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        Console.WriteLine(tal);
                        Console.WriteLine(tekst);
                        Console.WriteLine(dec);
                        Console.ReadKey();
                        break;
                    case "2":
                        tal = 10;
                        Console.WriteLine(tal);
                        Console.WriteLine(tekst);
                        Console.WriteLine(dec);
                        tal = 5;
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine(tekst1);
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine(tekst2 + " " + pris.ToString("n2") + tekst3);
                        Console.ReadKey();
                        break;
                    case "5":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool AritmetiskeUdtryk() {
            int tal = 0;
            do {
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 2");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        tal = 2 + 1 * 2;
                        Console.WriteLine(tal);
                        tal = (2 + 1) * 2;
                        Console.WriteLine(tal);
                        tal = 5 / 2;
                        Console.WriteLine(tal);
                        tal = 8 % 3;
                        Console.WriteLine(tal);
                        tal = 1 - 5;
                        Console.WriteLine(tal);
                        Console.ReadKey();
                        break;
                    case "2":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool VariablerIUdtryk() {
            int tal = 2, tal1 = 5, tal2 = 10, result = 0;
            double mat = 5.5, mat1 = 2.7, mat2 = 3.3, matresult = 0.0;
            do {
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 3");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Opgave 2");
                Console.WriteLine("(3) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        result = tal + tal1 + tal2;
                        Console.WriteLine(result);
                        Console.ReadKey();
                        break;
                    case "2":
                        matresult = mat + mat1 - 3 * 5 - mat2;
                        Console.WriteLine(matresult);
                        Console.ReadKey();
                        break;
                    case "3":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool BoolskeVariable() {
            do {
                int var1 = 5, var2 = 10;
                bool erSandt = var1 > var2;
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 2");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        Console.WriteLine(erSandt);
                        var1 = 11;
                        erSandt = var1 > var2; // Bruger en bool til at tjekke om et udtryk er sandt eller falsk
                        Console.WriteLine(erSandt); // Udskriver svaret
                        Console.ReadKey();
                        break;
                    case "2":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool IfElseStatements() {
            int tal1 = 42, tal2 = 64, result = 0, alder;
            string navn, brugernavn = "abe", password = "kat", brugernavn1, password1;
            double res;
            do {
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 8");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Opgave 2");
                Console.WriteLine("(3) Opgave 3");
                Console.WriteLine("(4) Opgave 4");
                Console.WriteLine("(5) Opgave 5");
                Console.WriteLine("(6) Opgave 6");
                Console.WriteLine("(7) Opgave 7");
                Console.WriteLine("(8) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        result = tal1 + tal2;
                        if (result > 100) { // Bruger if statements til at tjekke betingelser og gøre noget hvis betingelserne er opfyldt
                            Console.WriteLine("Summen er større end 100!.");
                        }
                        else if (result < 100) {
                            Console.WriteLine("Summen er mindre end 100.");
                        }
                        else { // Hvis ingen af betingelserne i de andre dele er opfyldt så køre else delen
                            Console.WriteLine("Summen er 100");
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("indstast din alder");
                        try {
                            alder = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception) {
                            Console.WriteLine("Du skrev ikke et tal");
                            Console.ReadKey();
                            break;
                        }
                        if (alder > 57) {
                            Console.WriteLine("Du er for gammel.");
                        }
                        else {
                            Console.WriteLine("Du er ikke for gammel.");
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("indstast din alder");
                        try {
                            alder = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception) {
                            Console.WriteLine("Du skrev ikke et tal");
                            Console.ReadKey();
                            break;
                        }
                        if (alder > 60) {
                            Console.WriteLine("Du er for gammel.");
                        }
                        else if (alder > 50) {
                            Console.WriteLine("Du er hverken for gammel eller for ung.");
                        }
                        else {
                            Console.WriteLine("Du er for ung.");
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Indtast dit navn");
                        navn = Console.ReadLine();
                        Console.WriteLine("Indtast dit brugernavn");
                        brugernavn1 = Console.ReadLine();
                        Console.WriteLine("Indtast dit password");
                        password1 = Console.ReadLine();
                        if (brugernavn1 == brugernavn && password1 == password) {
                            Console.WriteLine("Velkommen " + navn);
                        }
                        else {
                            Console.WriteLine("brugernavn eller password er forkert.");
                        }
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Indtast dit navn");
                        navn = Console.ReadLine();
                        Console.WriteLine("Indtast dit brugernavn");
                        brugernavn1 = Console.ReadLine();
                        if (brugernavn1 != brugernavn) {
                            Console.WriteLine("brugernavn er forkert.");
                            break;
                        }
                        Console.WriteLine("Indtast dit password");
                        password1 = Console.ReadLine();
                        if (password1 != password) {
                            Console.WriteLine("password er forkert.");
                            break;
                        }
                        else {
                            Console.WriteLine("Velkommen " + navn);
                        }
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Write("Hvor mange km køre du til arbejde hver dag: ");
                        try {
                            alder = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception) {
                            Console.WriteLine("Du skrev ikke et tal");
                            Console.ReadKey();
                            break;
                        }
                        if (alder <= 24) {
                            Console.WriteLine("du får ikke noget fradrag.");
                        }
                        else if (alder > 121) {
                            res = 96 * 1.93 + (alder - 120) * 0.97;
                            Console.WriteLine("fradrag er " + res);
                        }
                        else {
                            res = (alder - 24) * 1.93;
                            Console.WriteLine("fradrag er " + res);
                        }
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Title = ("Festen.");
                        Console.Write("Vælg mellem rød, grøn, blå og gul: ");
                        navn = Console.ReadLine();
                        if (navn == "rød") {
                            Console.BackgroundColor = ConsoleColor.Red; // Sætter bagrundsfarven til at være rød
                            Console.Clear();
                        }
                        else if (navn == "grøn") {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                        }
                        else if (navn == "blå") {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                        }
                        else if (navn == "gul") {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                        }
                        else {
                            Console.WriteLine("Du skrev noget forkert");
                            Console.ReadKey();
                            break;
                        }
                        Console.Write("Hvor gammel er du: ");
                        try {
                            alder = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception) {
                            Console.WriteLine("Du skrev ikke et tal");
                            Console.ReadKey();
                            break;
                        }
                        if (alder >= 18) {
                            Console.WriteLine("Velkommen til cocktailbaren.");
                        }
                        else {
                            Console.WriteLine("Velkommen til sodavandsbaren.");
                        }
                        Thread.Sleep(10000); // Vent 1+ sekunder
                        Console.BackgroundColor = ConsoleColor.Black; // Sætter farven tilbage til sort før vi går tilbage til submenu'en
                        break;
                    case "8":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool SwitchCase() {
            do {
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 3");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Opgave 2");
                Console.WriteLine("(3) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        Console.WriteLine("Indtast et tal mellem 0-7");
                        switch (Console.ReadLine()) {
                            case "1":
                                Console.WriteLine("Du skrev 1");
                                Console.ReadKey();
                                break;
                            case "2":
                                Console.WriteLine("Du skrev 2");
                                Console.ReadKey();
                                break;
                            case "3":
                                Console.WriteLine("Du skrev 3");
                                Console.ReadKey();
                                break;
                            case "4":
                                Console.Clear();
                                Console.SetCursorPosition(50, 14);
                                Console.WriteLine("TILLYKKE DU HAR VUNDET");
                                Console.ReadKey();
                                break;
                            case "5":
                                Console.WriteLine("Du skrev 5");
                                Console.ReadKey();
                                break;
                            case "6":
                                Console.WriteLine("Du skrev 6");
                                Console.ReadKey();
                                break;
                            default:
                                Thread.Sleep(10000);
                                break;
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("(1) Isbjørn 20 kr");
                        Console.WriteLine("(2) Champagnebrus 40 kr");
                        Console.WriteLine("(3) Tequila Sunrise 63 kr");
                        Console.WriteLine("(4) Mojito 10 kr");
                        Console.WriteLine("(5) Brandbil 25 kr");
                        Console.WriteLine("(6) Filur 1000 kr");
                        switch (Console.ReadLine()) {
                            case "1":
                                Console.WriteLine("Du har valgt en Isbjørn til 20 kr");
                                Console.ReadKey();
                                break;
                            case "2":
                                Console.WriteLine("Du har valgt en Champagnebrus til 40 kr");
                                Console.ReadKey();
                                break;
                            case "3":
                                Console.WriteLine("Du har valgt en Tequila Sunrise til 63 kr");
                                Console.ReadKey();
                                break;
                            case "4":
                                Console.WriteLine("Du har valgt en Mojito til 10 kr");
                                Console.ReadKey();
                                break;
                            case "5":
                                Console.WriteLine("Du har valgt en Brandbil til 25 kr");
                                Console.ReadKey();
                                break;
                            case "6":
                                Console.WriteLine("Du har valgt en Filur til 1000 kr");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Du skrev noget andet ind 1, 2, 3, 4, 5 eller 6");
                                Console.ReadKey();
                                break;
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool Loops() {
            do {
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med e");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Opgave 2");
                Console.WriteLine("(3) Opgave 3");
                Console.WriteLine("(4) Opgave 4");
                Console.WriteLine("(5) Opgave 5");
                Console.WriteLine("(6) Opgave 6");
                Console.WriteLine("(7) Opgave 7");
                Console.WriteLine("(8) Opgave 7");
                Console.WriteLine("(9) Opgave 7");
                Console.WriteLine("(e) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        for (int i = 1; i < 11; i++) { // Et forloop der udskriver 1 2 3 ... 9 10
                            Console.WriteLine(i);
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        for (int i = 100; i > 0; i--) {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        int x = 100;
                        while (x > 0) {
                            Console.Write(x + " ");
                            x--;
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        for (int i = 1; i < 11; i++) {
                            Console.WriteLine(5 * i);
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        for (int i = 20; i > -1; i--) {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        int y = 20;
                        while (y > -1) {
                            Console.Write(y + " ");
                            y--;
                        }
                        Console.ReadKey();
                        break;
                    case "5":
                        for (int i = 1; i < 11; i++) {
                            Console.Write($"{i} * 7 = " + 7 * i + " ");
                        }
                        Console.ReadKey();
                        break;
                    case "6":
                        int tal = 0;
                        Console.WriteLine("skriv tal du vil have tabel til 10 for: ");
                        tal = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i < 11; i++) {
                            Console.Write($"{i} * {tal} = " + tal * i + " ");
                        }
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Clear();
                        int a = 20, b = 4, c = 30, d = 8;
                        Console.SetCursorPosition(a, b);
                        Console.Write("-");
                        for (int i = a; i < c; i++) {
                            a++;
                            Console.SetCursorPosition(a, b);
                            Console.Write("-");
                        }
                        for (int i = b; i < d; i++) {
                            b++;
                            Console.SetCursorPosition(a, b);
                            Console.Write("-");
                        }
                        a = 20; b = 4;
                        for (int i = b; i < d; i++) {
                            b++;
                            Console.SetCursorPosition(a, b);
                            Console.Write("-");
                        }
                        for (int i = a; i < c; i++) {
                            a++;
                            Console.SetCursorPosition(a, b);
                            Console.Write("-");
                        }
                        Console.ReadKey();
                        break;
                    case "8":
                        a = 20; b = 4; c = 30; d = 8;
                        Console.Clear();
                        Console.SetCursorPosition(a, b);
                        Console.Write("-");
                        for (int i = a; i < c; i++) {
                            a++;
                            Console.SetCursorPosition(a, b);
                            Console.Write("-");
                        }
                        for (int i = b; i < d; i++) {
                            b++;
                            Console.SetCursorPosition(a, b);
                            Console.Write("-");
                        }
                        a = 20; b = 4;
                        for (int i = b; i < d; i++) {
                            b++;
                            Console.SetCursorPosition(a, b);
                            Console.Write("-");
                        }
                        for (int i = a; i < c; i++) {
                            a++;
                            Console.SetCursorPosition(a, b);
                            Console.Write("-");
                        }
                        int e = 0;
                        int f = 0;
                        a = 20; b = 4; c = 30; d = 8;
                        Console.SetCursorPosition(a + 1, (b + d) / 2);
                        Console.Write("Sebastian");
                        Console.ReadKey();
                        break;
                    case "9": // I den her opgave skal brugeren kunne vælge hvor på skærmen hvor der skal laves en box og et navn skal skrives i den
                        string navn;
                        try {
                            Console.WriteLine("hvad er din start x verdi");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("hvad er din start y verdi");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("hvad er din slut x verdi");
                            c = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("hvad er din slut y verdi");
                            d = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Skriv dit navn");
                            navn = Console.ReadLine();
                            e = a; f = b;
                        }
                        catch (Exception) {
                            Console.WriteLine("du skrev ikke et tal");
                            Console.ReadKey();
                            break;
                        }
                        
                        Console.Clear();
                        Console.SetCursorPosition(a, b);
                        Console.Write("-");
                        for (int i = a; i < c; i++) { // Hvert loop laver 1/4 del af kassen
                            Console.SetCursorPosition(a, b);
                            Console.Write("-");
                            a++;
                        }
                        for (int i = b; i < d; i++) {
                            b++;
                            Console.SetCursorPosition(a, b);
                            Console.Write("-");
                        }
                        a = e; b = f;
                        for (int i = b; i < d; i++) {
                            b++;
                            Console.SetCursorPosition(a, b);
                            Console.Write("-");
                        }
                        for (int i = a; i < c; i++) {
                            a++;
                            Console.SetCursorPosition(a, b);
                            Console.Write("-");
                        }
                        Console.SetCursorPosition((e + c) / 2 - 4, (f + d) / 2); // Sætter cursoren ca i midten af boxen
                        Console.Write(navn); // Skriver navnet der
                        Console.ReadKey();
                        break;
                    case "e":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool UdvidetKontrolstrukturer() {
            do {
                double antalKm,fradrag,indkomst,res,res1;
                int x,y;
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 6");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Opgave 2");
                Console.WriteLine("(3) Opgave 3");
                Console.WriteLine("(4) Opgave 4");
                Console.WriteLine("(5) Opgave 5");
                Console.WriteLine("(6) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");
                
                switch (Console.ReadLine()) {
                    case "1":
                        for (int i = 1; i < 11; i++) {
                            x = 3 * i;
                            Console.WriteLine(x);
                            if (x == 21) { // Stopper looped tidligere end looped ellers ville
                                break;
                            }
                        }
                        Console.WriteLine("Looped stoppes");
                        Console.ReadKey();
                        break;
                    case "2":
                        x = 0;
                        y = 1;
                        while (x < 40) { // While loop der skriver 4 tabellen til 40 men skriver ikke 16
                            x = y * 4;
                            if (x == 16) {
                                x = 20;
                                y++;
                            }
                            y++;
                            Console.WriteLine(x);
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        fradrag = 0;
                        Console.Write("Hvad er dit fradrag: ");
                        antalKm = Convert.ToDouble(Console.ReadLine());
                        if (antalKm < 24 || antalKm == 24) {
                            Console.WriteLine("Ingen fradrag.");
                        }
                        else if (antalKm > 24 && antalKm <= 100) {
                            fradrag = (antalKm - 24) * 1.54;
                            Console.WriteLine("Dit fradrag er " + fradrag);
                        }
                        else {
                            fradrag = (100 - 24) * 1.54 + (antalKm - 100) * 0.77;
                            Console.WriteLine("Dit fradrag er " + fradrag);
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        indkomst = 0;
                        res = 0;
                        Console.Write("Hvad er din indkomst: ");
                        indkomst = Convert.ToDouble(Console.ReadLine());
                        if (indkomst < 42000) {
                            Console.WriteLine("Ingen skat skal betales.");
                        }
                        else if (indkomst == 42000 || indkomst <= 280000) {
                            res = indkomst * 0.30;
                        }
                        else if (indkomst > 280000 && indkomst < 390000) {
                            res = indkomst * 0.30 * (indkomst - 280000) * 0.06;
                        }
                        else {
                            res = indkomst * 0.30 + (280000 - 42000) * 0.06 + (indkomst - 390000) * 0.15;
                        }
                        Console.WriteLine("Du skal betale " + res + " kr i skat.");
                        Console.ReadKey();
                        break;
                    case "5":
                        res1 = 0;
                        res = 0;
                        indkomst = 0;
                        Console.Write("Indtast beløbet på kontoen: ");
                        indkomst = Convert.ToDouble(Console.ReadLine());

                        if (indkomst < 25000) {
                            res = indkomst * 0.25 / 100;
                        }
                        else if (indkomst >= 25000 && indkomst <= 150000) {
                            res = indkomst * 1.25 / 100;
                        }
                        else {
                            res = 150000 * 1.25 / 100;
                            res1 = (indkomst - 150000) * 0.5 / 100;
                            res = res + res1;
                        }
                        Console.WriteLine($"Den tilskrevne rente er: {res:F2}"); // F2 gør så vi får 2 komma tal med
                        Console.ReadKey();
                        break;
                    case "6":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool MetoderOgInstanser() {
            Bog SherlockHolmes = new Bog("SherlockHolmes",150); // Laver et object af Bog klassen
            do {
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 3");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Opgave 2");
                Console.WriteLine("(3) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        SherlockHolmes.PrintInfo(); // Bruger metode på det object vi lavede tidligere
                        Console.ReadKey();
                        break;
                    case "2":
                        SherlockHolmes.HarRåd(160); // Bruger anden metode på object giver false + tekst
                        SherlockHolmes.HarRåd(140); // Giver true + tekst
                        Console.ReadKey();
                        break;
                    case "3":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool ReturtyperOgParametre() {
            double gas = 2.5;
            Bil bil1 = new Bil(); // Laver et object af Bil klassen
            do {
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 5");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Opgave 2");
                Console.WriteLine("(3) Opgave 3");
                Console.WriteLine("(4) Opgave 4");
                Console.WriteLine("(5) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        bil1.StartMotor(); // Bruger metode på objected
                        bil1.SlukMotor(); // Bruger metode på objected
                        Console.ReadKey();
                        break;
                    case "2":
                        bil1.FillGas(gas, false); // Bruger metode på objected
                        Console.ReadKey();
                        break;
                    case "3":
                        bil1.FillGas(gas, true); // Bruger metode på objected
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine(bil1.RemainingGas(gas)); // Bruger metode på objected og skriver det ud
                        Console.ReadKey();
                        break;
                    case "5":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool Instancevariabler() {
            Bog bog1 = new Bog("Moby Dick",240);
            do {
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 2");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        bog1.PrintInfo();
                        bog1.HarRåd(300);
                        bog1.HarRåd(200);
                        Console.ReadKey();
                        break;
                    case "2":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool Nedarvning() {
            Chair stol = new Chair("SejStol",10); // Laver et object af en subKlasse
            Computer pc = new Computer("AzureProGamingPc", "MegetTekst"); // Laver et object af en anden subKlasse
            do {
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 2");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        stol.print();
                        pc.print();
                        Console.ReadKey();
                        break;
                    case "2":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool Konstruktors() {
            Bog bog1 = new Bog("Yeet", 10);
            do {
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 2");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        bog1.PrintInfo();
                        bog1.HarRåd(15);
                        bog1.HarRåd(5);
                        Console.ReadKey();
                        break;
                    case "2":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool Arrays() {
            int[] arr = {-2,-1,0,10}; // Opretter et array med 4 int's i
            do {
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 2");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        Console.WriteLine(arr[arr.Length-1]); // Udskriver det sidste element i arr array'et (opgaven vi have 10)
                        Console.WriteLine(arr[1]); // Udskriver det andet element i arrayet (opgaven vil have -1)
                        Console.WriteLine(arr.Sum()); // Bruger .sum() til at få summen af arrayet
                        Console.ReadKey();
                        break;
                    case "2":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool GennemløbAfArrays() {
            int[] intArray = {2, 1, 3, 5, 10, -1}; // Laver et int array
            string[] stringArray = {"Abe", "Kat", "Ko", "Sæbe", "Alan"}; // Laver et string array
            do {
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 2");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) {
                    case "1":
                        for (int i = 0; i < intArray.Length; i++) { // Udskriver int arrayet
                            Console.Write(intArray[i] + " ");
                        }
                        Console.WriteLine();
                        foreach (string str in stringArray) { // Bruger foreach til at udskrive string arrayet (Det gør ikke noget forksel ville bare bruge foreach)
                            Console.Write(str + " ");
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
        public static bool PublicPrivateOgProtected() {
            do {
                Console.Clear();
                Console.WriteLine("Vælg opgave ved at skrive tilsvarende tal eller gå ud med 2");
                Console.WriteLine("(1) Opgave 1");
                Console.WriteLine("(2) Tilbage til hovedmenu");
                Console.WriteLine();
                Console.Write("Indtast her: ");

                switch (Console.ReadLine()) { // Skriver nogle spørgsmål fra opgaven og svare på dem i strings
                    case "1":
                        Console.WriteLine("Hvad betyder private?");
                        Console.WriteLine("Når noget er private er det kun medlemmer af samme klasse der har adgang til den");
                        Console.WriteLine("Hvad betyder protected?");
                        Console.WriteLine("Protected er meget ligesom private men subklasser kan også få adgang til den");
                        Console.WriteLine("Hvad betyder public?");
                        Console.WriteLine("Public lader mere eller mindre alt i programmet få adgang til den");
                        Console.WriteLine("Hvorfor har vi denne indkapsling?");
                        Console.WriteLine("sikkerhed så man ikke kan ændre på ting der ikke skal ændres på");
                        Console.ReadKey();
                        break;
                    case "2":
                        return false;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
