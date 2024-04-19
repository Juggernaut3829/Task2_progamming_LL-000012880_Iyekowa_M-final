using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Task2_progamming_LL_000012880_Iyekowa_M
{
    /// <summary>
    /// Interaction logic for Infomation.xaml
    /// </summary>
    public partial class Infomation : Window
    {
        public Infomation()
        {
            InitializeComponent();
        }
        private void Account_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            this.Close();
            account.Show();
        }

        private void Map_Click(object sender, RoutedEventArgs e)
        {
            Map map = new Map();
            this.Close();
            map.Show();
        }

        private void Book_Click(object sender, RoutedEventArgs e)
        {
            Booking booking = new Booking();
            this.Close();
            booking.Show();
        }

        private void Vist_Click(object sender, RoutedEventArgs e)
        {
            Visiting visiting = new Visiting();
            this.Close();
            visiting.Show();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            AboutUs aboutus = new AboutUs();
            this.Close();
            aboutus.Show();
        }

        private void Articles_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You are currently on this page");

        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            this.Close();
            register.Show();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }

        private void Deal_Click(object sender, RoutedEventArgs e)
        {
            Discount discount = new Discount();
            this.Close();
            discount.Show();
        }

        private void Message_Click(object sender, RoutedEventArgs e)
        {
            ContactUs contactUs = new ContactUs();
            this.Close();
            contactUs.Show();
        }

        private void Policy_Click(object sender, RoutedEventArgs e)
        {
            Policy policy = new Policy();
            this.Close();
            policy.Show();
        }

        private void Ts_and_Cs_Click(object sender, RoutedEventArgs e)
        {
            Terms terms = new Terms();
            this.Close();
            terms.Show();
        }
        private void access_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            this.Close();
            account.Show();

        }

        private void Lion_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Lion 🦁 questions and answers\r\nImpress your friends with everything you know about lions!\r\n\r\n⭐ Where do lions live? African lions are mostly found in sub-Saharan Africa. They used to be found all over Africa but now they have mostly disappeared from North Africa and are at risk of extinction in West Africa. Lions live in savannahs and grasslands, where some cover and plenty of water can be found\r\n\r\n🦁What is a group of lions called? The name for a group of lions is a ‘pride’.\r\n\r\n🦁What noise do lions make? Both male and female lions roar. They usually start off with a few long, deep roars followed by shorter, faster ones. Lions also make other noises. They meow, hiss and snarl, like domestic cats, but louder.\r\n\r\n🦁Do all lions look the same? Male lions are much bigger than females and they have large manes, or hair, which covers their head and neck and stretches underneath to their belly. Lion cubs have light spots on their fur when they are born. These fade when they grow up and they help camouflage, or hide, them when they’re young.\r\n\r\n🦁How many big cats are there? There are five types of big cat – tiger, lion, jaguar, leopard and snow leopard.\r\n\r\n🦁How many types of lion are there? The main two types of lion are the African and the Asian but there are thought to be eight in total. Here’s a list:\r\n\r\nBarbary lion\r\nAsiatic lion\r\nWest African lion\r\nMasai lion\r\nCongo lion\r\nSouthwest African lion\r\nTransvaal lion\r\nEthiopian lion\r\n🦁How long do lions sleep for? Lions are the laziest of all the big cats, and can sleep for 16-20 hours each day.\r\n\r\n🦁How many babies does a lion have? A lioness usually gives birth to between one and four lion babies. Our lioness Luna, had four female cubs with our male Hugo when they lived at Longleat Safari Park.");
        }

        private void Tiger_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("       TIGERS ARE THE LARGEST AMONG OTHER WILD CATS\r\nRoyal Bengal Tigers are the largest big cat amongst other wild cats, with male tigers weighing up to 300 kilograms! You definitely wouldn’t want one of these heavy kitties to pounce on you!\r\n \r\n\r\n       TIGERS ARE CHATTY CATS!\r\nWhen you think of tiger sounds, you might think about their mighty roars (which can be heard as far as three kilometres away!), but tigers actually vocalise in a number of different ways. Tigers can grunt, groan, growl, snarl, chuff, hiss, and gasp. Next on the noise list, ‘Is there any more tea please?'\r\n \r\n\r\n       TIGERS PREFER TO HUNT AT NIGHT\r\nTigers mostly hunt at night because they are nocturnal animals. This means they sleep during the day, and are out and about at night - unlike our Tiger who does all his cupboard raiding at lunchtime!  Tigers also usually hunt at night to avoid humans and other animals - like all sensible creatures, they want to avoid being disturbed as much as possible!\r\n \r\n\r\n       TIGER CUBS ARE BORN BLIND\r\nDid you know that tiger cubs are born blind? That’s right. These tiny, soft little bundles of fur have to focus on their other senses, like scent, in order to find out where their other siblings and mother are in a den. They then open their eyes 1 - 2 weeks after birth.\r\n \r\n\r\n       TIGERS ARE GOOD SWIMMERS\r\nUnlike other cats, Tigers are excellent swimmers and love nothing more than a dip in the water. They also spend hours playing in rivers, which is an excellent way to have fun and cool off! Our Tiger would prefer a big old milkshake.\r\n \r\n\r\n       TIGERS ARE FAST!\r\nAlthough not as fast as their speedy big cat cousins, the cheetah, tigers use their powerful legs to sprint across short distances. When they really get going a tiger can run up to approx. 60 kilometres per hour. Our Tiger prefers to get his exercise in with Tigerrobics…\r\n \r\n\r\n       NO TWO TIGERS HAVE THE SAME STRIPES\r\nJust like human fingerprints, no two tigers have the same stripes. This means that every single tiger is unique, just like us!\r\n \r\n\r\n       TIGERS HAVE KING WRITTEN ON THEM\r\nIt might sound strange, but even though all tigers have unique stripes, because of their patterning most tigers actually have the Chinese symbol for ‘King’ on their foreheads. Kingly coincidence or meant to be? Our Tiger is certainly treated like royalty! More tea sir? Coming right up!\r\n \r\n\r\n       TIGERS HAVE GOOD MANNERS\r\nTigers have surprisingly good manners and will often share their catch from a hunt with another tiger. (Looking at you Tiger, perhaps you should share those buns hmm?) In the wild, the males tend to let females and cubs eat first before they tuck in.");
        }

        private void jaguar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Jaguars have powerful jaws\r\nNext cool jaguar fact? Jaguars have the strongest bite of any big cat, and are able to crush the shells of turtles and the skulls of caimans. \r\n\r\nJaguars are excellent swimmers\r\nDespite their size, jaguars are excellent swimmers. They are often seen swimming in rivers and lakes, and have even been known to climb trees in search of food.\r\n\r\nJaguars have black spots\r\nPossibly the most beautiful point in our list of cool jaguar facts is the fact that jaguars are famous for their distinctive black spots, which are called rosettes because they are shaped like roses. Each jaguar’s pattern of rosettes is unique, like a fingerprint.\r\n\r\nJaguars are solitary animals\r\nUnlike lions and other big cats, jaguars are solitary animals. They have large territories, and only come together to mate.\r\n\r\nJaguars have been revered by Indigenous cultures\r\nJaguars have been revered by many Indigenous cultures for centuries. In some cultures, jaguars are considered sacred animals, and are associated with strength, power, and spirituality. For example, in the Mayan culture, the jaguar was seen as a symbol of royalty, and was associated with the god of the underworld. In the Inca culture, the jaguar was seen as a symbol of the sun, and was associated with the god of war.\r\n\r\nJaguars are surprisingly good climbers\r\nWhile they are typically associated with the ground, jaguars are actually excellent climbers, and have been known to climb trees in search of food or shelter. This is a unique ability among big cats, as most other species are not able to climb trees. This ability allows jaguars to access a wider range of habitats and prey, and helps to make them successful hunters.");
        }

        private void elaphent_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Three Species of Elephant\r\n\r\nWe often hear about African and Asian elephants, but did you know that there are actually three species? There are African Forest elephants, African Savannah elephants, and Asian elephants. All three species are genetically different, with African Savannah elephants being the largest and African Forest and Asian elephants being smaller and more similar in size. African Forest elephants have straighter tusks and rounder ears than Savannah elephants and live in the African Congo Basin’s tropical forests. They’re Incredibly Smart & Can Recognize Themselves\r\n\r\nOne of the best-known facts about elephants is that they’re smart, with a brain that weighs 4-6kg (9-13lbs.) Much of elephant behaviour is actually learned, rather than instinctive. They can even look in a mirror and recognize themselves - something only humans, dolphins, and apes can also do. This shows a self-awareness that few animals possess.\r\n\r\n Elephants Use Vibrations to Speak\r\n\r\nElephants can communicate by trumpet calls, touch, body language, and scent. However, they also send long-distance messages through low-pitched sounds that humans can barely hear. These sounds create infrasonic rumbles in the air and seismic vibrations in the ground, which other elephants feel through their bones and feet. These messages can travel up to 2 miles away. Elephants Have Personalities\r\n\r\nElephants have different characteristics that create their personality. Researchers have identified four personality dimensions which are made up of 26 different personality types. The dimensions include playfulness, gentleness, leadership, and constancy.\r\n\r\n Not All Elephants Have Visible Tusks\r\n\r\nElephant tusks are really just enlarged incisor teeth. These appear around 2 years of age and will continue to grow throughout their lifetime. Both male and female African elephants grow tusks that are visible. Meanwhile, only some male Asian elephants have large, distinguished tusks. Most Asian elephants, male or female, will have small tusks which are called tushes - these only grow about an inch beyond the lip line. Elephants Are Left- Or Right-Tusked\r\n\r\nLike humans are left or right-handed, elephants can favour their left or right tusk. You can usually spot which one they favour, as one tusk will be smaller, with more wear and tear. Their tusks are incredibly important, as they use them to gather food, move and lift objects, strip tree bark, dig holes during droughts, and defend themselves.\r\n\r\n Elephants Show Signs of Grief\r\n\r\nElephant families show signs of grief for lost loved ones. They sometimes visit the bones of a deceased family member for years afterwards and have been seen touching the bones with their trunks. Some elephants have also been known to linger around the body of a fallen loved one for up to a week.");
        }

        private void rhino_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Rhino questions and answers\r\nWhat do rhinos eat?  \r\nRhinos are herbivores (plant eaters). They eat leafy plants, branches, shoots, bushes and fruit.\r\n\r\nHow fast can rhinos charge?\r\nRhinos can reach speeds of up to 55kph. Black rhino can be very aggressive and will charge at anything that scares them.\r\n\r\nHow much do rhinos weigh?\r\nAn adult black rhino weighs between 800 and 1400 kilograms.\r\n\r\nWhat is a group of rhinos called?\r\nA group of rhinos is called a ‘crash’.\r\n\r\nDo all rhinos have two horns?\r\nNot all rhinos have two horns. The black, white and Sumatran rhino has two horns. The Javan and Indian have just one horn.\r\n\r\nHow long is a rhino’s horn?\r\nThe front horn is the largest at about 50cm long, but some have reached up to 140cm.What noise do rhinos make?\r\nRhinos make grunting and sniffing noises. Baby rhinos make squealing and screeching sounds.\r\n\r\nHow many types of rhino are there?\r\nThere are five types of rhino. They are listed below in order of size, starting with the biggest:\r\n\r\nIndian rhino (also known as the greater one-horned rhino)\r\nWhite rhino\r\nBlack rhino\r\nJavan rhino\r\nSumatran rhino\r\nThree of these are critically endangered – the black rhino, the Sumatran and the Javan.\r\n\r\nWhere do rhinos live?\r\nBlack rhinos live in grassland, scrubland and bushes.\r\n\r\nHow long is a rhino pregnant for?\r\nThe gestation period, or pregnancy, of a rhino is 15 to 16 months.\r\n\r\nHow many babies does a rhino have?  \r\nA rhino has one baby, or calf.");
        }

        private void wildDogs_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("DID YOU KNOW?\r\nFour out of five\r\nAn incredible 80% of African wild dog hunts end successfully.\r\n\r\nHow fast can African wild dogs run?\r\nThese pack predators have a top speed of around 45mph (as fast as a greyhound), but a wild dog hunt is a marathon, not a sprint. They are endurance athletes, with long legs and large lungs that enable them to keep going until they have run their exhausted quarry to a complete standstill.\r\n\r\nAfrican wild dog family life\r\nWild dog cooperation extends to their social structure; they have complex hierarchies in which only the alpha male and female – literally, the top dogs – breed. Wild dogs give birth underground, often in abandoned aardvark burrows. Pups are born blind, usually between March and June. The pack regurgitates food for the young, but this action is also extended to adults, to the point of being the bedrock of African wild dogs’ social life.\r\n\r\nPainted dogs hold a ‘meet and greet’ ceremony every morning or after a siesta. This is believed to reinforce social bonds and prepare the pack for the hunt. On the whole, they are surprisingly non-aggressive; for example, they do not fight over food but instead beg to indicate their wish to eat. Adults will allow younger pack members to eat before them.What do African wild dogs eat? \r\nWild dogs will hunt anything from a warthog to a wildebeest, but their preferred prey are medium-sized antelopes such as impala that are no more than twice their own weight. Individual dogs will also opportunistically catch and eat smaller animals such as rats, hares and birds. \r\n\r\nWhere do African wild dogs live? \r\nAfrican wild dogs need vast home ranges covering hundreds of square miles, far bigger than those of any other African predator. They inhabit open plains and sparse woodlands in sub-Saharan Africa. Painted dogs used to be found in nearly 40 countries. They have disappeared from large parts of their original range, including most of West Africa, and their populations have been decimated. Most of their remaining strongholds are in Tanzania, Botswana, Zambia, Zimbabwe, Kenya, South Africa, Namibia, Mozambique and South Sudan. \r\n\r\nHow many wild dogs are left? \r\nToday, fewer than 7,000 African wild dogs survive in the wild, and only 1,500 of these are adults. It is thought that just 700 packs of wild dogs remain, scattered across the entire continent. African wild dogs are officially classified as Endangered on the IUCN Red List.");
        }
    }
}
