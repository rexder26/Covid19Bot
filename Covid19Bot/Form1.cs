using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using System.Diagnostics;
using HtmlAgilityPack;

namespace Covid19Bot
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine speechrecog = new SpeechRecognitionEngine();
        SpeechSynthesizer covidbot = new SpeechSynthesizer();

        //int count = 1;

        public Form1()
        {
            InitializeComponent();
            speechrecog.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speechreco_SpeechRecognized);
            LoadEnglish();
            speechrecog.SetInputToDefaultAudioDevice();
            speechrecog.RecognizeAsync(RecognizeMode.Multiple);
            
            

        }

        private void LoadEnglish()
        {
            Choices texts = new Choices();
            string[] lines = File.ReadAllLines(Environment.CurrentDirectory + "\\COM.txt");
            texts.Add(lines);
            Grammar listwords = new Grammar(new GrammarBuilder(texts));
            speechrecog.LoadGrammar(listwords);
        }

        private void speechreco_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //Staring The System By Voice
            richTextBox1.Text = e.Result.Text;
            string speech = e.Result.Text;
            if (speech == "Start")
            {
                Status_dsp.Text = "በመስማት ላይ...";
                Listening_btn.Visible = true;
                Start_btn.Visible = false;
                stop_btn.Visible = false;
                lbl_disp.Text = "ሰላም፣ እኔ ኮቪድ 19 ቦት ነኝ ፡፡ ምን ልርዳዎ?";
                covidbot.Speak("Hey There, am Covid 19 Bot. what can i help you ");
               
            }
            else if (speech == "Stop")
            {
                Status_dsp.Text = "ቆሟል";
                stop_btn.Visible = true;
                Listening_btn.Visible = false;
            }

            if (Status_dsp.Text == "በመስማት ላይ...")
            {
                //Greetings
                if (speech == "hello")
                {
                    lbl_disp.Text = "ሰላም";
                    covidbot.Speak("hello");
                }
                if (speech == "hi")
                {
                    covidbot.Speak("hey there, ");
                    lbl_disp.Text = "ጤና ይስጥልኝ";
                }
                if (speech == "hey")
                {
                    covidbot.Speak("yap!");
                    lbl_disp.Text = "አቤት";
                }
                if (speech == "who are you")
                {
                    lbl_disp.Text = "እኔ ኮቪ-19 ቦት ነኝ. ስለ Covid 19 ሕዝቦችን ማስተማር እችላለሁ ፣ በዚህ ወቅት በጣም አስከፊ ጉዳይ ስለሆነ ሕዝቦችን መርዳት እችላለሁ ፡፡ እኔ በC# የተፃፈ ፕሮግራም ነኝ ፣ ገንቢዬ ናታን ኃይሉ ነው ፡፡ ከእኛ ጋር ስለሆኑ እናመሰግናለን ፡፡";
                    covidbot.Speak("i am Covid 19 Bot. I can Teach Peoples about Covid 19, it is the worest case at this time so i can help peoples. i am program written by C#, my Developer is Nathan Hailu. Thank You for Being with Us.");
                }
                if (speech == "Good Morning")
                {
                    lbl_disp.Text = "እንዴት አደሩ";
                    covidbot.Speak("Good Morning");
                }
                if (speech == "Good evening")
                {
                    lbl_disp.Text = "እንደምን አመሹ";
                    covidbot.Speak("Good evening");
                }
                if (speech == "how are you")
                {
                    lbl_disp.Text = "ደህና ነኝ, እርሶስ?";
                    covidbot.Speak("i am fine and you");
                    
                }
                if (speech == "okay")
                {
                    lbl_disp.Text = "እሺ";
                    covidbot.Speak("okay");

                }
                if (speech == "are you Listening me") { lbl_disp.Text ="አዎ ፣ እኔ እያዳመጥኩ ነው";  covidbot.Speak("Ya, i am Listening."); }
                if (speech == "fine") { lbl_disp.Text ="ጥሩ ፣ የእርስዎ ቀን እንዴት ነው?"; covidbot.Speak("Good, How is your day."); }
                else if (speech == "Great") { lbl_disp.Text ="ጥሩ ፣ የእርስዎ ቀን እንዴት ነው?"; covidbot.Speak("Good, How is your day."); }
                else if (speech == "am fine") {lbl_disp.Text ="ጥሩ ፣ የእርስዎ ቀን እንዴት ነው?";  covidbot.Speak("Good, How is your day."); }
                else if (speech == "am fine thank you") { lbl_disp.Text ="ጥሩ ፣ የእርስዎ ቀን እንዴት ነው?"; covidbot.Speak("Good, How is your day."); }
                if (speech == "it is good") { lbl_disp.Text ="ጥሩ ፣ የእኔም ፡፡ ብዙ ሰዎች እኔን እየጠየቁኝ ነው ፣ በነገራችን ላይ ርቀትን መጠበቅ አይርሱ ፡፡"; covidbot.Speak("Perfect, Mine too. Many peoples are Asking me, by the way dont forget to keep your distance."); }

                //Gratitudes
                if (speech == "Thank you") { lbl_disp.Text ="ምንም አይደለም"; covidbot.Speak("your wellcome!!!"); }
                if (speech == "Good Job") { lbl_disp.Text = "አመሰግናለሁ ☺"; covidbot.Speak("Thank you"); }
                if (speech == "Bye") { lbl_disp.Text = "ደህና ይሁኑ ፣ እንደገና እንገናኛለን።"; covidbot.Speak("Bye, See you again!"); }
                if (speech == "Kill Switch") { lbl_disp.Text ="ደህና ሁንንንንንን ንንንንን"; covidbot.Speak("Byeeeeeeee eeeeee.");
                this.Close();
                }
                //COVID-19 Infromations
                if (speech == "What is Covid 19")
                {
                    lbl_disp.Text = "ኮቪድ 19 አዲስ በሽታ ሲሆን ሳንባ እና የአየር ቧንቧን የሚያጠቃ ነው። ይህም በኮሮና ቫይረስ በሚባል ቫይረስ ይከሰታል።";
                    covidbot.Speak("COVID-19 is a new illness that can affect your lungs and airways. It's caused by a virus called coronavirus.");
                }
                if (speech == "what is the meaning of Covid 19")
                {
                    lbl_disp.Text = "ለcoronavirus disease 2019, አጭር የሆነው COVID-19 በአለም ጤና ድርጅት በዚህ አዲስ ለታወቀው ኮሮናቫይረስ ለተከሰተው በሽታ የተሰጠው ስም ነው ፡፡";
                    covidbot.Speak("COVID-19, short for coronavirus disease 2019, is the official name given by the World Health Organization to the disease caused by this newly identified coronavirus.");
                }
                if (speech == "What Does COVID 19 Stand For")
                {
                    lbl_disp.Text = "ለcoronavirus disease 2019, አጭር የሆነው COVID-19 በአለም ጤና ድርጅት በዚህ አዲስ ለታወቀው ኮሮናቫይረስ ለተከሰተው በሽታ የተሰጠው ስም ነው ፡፡";
                    covidbot.Speak("COVID-19, Stands for coronavirus disease 2019, is the official name given by the World Health Organization to the disease caused by this newly identified coronavirus.");
                }
                if (speech == "Corona")
                {
                    lbl_disp.Text = "ኮሮና, ኮቪድ -19 በሽታን የሚያሰከትል ቫይረስ ነው ፡፡";
                    covidbot.Speak("Corona is a virus that causes The Covid-19 illness.");
                }
                if (speech == "what is corona")
                {
                    lbl_disp.Text = "ኮሮና, ኮቪድ -19 በሽታን የሚያሰከትል ቫይረስ ነው ፡፡";
                    covidbot.Speak("Corona is a virus that causes The Covid-19 Disease.");
                }
               
                if (speech == "what is corona virus")
                {
                    lbl_disp.Text = "ኮሮና, ኮቪድ -19 በሽታን የሚያሰከትል ቫይረስ ነው ፡፡";
                    covidbot.Speak("Corona is a virus that causes The Covid-19 Disease.");
                }
                if (speech == "How does COVID 19 started")
                {
                    lbl_disp.Text="አንዳንድ በሽታዎች ወደ ሰው ከመዛወራቸው በፊት በእንስሳዎች ላይ ይጀመራሉ - እነዚህ ዓይነቶች በሽታዎች ዞኦኖቲክ ተብለው ይጠራሉ (ዞህ-ኡህ-ናህ-ቲክ ይባላል) ፡፡ የ COVID-19 በሽታ እንዲሁ ዞኖቲክ ነው ፣ የመጀመሪያዎቹ ጉዳዮች በታህሳስ ወር ውስጥ በቻይና ውሃን ውስጥ ብቅ ብለዋል ፡፡ የተጎዱት ሰዎች ሁሉም በአቅራቢያው ከሚገኙበት የቀጥታ እንስሳት ከሚሸጡበትና ባለሙያዎቹ በሽታው እንደጀመረ ከሚያስቡበት ገበያ ጋር የተገናኙ ናቸው ፡፡";
                    covidbot.Speak("Some diseases start in animals before spreading to humans—these types of diseases are called zoonotic (pronounced zoh-uh-NAH-tik). The COVID-19 disease is also zoonotic, with the first cases popping up in December 2019 in Wuhan, China. The affected humans were all connected to a nearby market where live animals were sold, and where experts think the disease got its start.");
                }
                if (speech == "how long can Covid 19 survive on surface")
                {
                    lbl_disp.Text="በፕላስቲክ እና አይዝጌ ብረት ላይ 72 ሰዓታት ፡፡ በመዳብ ላይ 4 ሰዓታት. 24 ሰዓታት በካርቶን ላይ ፡፡";
                    covidbot.Speak("72 hours on plastic and stainless steel.  4 hours on copper.  24 hours on cardboard. ");
                }
                if (speech == "in what country does covid 19 started")
                {
                    lbl_disp.Text="የመጀመሪያዎቹ ጉዳዮች በታህሳስ ወር ውስጥ በቻይና ውሃን ውስጥ ብቅ ብለዋል ፡፡ የተጎዱት ሰዎች ሁሉም በአቅራቢያው ከሚገኙበት የቀጥታ እንስሳት ከሚሸጡበትና ባለሙያዎቹ በሽታው እንደጀመረ ከሚያስቡበት ገበያ ጋር የተገናኙ ናቸው ፡፡";
                    covidbot.Speak("the first cases popping up in December 2019 in Wuhan, China.");
                }
                if (speech == "How is COVID 19 transmitted")
                {
                    lbl_disp.Text = "COVID-19 በትንሽ ጠብታዎች ከሳል ወይም በማስነጠስ ሊተላለፍ ይችላል ፣ ለዚህም ነው ሐኪሞች በሚስሉበት ወይም በሚያስነጥሱበት ጊዜ ሁል ጊዜ አፍዎን በክርንዎ መሸፈን አለብዎት የሚሉት ፡፡ እንዲሁም የበሩን እጀታ በመንካት ይተላለፋል ፡፡";
                    covidbot.Speak("COVID-19 can be transmitted by little droplets from coughs or sneezes, which is why doctors say you should always cover your mouth with your elbow when you cough or sneeze. You could also pick it up by touching doorknobs.");
                }
                if (speech == "How can someone get infected by covid 19")
                {
                    lbl_disp.Text = "COVID-19 በትንሽ ጠብታዎች ከሳል ወይም በማስነጠስ ሊተላለፍ ይችላል ፣ ለዚህም ነው ሐኪሞች በሚስሉበት ወይም በሚያስነጥሱበት ጊዜ ሁል ጊዜ አፍዎን በክርንዎ መሸፈን አለብዎት የሚሉት ፡፡ እንዲሁም የበሩን እጀታ በመንካት ይተላለፋል ፡፡";
                    covidbot.Speak("COVID-19 can be transmitted by little droplets from coughs or sneezes, which is why doctors say you should always cover your mouth with your elbow when you cough or sneeze. You could also pick it up by touching doorknobs.");
                }
                //Preventions
                if (speech == "how can we prevent from corona virus")
                {
                    lbl_disp.Text = "ጭምብሎችን ይልበሱ ፣ እና ማህበራዊ ርቀትዎን ይጠብቁ ፣ ከታመሙ በቤትዎ ይቆዩ ፣ የሕክምና ዕርዳታ ለማግኘት አስቀድመው ወደ 8335 ይደውሉ";
                    covidbot.Speak("Wear Masks, And keep your Social Distance, Stay home if you are sick, to get medical care call to 83 35");
                }
                if (speech == "how can we prevent corona virus")
                {
                    lbl_disp.Text = "ጭምብሎችን ይልበሱ ፣ እና ማህበራዊ ርቀትዎን ይጠብቁ ፣ ከታመሙ በቤትዎ ይቆዩ ፣ የሕክምና ዕርዳታ ለማግኘት አስቀድመው ወደ 8335 ይደውሉ";
                    covidbot.Speak("Wear Masks, And keep your Social Distance, Stay home if you are sick, to get medical care call to 83 35");
                }
                if (speech == "how can we prevent covid 19")
                {
                    lbl_disp.Text = "በተቻለ መጠን ቤትዎን ይቆዩ እና ከሌሎች ጋር የጠበቀ ግንኙነትን ያስወግዱ ፡፡ በሕዝብ አከባቢዎች ውስጥ አፍንጫዎን እና አፍዎን የሚሸፍን ጭምብል ያድርጉ ፡፡ በተደጋጋሚ የሚነኩ ንጣፎችን ማጽዳትና በፀረ-ተባይ ማጥራት ፡፡ እጅዎን በሳሙና እና በውሃ ቢያንስ ለ 20 ሰከንድ ይታጠቡ ፣ ወይም ቢያንስ 60% አልኮልን የያዘ በአልኮል የተደገፈ የእጅ ማጽጃ ይጠቀሙ ፡፡";
                    covidbot.Speak("Stay home as much as possible and avoid close contact with others. Wear a mask that covers your nose and mouth in public settings. Clean and disinfect frequently touched surfaces. Wash your hands often with soap and water for at least 20 seconds, or use an alcoholbased hand sanitizer that contains at least 60% alcohol.");
                }
                if (speech == "what is the preventing method")
                {
                    lbl_disp.Text = "በተቻለ መጠን ቤትዎን ይቆዩ እና ከሌሎች ጋር የጠበቀ ግንኙነትን ያስወግዱ ፡፡ በሕዝብ አከባቢዎች ውስጥ አፍንጫዎን እና አፍዎን የሚሸፍን ጭምብል ያድርጉ ፡፡ በተደጋጋሚ የሚነኩ ንጣፎችን ማጽዳትና በፀረ-ተባይ ማጥራት ፡፡ እጅዎን በሳሙና እና በውሃ ቢያንስ ለ 20 ሰከንድ ይታጠቡ ፣ ወይም ቢያንስ 60% አልኮልን የያዘ በአልኮል የተደገፈ የእጅ ማጽጃ ይጠቀሙ ፡፡";
                    covidbot.Speak("Stay home as much as possible and avoid close contact with others. Wear a mask that covers your nose and mouth in public settings. Clean and disinfect frequently touched surfaces. Wash your hands often with soap and water for at least 20 seconds, or use an alcoholbased hand sanitizer that contains at least 60% alcohol.");
                }
                if (speech == "how can we prevent")
                {
                    lbl_disp.Text = "ጭምብሎችን ይልበሱ ፣ እና ማህበራዊ ርቀትዎን ይጠብቁ ፣ ከታመሙ በቤትዎ ይቆዩ ፣ የሕክምና ዕርዳታ ለማግኘት አስቀድመው ወደ 8335 ይደውሉ";
                    covidbot.Speak("Wear Masks, And keep your Social Distance, Stay home if you are sick, to get medical care call to 83 35");
                }
                if (speech == "how can we prevent it")
                {
                    lbl_disp.Text = "ጭምብሎችን ይልበሱ ፣ እና ማህበራዊ ርቀትዎን ይጠብቁ ፣ ከታመሙ በቤትዎ ይቆዩ ፣ የሕክምና ዕርዳታ ለማግኘት አስቀድመው ወደ 8335 ይደውሉ";
                    covidbot.Speak("Wear Masks, And keep your Social Distance, Stay home if you are sick, to get medical care call to 83 35");
                }
                if (speech == "how can i protect my self")
                {
                    lbl_disp.Text = "በተቻለ መጠን ቤትዎን ይቆዩ እና ከሌሎች ጋር የጠበቀ ግንኙነትን ያስወግዱ ፡፡ በሕዝብ አከባቢዎች ውስጥ አፍንጫዎን እና አፍዎን የሚሸፍን ጭምብል ያድርጉ ፡፡ በተደጋጋሚ የሚነኩ ንጣፎችን ማጽዳትና በፀረ-ተባይ ማጥራት ፡፡ እጅዎን በሳሙና እና በውሃ ቢያንስ ለ 20 ሰከንድ ይታጠቡ ፣ ወይም ቢያንስ 60% አልኮልን የያዘ በአልኮል የተደገፈ የእጅ ማጽጃ ይጠቀሙ ፡፡";
                    covidbot.Speak("Stay home as much as possible and avoid close contact with others. Wear a mask that covers your nose and mouth in public settings. Clean and disinfect frequently touched surfaces. Wash your hands often with soap and water for at least 20 seconds, or use an alcoholbased hand sanitizer that contains at least 60% alcohol.");
                }
                if (speech == "What are The Sign of covid 19") 
                {
                    lbl_disp.Text = "ከሰው ወደ ሰው ይለያያል ፣ ግን የተለመደው ትኩሳት ፣ ደረቅ ሳል ፣ ከፍተኛ የሰውነት ሙቀት ነው። እነዚህ ምልክቶች ካሉዎት እባክዎ ወደ 83 35 ይደውሉ ፡፡";
                    covidbot.Speak("it vary from person to person, but the common is high fever, dry cough, high body temprature. if you have these Signs Please Call 83 35.");
                }
                if (speech == "What are the Symptoms of covid 19") 
                {
                    lbl_disp.Text = "ከሰው ወደ ሰው ይለያያል ፣ ግን የተለመደው ትኩሳት ፣ ደረቅ ሳል ፣ ከፍተኛ የሰውነት ሙቀት ነው። እነዚህ ምልክቶች ካሉዎት እባክዎ ወደ 8335 ይደውሉ ፡፡";
                    covidbot.Speak("it vary from person to person, but the common is high fever, dry cough, high body temprature. if you have these Signs Please Call 83 35.");
                }
                if (speech == "Do you Know about the Renaissance Dam") { lbl_disp.Text = "የኢትዮጵያውያን ግድብ ፣ ታላቁ የኢትዮጵያ ህዳሴ ግድብ በአባይ ወንዝ ላይ የተገነባ ግድብ እንደሆነ አውቃለሁ ፡፡ የተሠራው በኢትዮጵያ ሕዝቦች ጠንካራ ስራ እና ገንዘብ ነው ፡፡ በነገራችን ላይ እኔን የሰራኝም ኢትዮጵያዊ ነው ፡፡"; covidbot.Speak("ethiopian Dam, the Grand Ethiopian Renaissance Dam i know it it is dam built on The Abbay River. it is made by Ethiopian Peoples Hard work and money. By the way my Creator is Ethiopian too."); }
                //if (speech == " ") { covidbot.Speak(""); }
                //if (speech == " ") { covidbot.Speak(""); }

                //COVID-19 Reports
                if (speech == "How many Covid Cases are in ethiopia")
                {
                    //Check for insternet connection if there is connection =,report else , = There is no internet connection
                    covidbot.Speak("Processing, Please wait...");
                    //WEB Scrab For Ethiopian Report
                    HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
                    HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.accuweather.com/en/et/national/covid-19");
                    foreach (var item in doc.DocumentNode.SelectNodes("//div[@class='confirmed']"))
                    {
                        if (item.InnerText != " ")
                        {
                            lbl_disp.Text = "Total Cases: " + item.InnerText;
                            covidbot.Speak("total Cases, " + item.InnerText);
                        }
                        else
                        {
                            covidbot.Speak("There is No data.");
                        }
                    }
                    try{
                        
                    }
                    catch (Exception)
                    { 
                        covidbot.Speak("SomeThing went wrong. There is no internet");
                    }
                    


                }
                if (speech == "Show Covid 19 Reports") { covidbot.Speak("Opening Reports from The internet."); System.Diagnostics.Process.Start("https://www.accuweather.com/en/et/national/covid-19"); }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Status_dsp.Text = "በመጀመር ላይ...";
            lbl_disp.Text = " ";
            stop_btn.Visible = false;
            Start_btn.Visible = false;
            Listening_btn.Visible = false;
            //The Button and Lable
            if(Status_dsp.Text=="በመጀመር ላይ...")
            {
                stop_btn.Visible = false;
                Start_btn.Visible = true;
                Listening_btn.Visible = false;
            }
            else if (Status_dsp.Text == "በመስማት ላይ...")
            {
                stop_btn.Visible = false;
                Start_btn.Visible = false;
                
            }
            else if (Status_dsp.Text == "ቆሟል")
            {
                stop_btn.Visible = true;
                Start_btn.Visible = false;
                
            }
        }

        private void control_btn_Click(object sender, EventArgs e)
        {
            //By Clicking the Button
            if (Status_dsp.Text == "በመጀመር ላይ...")
            {
                Status_dsp.Text = "በመስማት ላይ...";
                Listening_btn.Visible = true;
                Start_btn.Visible = false;
            }
            else if (Status_dsp.Text == "ቆሟል")
            {
                Status_dsp.Text = "በመስማት ላይ...";
                Listening_btn.Visible = true;
                stop_btn.Visible = false;
            }
            else
            {
                Status_dsp.Text = "ቆሟል";
                stop_btn.Visible = true;
                Listening_btn.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Listening_btn_Click(object sender, EventArgs e)
        {
            //By Clicking the Button
            if (Status_dsp.Text == "በመጀመር ላይ...")
            {
                Status_dsp.Text = "በመስማት ላይ...";
                Listening_btn.Visible = true;
                Start_btn.Visible = false;
            }
            else if (Status_dsp.Text == "ቆሟል")
            {
                Status_dsp.Text = "በመስማት ላይ...";
                Listening_btn.Visible = true;
                stop_btn.Visible = false;
            }
            else
            {
                Status_dsp.Text = "ቆሟል";
                stop_btn.Visible = true;
                Listening_btn.Visible = false;
            }
        }
    }
}
