/*
 *    ICSC0323 | Object Oriented Programming
 *              
 *              Lab Exercise 2
 *              
 *              
 *    
 *    Author: Barata, Nicko James E.
 *    Section: BSCS-SD2A
 *    
 *    Program: MusicBox Instrument Store
 *    
 *    Description: 
 *    - This program showcases the fundamental concepts of object-oriented  
 *      programming (OOP), including encapsulation, inheritance, polymorphism,  
 *      and object creation. It allows users to explore musical instruments,  
 *      each represented as an object with unique attributes and behaviors.  
 *      Encapsulation is applied through private fields and public getters,  
 *      ensuring data security. Inheritance enables specialized instrument  
 *      classes to extend a base class, promoting code reuse. Polymorphism is  
 *      demonstrated by overriding methods for customized functionality.  
 *      
 *    - The program also enhances the console interface with Unicode  
 *      and ASCII art, making the user experience more visually engaging  
 *      while maintaining functionality.  
 *  
 *    - Each product in the music store is represented as an object, featuring  
 *      a sampleFile attribute that allows audio (.wav) playback. This unique 
 *      feature enables users to hear instrument samples directly from the terminal,  
 *      providing a more immersive experience while interacting with the program.  
 */



using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;



/*
 * MY CLASS STRUCTURE:
 * 
 *      Instrument (Base Class)
 *      │
 *      ├── Guitar : Instrument
 *      │   ├── AcousticGuitar : Guitar
 *      │   ├── ElectricGuitar : Guitar
 *      │   └── Ukulele : Guitar
 *      │
 *      ├── Piano : Instrument
 *      │   ├── GrandPiano : Piano
 *      │   ├── Keyboard : Piano
 *      │   └── Organ : Piano
 *      │
 *      └── Drums : Instrument
 *          ├── SnareDrum : Drums
 *          ├── BassDrum : Drums
 *          └── TomToms : Drums
 *          
 */



namespace BarataLabExercise2
{

    // Base Class: Instrument

    class Instrument
    {
        // declare instrument attributes as private (for encapsulation) using an underscore prefix to follow naming conventions for private fields
        private string _brand;
        private string _model;
        private double _price;
        private string _sampleFile;

        
        public Instrument(string brand, string model, double price, string sampleFile)
        {
            // constructor to initialise object variables
            this._brand = brand;
            this._model = model;
            this._price = price;
            this._sampleFile = sampleFile;
        }


        // getter and setter property of the _brand attribute
        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }

        // getter and setter property of the _model attribute
        public string Model
        {
            get => _model;
            set => _model = value;
        }

        // getter and setter property of the _price attribute
        public double Price
        {
            get => _price;
            set => _price = value;
        }


        public virtual void GetInfo()
        {
            // method for printing all information
            Console.WriteLine($"\n\tBrand: {_brand}");
            Console.WriteLine($"\tModel: {_model}");
            Console.WriteLine($"\tPrice: ₱{_price}");
        }

        public virtual string GetDescription()
        {
            // method to print description about the instrument product
            return "Instruments make you feel more alive!";
        }

        public virtual void Play()
        {
            // play the sample .wav audio file
            SoundPlayer.Play(_sampleFile);
        }
    }





    // =====  Guitar Instrument Category  ===== //
    class Guitar : Instrument
    {
        // declare guitar-specific attribute as protected (accessible within this class and derived classes)
        protected int _numberOfStrings;

        public Guitar(string brand, string model, double price, string sampleFile, int numberOfStrings)
            : base(brand, model, price, sampleFile)
        {
            // constructor to initialise object variables
            this._numberOfStrings = numberOfStrings;
        }

        // getter and setter of number of strings attribute
        public int NumberOfStrings
        {
            get => _numberOfStrings;
            set => _numberOfStrings = value;
        }

        public override void GetInfo()
        {
            // print guitar-specific attributes
            base.GetInfo();
            Console.WriteLine($"\tCategory: Guitar");
            Console.WriteLine($"\tNumber of Strings: {_numberOfStrings}");
        }
    }


    // AcousticGuitar Class
    class AcousticGuitar : Guitar
    {
        public AcousticGuitar(string brand, string model, double price, string sampleFile, int numberOfStrings)
            : base(brand, model, price, sampleFile, numberOfStrings) { }

        public override string GetDescription()
        {
            return "A wooden guitar that produces sound naturally.";
        }
    }


    // ElectricGuitar Class
    class ElectricGuitar : Guitar
    {
        public ElectricGuitar(string brand, string model, double price, string sampleFile, int numberOfStrings)
            : base(brand, model, price, sampleFile, numberOfStrings) { }

        public override string GetDescription()
        {
            return "A guitar designed for rock and metal.";
        }
    }


    // Ukulele Class
    class Ukulele : Guitar
    {
        public Ukulele(string brand, string model, double price, string sampleFile, int numberOfStrings)
            : base(brand, model, price, sampleFile, numberOfStrings) { }

        public override string GetDescription()
        {
            return "A small four-stringed guitar with a cheerful tone.";
        }

        public virtual void Play()
        {
            // play the sample .wav audio file
            SoundPlayer.Play("ukulele.wav");
        }
    }





    // =====  Piano Instrument Category  ===== //
    class Piano : Instrument
    {
        // declare piano-specific attribute as protected (accessible within this class and derived classes)
        protected int _keyCount;

        public Piano(string brand, string model, double price, string sampleFile, int keyCount)
            : base(brand, model, price, sampleFile)
        {
            // constructor to initialise object variables
            this._keyCount = keyCount;
        }

        // getter and setter property of keyCount attribute
        public int KeyCount
        {
            get => _keyCount;
            set => _keyCount = value;
        }

        public override void GetInfo()
        {
            // print piano-specific attributes
            base.GetInfo();
            Console.WriteLine($"\tCategory: Piano");
            Console.WriteLine($"\tNumber of Keys: {_keyCount}");
        }
    }


    // GrandPiano Class
    class GrandPiano : Piano
    {
        public GrandPiano(string brand, string model, double price, string sampleFile, int keyCount)
            : base(brand, model, price, sampleFile, keyCount) { }

        public override string GetDescription()
        {
            return "A full-size grand piano with a rich and smooth touch.";
        }
    }


    // Keyboard Class
    class Keyboard : Piano
    {
        public Keyboard(string brand, string model, double price, string sampleFile, int keyCount)
            : base(brand, model, price, sampleFile, keyCount) { }

        public override string GetDescription()
        {
            return "A digital piano with various sounds and effects.";
        }
    }


    // Organ Class
    class Organ : Piano
    {
        public Organ(string brand, string model, double price, string sampleFile, int keyCount)
            : base(brand, model, price, sampleFile, keyCount) { }

        public override string GetDescription()
        {
            return "An instrument known for producing sustained notes.";
        }
    }





    // =====  Drums Instrument Category  ===== //
    class Drums : Instrument
    {
        // declare drum-specific attribute as protected (accessible within this class and derived classes)
        protected int _drumSize;

        public Drums(string brand, string model, double price, string sampleFile, int drumSize)
            : base(brand, model, price, sampleFile)
        {
            // constructor to initialise object variables
            this._drumSize = drumSize;
        }

        // getter and setter property of drumSize attribute
        public int DrumSize
        {
            get => _drumSize;
            set => _drumSize = value;
        }

        public override void GetInfo()
        {
            // print drum-specific attributes
            base.GetInfo();
            Console.WriteLine($"\tCategory: Drums");
            Console.WriteLine($"\tDrum Size: {_drumSize} inches");
        }
    }


    // SnareDrum Class
    class SnareDrum : Drums
    {
        public SnareDrum(string brand, string model, double price, string sampleFile, int drumSize)
            : base(brand, model, price, sampleFile, drumSize) { }

        public override string GetDescription()
        {
            return "A high-pitched drum with a sharp and snappy sound.";
        }
    }


    // BassDrum Class
    class BassDrum : Drums
    {
        public BassDrum(string brand, string model, double price, string sampleFile, int drumSize)
            : base(brand, model, price, sampleFile, drumSize) { }

        public override string GetDescription()
        {
            return "A low-pitched drum played with a foot pedal.";
        }
    }


    // TomToms Class
    class TomToms : Drums
    {
        public TomToms(string brand, string model, double price, string sampleFile, int drumSize)
            : base(brand, model, price, sampleFile, drumSize) { }

        public override string GetDescription()
        {
            return "A set of tuned drums used for rhythm.";
        }
    }





    

    internal class Program
    {

        static void Main()
        {
            // EXAMPLE: Creation of objects using Base Class
            Instrument instrumentObj = new Instrument("Generic", "Guitar", 1500.00, "instrument.wav");
            instrumentObj.Play();

            // EXAMPLE: Creation of objects using Derived Classes
            Dictionary<string, List<Instrument>> inventory = new Dictionary<string, List<Instrument>>()
            { 
                // list of predetermined (in-stock) Acoustic Guitar objects
                { "Acoustic Guitar", new List<Instrument>()
                    {
                        new AcousticGuitar("Yamaha", "FG800", 15000, "acoustic_yamaha.wav", 6),
                        new AcousticGuitar("Fender", "CD-60", 18000, "acoustic_fender.wav", 6),
                        new AcousticGuitar("Taylor", "Academy 10", 25000, "acoustic_taylor.wav", 6)
                    }
                },

                // list of predetermined (in-stock) Electric Guitar objects
                { "Electric Guitar", new List<Instrument>()
                    {
                        new ElectricGuitar("Gibson", "Les Paul", 70000, "electric_gibson.wav", 6),
                        new ElectricGuitar("Ibanez", "RG550", 40000, "electric_ibanez.wav", 6),
                        new ElectricGuitar("PRS", "Custom 24", 65000, "electric_prs.wav", 6)
                    }
                },

                // list of predetermined (in-stock) Ukulele objects
                { "Ukulele", new List<Instrument>()
                    {
                        new Ukulele("Kala", "KA-15S", 5000, "ukulele_kala.wav", 4),
                        new Ukulele("Lanikai", "LU-21", 7000, "ukulele_lanikai.wav", 4),
                        new Ukulele("Cordoba", "20TM", 8000, "ukulele_cordoba.wav", 4)
                    }
                },

                // list of predetermined (in-stock) Grand Piano objects
                { "Grand Piano", new List<Instrument>()
                    {
                        new GrandPiano("Steinway", "Model D", 2000000, "grand_steinway.wav", 88),
                        new GrandPiano("Yamaha", "CFX", 1200000, "grand_yamaha.wav", 88),
                        new GrandPiano("Kawai", "EX", 1000000, "grand_kawai.wav", 88)
                    }
                },

                // list of predetermined (in-stock) Keyboard objects
                { "Keyboard", new List<Instrument>()
                    {
                        new Keyboard("Roland", "FP-30X", 50000, "keyboard_roland.wav", 61),
                        new Keyboard("Yamaha", "P-125", 45000, "keyboard_yamaha.wav", 61),
                        new Keyboard("Casio", "PX-S1100", 30000, "keyboard_casio.wav", 61)
                    }
                },

                // list of predetermined (in-stock) Organ objects
                { "Organ", new List<Instrument>()
                    {
                        new Organ("Hammond", "B-3", 150000, "organ_hammond.wav", 61),
                        new Organ("Yamaha", "Stagea", 120000, "organ_yamaha.wav", 61),
                        new Organ("Viscount", "Cantorum VI", 100000, "organ_viscount.wav", 61)
                    }
                },

                // list of predetermined (in-stock) Snare Drum objects
                { "Snare Drum", new List<Instrument>()
                    {
                        new SnareDrum("Ludwig", "Supraphonic", 35000, "snare_ludwig.wav", 14),
                        new SnareDrum("Pearl", "Sensitone", 25000, "snare_pearl.wav", 14),
                        new SnareDrum("Tama", "S.L.P", 28000, "snare_tama.wav", 14)
                    }
                },

                // list of predetermined (in-stock) Bass Drum objects
                { "Bass Drum", new List<Instrument>()
                    {
                        new BassDrum("DW", "Collector's", 45000, "bass_dw.wav", 22),
                        new BassDrum("Pearl", "Reference", 40000, "bass_pearl.wav", 22),
                        new BassDrum("Yamaha", "Maple", 38000, "bass_yamaha.wav", 22)
                    }
                },

                // list of predetermined (in-stock) TomTom objects
                { "Tom Toms", new List<Instrument>()
                    {
                        new TomToms("Gretsch", "USA", 30000, "tom_gretsch.wav", 12),
                        new TomToms("Mapex", "Saturn V", 25000, "tom_mapex.wav", 10),
                        new TomToms("Tama", "Starclassic", 27000, "tom_tama.wav", 13)
                    }
                }
            };

            // some encoding stuff for printing in terminal
            Console.OutputEncoding = Encoding.UTF8;



            // MAIN PROGRAM LOOP
            while (true)
            {
                // display store name and author
                DisplayStoreHeader();

                // FIRST MENU: display instrument options
                DisplayInstrumentsMenu(instrumentObj);

                // get user input for instrument category choice
                string choice = Console.ReadLine();

                string instrumentType = "";
                List<string> subtypes = new List<string>();

                switch (choice)
                {
                    case "1":
                        // initialize subtype names if user selected Guitar
                        instrumentType = "Guitar";
                        subtypes = new List<string> { "Acoustic Guitar", "Electric Guitar", "Ukulele" };
                        break;
                    case "2":
                        // initialize subtype names if user selected Piano
                        instrumentType = "Piano";
                        subtypes = new List<string> { "Grand Piano", "Keyboard", "Organ" };
                        break;
                    case "3":
                        // initialize subtype names if user selected Drums
                        instrumentType = "Drums";
                        subtypes = new List<string> { "Snare Drum", "Bass Drum", "Tom Toms" };
                        break;
                    case "0":
                        // if user decides to exit
                        Console.SetCursorPosition(0, 18);
                        PrintWithBorder("\tThank you for visiting! Goodbye.");
                        Console.SetCursorPosition(26, 17);
                        Console.Write(new string(' ', 10));
                        Console.SetCursorPosition(56, 18);
                        Thread.Sleep(2000);
                        Console.Clear();
                        return;
                    default:
                        // handle error if user input is invalid
                        Console.SetCursorPosition(0, 18);
                        PrintWithBorder("\tInvalid selection! Try again!");
                        Console.SetCursorPosition(26, 15);
                        Console.Write(new string(' ', 10));
                        Console.SetCursorPosition(26, 15);
                        Thread.Sleep(1000);
                        continue;
                }


                // SECOND MENU
                int subtypeIndex;
                while (true)
                {
                    // DISPLAY: instrument subtypes options
                    DisplaySubtypesMenu(instrumentType, subtypes);

                    // INPUT: validate user input for subtype of instrument
                    if (!int.TryParse(Console.ReadLine(), out subtypeIndex) || subtypeIndex < 0 || subtypeIndex > subtypes.Count)
                    {
                        Console.SetCursorPosition(0, 18);
                        PrintWithBorder("\tInvalid selection! Try again!");
                        Console.SetCursorPosition(26, 17);
                        Console.Write(new string(' ', 10));
                        Console.SetCursorPosition(26, 17);
                        Thread.Sleep(1000);
                    } else { break; }
                }

                // allow user to go back
                if (subtypeIndex == 0)
                    continue;



                // select the specific subtype from the dictionary
                string selectedSubtype = subtypes[subtypeIndex - 1];

                if (!inventory.ContainsKey(selectedSubtype))
                {
                    PrintWithBorder("\n\tNo instruments available for this type. Returning to main menu...");
                    Thread.Sleep(1000);
                    continue;
                }

                // initialize available instruments based on user choice of instruments and subtypes
                List<Instrument> availableInstruments = inventory[selectedSubtype];



                // THIRD MENU
                int modelIndex;
                while (true)
                {
                    // DISPLAY: available specific products of instruments
                    DisplayBrandMenu(selectedSubtype, availableInstruments);

                    // INPUT: validate input for selection of instrument
                    if (!int.TryParse(Console.ReadLine(), out modelIndex) || modelIndex < 0 || modelIndex > availableInstruments.Count)
                    {
                        Console.SetCursorPosition(0, 18);
                        PrintWithBorder("\tInvalid selection! Try again!");
                        Console.SetCursorPosition(26, 16);
                        Console.Write(new string(' ', 10));
                        Console.SetCursorPosition(26, 16);
                        Thread.Sleep(1000);
                        continue;
                    } else { break; }
                }

                // allow user to go back
                if (modelIndex == 0)
                    continue;



                // assign the selected model of instrumment to a variable
                Instrument selectedInstrument = availableInstruments[modelIndex - 1];

                // DISPLAY: Instrument Details
                DisplayInstrumentDetails(selectedInstrument);

                // PLAY: selected model of instrument (play .wav file for sample)
                selectedInstrument.Play();

                // get user input if proceeds to buy or not
                string buyInput = Console.ReadLine();
                if (buyInput == "y" || buyInput == "Y")
                {
                    Console.SetCursorPosition(0, 23);
                    PrintWithBorder("\t   Thank you for purchasing. Please come again!");
                    Console.ReadKey();
                } else { continue; }
            }
        }



        public static void DisplayStoreHeader()
        {
            // HEADER: display store name and author name
            string storeName = "The MusicBox Instrument Store";
            string studentName = "Nicko James E. Barata";

            // refresh the console first
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("🔊 ON");
            Console.ResetColor();
            Console.WriteLine("\n\n");

            // header upper border
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t     ╭─────────────────────────────────────────╮");
            Console.Write("\t\t╭────────────┤      ");

            // store name
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(storeName);
            Console.ResetColor();

            // header lower border
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("      ├────────────╮");
            Console.WriteLine("\t\t│\t     ╰─────────────────────────────────────────╯\t    │");
            Console.ResetColor();

            // display student name 
            DrawLeftBorder();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"\t\t  Created By: {studentName}");
            Console.ResetColor();
            DrawRightBorder(17);
        }


        public static void DisplayInstrumentsMenu(Instrument baseObject)
        {
            // FIRST MENU: display available instruments category
            PrintWithBorder("\n");
            PrintWithBorder("\n");
            // display welcome message with the base class description
            PrintWithBorder("\t🎵 Welcome to MusicBox - Your one-stop music shop!");
            PrintWithBorder($"\t{baseObject.GetDescription()}");
            PrintWithBorder("\n");
            PrintWithBorder("\tWhat instrument would you like to explore?");
            PrintWithBorder("\t1. Guitar");
            PrintWithBorder("\t2. Piano");
            PrintWithBorder("\t3. Drums");
            PrintWithBorder("\t0. Exit");
            PrintWithBorder("\n");
            PrintWithBorder("\t> ");
            PrintWithBorder("\n");
            PrintWithBorder("\n");
            DrawBottomBorder();
            Console.SetCursorPosition(26, 18);
        }

        public static void DisplaySubtypesMenu(string instrumentType, List<string> subtypes)
        {
            // SECOND MENU: display subtype menu
            Console.Clear();
            DisplayStoreHeader();
            PrintWithBorder("\n");
            PrintWithBorder("\n");
            PrintWithBorder($"\tWelcome to the {instrumentType} section!");
            PrintWithBorder("\n");
            PrintWithBorder($"\tChoose a {instrumentType} type:");
            subtypes.Select((s, i) => $"\t{i + 1}. {s}").ToList().ForEach(PrintWithBorder);
            PrintWithBorder("\t0. Back");
            PrintWithBorder("\n");
            PrintWithBorder("\t> ");
            DrawBottomBorder();
            Console.SetCursorPosition(26, 17);
        }


        public static void DisplayBrandMenu(string selectedSubtype, List<Instrument> availableInstruments)
        {
            // THIRD MENU: display brand menu
            Console.Clear();
            DisplayStoreHeader();
            PrintWithBorder("\n");
            PrintWithBorder("\n");
            PrintWithBorder($"\tAvailable {selectedSubtype}s:");
            // EXAMPLE: encapsulated data access
            availableInstruments.Select((inst, i) => (inst, i)).ToList().ForEach(t =>
                PrintWithBorder($"\t{t.i + 1}. {t.inst.Brand} {t.inst.Model} (₱{t.inst.Price})")
            );
            PrintWithBorder("\t0. Back");
            PrintWithBorder("\n");
            PrintWithBorder("\tWhich would you like to try? ");
            PrintWithBorder("\t> ");
            PrintWithBorder("\n");
            DrawBottomBorder();
            Console.SetCursorPosition(26, 16);
        }


        public static void DisplayInstrumentDetails(Instrument selectedInstrument)
        {
            // method to display the selected instrument details 
            Console.Clear();
            DisplayStoreHeader();
            PrintWithBorder("\n");
            PrintWithBorder("\n");
            PrintWithBorder("\t╭────── Instrument Details ──────╮");
            PrintWithBorder($"\t│  ".PadRight(34) + $"│");
            // EXAMPLE: encapsulated data access
            PrintWithBorder($"\t│         Brand: {selectedInstrument.Brand}".PadRight(34) + "│");
            PrintWithBorder($"\t│         Model: {selectedInstrument.Model}".PadRight(34) + "│    🎶 NOW PLAYING 🎶");
            PrintWithBorder($"\t│         Price: ₱{selectedInstrument.Price}".PadRight(34) + "│");
            PrintWithBorder($"\t│  ".PadRight(34) + "│");
            PrintWithBorder($"\t╰".PadRight(34, '─') + "╯");
            PrintWithBorder($"\n");
            PrintWithBorder($"\t  Description:");
            PrintWithBorder($"\t  ⤷ {selectedInstrument.GetDescription()}");
            PrintWithBorder("\n");
            PrintWithBorder("\n");
            PrintWithBorder("\t   Would you like to buy now (y/n)? ");
            PrintWithBorder("\n");
            DrawBottomBorder();
            Console.SetCursorPosition(60, 21);
        }


        public static void PrintWithBorder(string text)
        {
            // method to draw program contents with borders
            DrawLeftBorder();
            if (text != "\n")
            {
                Console.Write(text);
                DrawRightBorder(61 - text.Length);
            } else
            {
                DrawRightBorder(67);
            }
        }


        public static void DrawLeftBorder()
        {
            // method to draw left border for console design
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t\t│");
            Console.ResetColor();
        }


        public static void DrawRightBorder(int space)
        {
            // method to draw right border for console design
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(new string(' ', space));
            Console.WriteLine("│");
            Console.ResetColor();
        }

        public static void DrawBottomBorder()
        {
            // method to draw bottom border for console design
            PrintWithBorder("\n");
            PrintWithBorder("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\t\t╰{new string('─', 67)}╯");
            Console.ResetColor();
        }
    }
}




// the class responsible for audio output in the terminal
class SoundPlayer
{
    // import necessary packages for playing audio
    [DllImport("winmm.dll", SetLastError = true)]
    public static extern bool PlaySound(string pszSound, IntPtr hmod, uint fdwSound);

    public const uint SND_ASYNC = 0x0001;
    public const uint SND_FILENAME = 0x00020000;

    public static void Play(string filePath)
    {
        // make sure that the wav file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: Sound file not found!");
            return;
        }
        PlaySound(filePath, IntPtr.Zero, SND_ASYNC | SND_FILENAME);
    }
}