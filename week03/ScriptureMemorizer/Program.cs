// Creativity and exceeding requirements: I added a list of scriptures from the doctrinal mastery that the program selects from each time the program runs. A new scripture is selected randomly each run.
using System;
class Program
{
    static void Main(string[] args)
    {
        const int bookNameIndex = 0;
        const int chapterNumberIndex = 1;
        const int startVerseIndex = 2;
        const int endVerseIndex = 3;
        const int verseIndex = 4;

        List<List<object>> scriptures = new List<List<object>>
        {
            new List<object> { "Moses", 1, 39, 0, "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man." },
            new List<object> { "Moses", 7, 18, 0, "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them." },
            new List<object> { "Abraham", 3, 22, 23, "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born." },
            new List<object> { "Genesis", 1, 26, 27, "And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth. So God created man in his own image, in the image of God created he him; male and female created he them." },
            new List<object> { "Genesis", 2, 24, 0, "Therefore shall a man leave his father and his mother, and shall cleave unto his wife: and they shall be one flesh." },
            new List<object> { "Genesis", 39, 9, 0, "There is none greater in this house than I; neither hath he kept back any thing from me but thee, because thou art his wife: how then can I do this great wickedness, and sin against God?" },
            new List<object> { "Exodus", 19, 5, 6, "Now therefore, if ye will obey my voice indeed, and keep my covenant, then ye shall be a peculiar treasure unto me above all people: for all the earth is mine: And ye shall be unto me a kingdom of priests, and an holy nation. These are the words which thou shalt speak unto the children of Israel." },
            new List<object> { "Joshua", 24, 15, 0, "And if it seem evil unto you to serve the Lord, choose you this day whom ye will serve; whether the gods which your fathers served that were on the other side of the flood, or the gods of the Amorites, in whose land ye dwell: but as for me and my house, we will serve the Lord." },
            new List<object> { "Psalm", 24, 3, 4, "Who shall ascend into the hill of the Lord? or who shall stand in his holy place? He that hath clean hands, and a pure heart; who hath not lifted up his soul unto vanity, nor sworn deceitfully." },
            new List<object> { "Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths." },
            new List<object> { "Isaiah", 1, 18, 0, "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool." },
            new List<object> { "Isaiah", 5, 20, 0, "Woe unto them that call evil good, and good evil; that put darkness for light, and light for darkness; that put bitter for sweet, and sweet for bitter!" },
            new List<object> { "Isaiah", 29, 13, 14, "Wherefore the Lord said, Forasmuch as this people draw near me with their mouth, and with their lips do honour me, but have removed their heart far from me, and their fear toward me is taught by the precept of men: Therefore, behold, I will proceed to do a marvellous work among this people, even a marvellous work and a wonder: for the wisdom of their wise men shall perish, and the understanding of their prudent men shall be hid." },
            new List<object> { "Isaiah", 53, 3, 5, "He is despised and rejected of men; a man of sorrows, and acquainted with grief: and we hid as it were our faces from him; he was despised, and we esteemed him not. Surely he hath borne our griefs, and carried our sorrows: yet we did esteem him stricken, smitten of God, and afflicted. But he was wounded for our transgressions, he was bruised for our iniquities: the chastisement of our peace was upon him; and with his stripes we are healed." },
            new List<object> { "Isaiah", 58, 6, 7, "Is not this the fast that I have chosen? to loose the bands of wickedness, to undo the heavy burdens, and to let the oppressed go free, and that ye break every yoke? Is it not to deal thy bread to the hungry, and that thou bring the poor that are cast out to thy house? when thou seest the naked, that thou cover him; and that thou hide not thyself from thine own flesh?" },
            new List<object> { "Jeremiah", 1, 4, 5, "Then the word of the Lord came unto me, saying, Before I formed thee in the belly I knew thee; and before thou camest forth out of the womb I sanctified thee, and I ordained thee a prophet unto the nations." },
            new List<object> { "Ezekiel", 3, 16, 17, "And it came to pass at the end of seven days, that the word of the Lord came unto me, saying, Son of man, I have made thee a watchman unto the house of Israel: therefore hear the word at my mouth, and give them warning from me." },
            new List<object> { "Ezekiel", 37, 15, 17, "The word of the Lord came again unto me, saying, Moreover, thou son of man, take thee one stick, and write upon it, For Judah, and for the children of Israel his companions: then take another stick, and write upon it, For Joseph, the stick of Ephraim, and for all the house of Israel his companions: And join them one to another into one stick; and they shall become one in thine hand." },
            new List<object> { "Daniel", 2, 44, 0, "And in the days of these kings shall the God of heaven set up a kingdom, which shall never be destroyed: and the kingdom shall not be left to other people, but it shall break in pieces and consume all these kingdoms, and it shall stand for ever." },
            new List<object> { "Amos", 3, 7, 0, "Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets." },
            new List<object> { "Malachi", 3, 8, 10, "Will a man rob God? Yet ye have robbed me. But ye say, Wherein have we robbed thee? In tithes and offerings. Ye are cursed with a curse: for ye have robbed me, even this whole nation. Bring ye all the tithes into the storehouse, that there may be meat in mine house, and prove me now herewith, saith the Lord of hosts, if I will not open you the windows of heaven, and pour you out a blessing, that there shall not be room enough to receive it." },
            new List<object> { "Matthew", 5, 14, 16, "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven." },
            new List<object> { "Matthew", 11, 28, 30, "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light." },
            new List<object> { "Matthew", 22, 36, 39, "Master, which is the great commandment in the law? Jesus said unto him, Thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind. This is the first and great commandment. And the second is like unto it, Thou shalt love thy neighbour as thyself." },
            new List<object> { "Luke", 2, 10, 12, "And the angel said unto them, Fear not: for, behold, I bring you good tidings of great joy, which shall be to all people. For unto you is born this day in the city of David a Saviour, which is Christ the Lord. And this shall be a sign unto you; Ye shall find the babe wrapped in swaddling clothes, lying in a manger." },
            new List<object> { "Luke", 22, 19, 20, "And he took bread, and gave thanks, and brake it, and gave unto them, saying, This is my body which is given for you: this do in remembrance of me. Likewise also the cup after supper, saying, This cup is the new testament in my blood, which is shed for you." },
            new List<object> { "Luke", 24, 36, 39, "And as they thus spake, Jesus himself stood in the midst of them, and saith unto them, Peace be unto you. But they were terrified and affrighted, and supposed that they had seen a spirit. And he said unto them, Why are ye troubled? and why do thoughts arise in your hearts? Behold my hands and my feet, that it is I myself: handle me, and see; for a spirit hath not flesh and bones, as ye see me have." },
            new List<object> { "John", 3, 5, 0, "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God." },
            new List<object> { "John", 3, 16, 0, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life." },
            new List<object> { "John", 7, 17, 0, "If any man will do his will, he shall know of the doctrine, whether it be of God, or whether I speak of myself." },
            new List<object> { "John", 17, 3, 0, "And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent." },
            new List<object> { "Acts", 3, 19, 21, "Repent ye therefore, and be converted, that your sins may be blotted out, when the times of refreshing shall come from the presence of the Lord; And he shall send Jesus Christ, which before was preached unto you: Whom the heaven must receive until the times of restitution of all things, which God hath spoken by the mouth of all his holy prophets since the world began." },
            new List<object> { "1 Corinthians", 6, 19, 20, "What? know ye not that your body is the temple of the Holy Ghost which is in you, which ye have of God, and ye are not your own? For ye are bought with a price: therefore glorify God in your body, and in your spirit, which are God's." },
            new List<object> { "1 Corinthians", 11, 11, 0, "Nevertheless neither is the man without the woman, neither the woman without the man, in the Lord." },
            new List<object> { "1 Corinthians", 15, 20, 22, "But now is Christ risen from the dead, and become the firstfruits of them that slept. For since by man came death, by man came also the resurrection of the dead. For as in Adam all die, even so in Christ shall all be made alive." },
            new List<object> { "1 Corinthians", 15, 40, 42, "There are also celestial bodies, and bodies terrestrial: but the glory of the celestial is one, and the glory of the terrestrial is another. There is one glory of the sun, and another glory of the moon, and another glory of the stars: for one star differeth from another star in glory. So also is the resurrection of the dead. It is sown in corruption; it is raised in incorruption:" },
            new List<object> { "Ephesians", 1, 10, 0, "That in the dispensation of the fulness of times he might gather together in one all things in Christ, both which are in heaven, and which are on earth; even in him:" },
            new List<object> { "Ephesians", 2, 19, 20, "Now therefore ye are no more strangers and foreigners, but fellowcitizens with the saints, and of the household of God; And are built upon the foundation of the apostles and prophets, Jesus Christ himself being the chief corner stone;" },
            new List<object> { "2 Thessalonians", 2, 1, 3, "Now we beseech you, brethren, by the coming of our Lord Jesus Christ, and by our gathering together unto him, That ye be not soon shaken in mind, or be troubled, neither by spirit, nor by word, nor by letter as from us, as that the day of Christ is at hand. Let no man deceive you by any means: for that day shall not come, except there come a falling away first, and that man of sin be revealed, the son of perdition;" },
            new List<object> { "2 Timothy", 3, 15, 17, "And that from a child thou hast known the holy scriptures, which are able to make thee wise unto salvation through faith which is in Christ Jesus. All scripture is given by inspiration of God, and is profitable for doctrine, for reproof, for correction, for instruction in righteousness: That the man of God may be perfect, throughly furnished unto all good works." },
            new List<object> { "Hebrews", 12, 9, 0, "Furthermore we have had fathers of our flesh which corrected us, and we gave them reverence: shall we not much rather be in subjection unto the Father of spirits, and live?" },
            new List<object> { "James", 1, 5, 6, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed." },
            new List<object> { "James", 2, 17, 18, "Even so faith, if it hath not works, is dead, being alone. Yea, a man may say, Thou hast faith, and I have works: shew me thy faith without thy works, and I will shew thee my faith by my works." },
            new List<object> { "1 Peter", 4, 6, 0, "For for this cause was the gospel preached also to them that are dead, that they might be judged according to men in the flesh, but live according to God in the spirit." },
            new List<object> { "Revelation", 20, 12, 0, "And I saw the dead, small and great, stand before God; and the books were opened: and another book was opened, which is the book of life: and the dead were judged out of those things which were written in the books, according to their works." },
            new List<object> { "1 Nephi", 3, 7, 0, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them." },
            new List<object> { "2 Nephi", 2, 25, 0, "Adam fell that men might be; and men are, that they might have joy." },
            new List<object> { "2 Nephi", 2, 27, 0, "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself." },
            new List<object> { "2 Nephi", 26, 33, 0, "For none of these iniquities come of the Lord; for he doeth that which is good among the children of men; and he doeth nothing save it be plain unto the children of men; and he inviteth them all to come unto him and partake of his goodness; and he denieth none that come unto him, black and white, bond and free, male and female; and he remembereth the heathen; and all are alike unto God, both Jew and Gentile." },
            new List<object> { "2 Nephi", 28, 30, 0, "For behold, thus saith the Lord God: I will give unto the children of men line upon line, precept upon precept, here a little and there a little; and blessed are those who hearken unto my precepts, and lend an ear unto my counsel, for they shall learn wisdom; for unto him that receiveth I will give more; and from them that shall say, We have enough, from them shall be taken away even that which they have." },
            new List<object> { "2 Nephi", 32, 3, 0, "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do." },
            new List<object> { "Mosiah", 2, 17, 0, "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God." },
            new List<object> { "Mosiah", 2, 41, 0, "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it." },
            new List<object> { "Mosiah", 3, 19, 0, "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father." },
            new List<object> { "Mosiah", 4, 9, 0, "Believe in God; believe that he is, and that he created all things, both in heaven and in earth; believe that he has all wisdom, and all power, both in heaven and in earth; believe that man doth not comprehend all the things which the Lord can comprehend." },
            new List<object> { "Alma", 39, 9, 0, "Now my son, I would that ye should repent and forsake your sins, and go no more after the lusts of your eyes, but cross yourself in all these things; for except ye do this ye can in nowise inherit the kingdom of God. Oh, remember, and take it upon you, and cross yourself in these things." },
            new List<object> { "Alma", 41, 10, 0, "Do not suppose, because it has been spoken concerning restoration, that ye shall be restored from sin to happiness. Behold, I say unto you, wickedness never was happiness." },
            new List<object> { "3 Nephi", 11, 10, 11, "Behold, I am Jesus Christ, whom the prophets testified shall come into the world. And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning." },
            new List<object> { "3 Nephi", 12, 48, 0, "Therefore I would that ye should be perfect even as I, or your Father who is in heaven is perfect." },
            new List<object> { "3 Nephi", 18, 15, 21, "Verily, verily, I say unto you, ye must watch and pray always, lest ye be tempted by the devil, and ye be led away captive by him. And whatsoever ye shall ask the Father in my name, which is right, believing that ye shall receive, behold it shall be given unto you. Pray in your families unto the Father, always in my name, that your wives and your children may be blessed." },
            new List<object> { "3 Nephi", 27, 20, 0, "Now this is the commandment: Repent, all ye ends of the earth, and come unto me and be baptized in my name, that ye may be sanctified by the reception of the Holy Ghost, that ye may stand spotless before me at the last day." },
            new List<object> { "Ether", 12, 6, 0, "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith." },
            new List<object> { "Ether", 12, 27, 0, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them." },
            new List<object> { "Moroni", 10, 4, 5, "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things." },
            new List<object> { "Doctrine and Covenants", 1, 30, 0, "And also those to whom these commandments were given, might have power to lay the foundation of this church, and to bring it forth out of obscurity and out of darkness, the only true and living church upon the face of the whole earth, with which I, the Lord, am well pleased, speaking unto the church collectively and not individually—" },
            new List<object> { "Doctrine and Covenants", 1, 37, 38, "Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled. What I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same." },
            new List<object> { "Doctrine and Covenants", 6, 36, 0, "Look unto me in every thought; doubt not, fear not." },
            new List<object> { "Doctrine and Covenants", 8, 2, 3, "Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart. Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground." },
            new List<object> { "Doctrine and Covenants", 13, 1, 0, "Upon you my fellow servants, in the name of Messiah I confer the Priesthood of Aaron, which holds the keys of the ministering of angels, and of the gospel of repentance, and of baptism by immersion for the remission of sins; and this shall never be taken again from the earth, until the sons of Levi do offer again an offering unto the Lord in righteousness." },
            new List<object> { "Doctrine and Covenants", 18, 10, 11, "Remember the worth of souls is great in the sight of God; For, behold, the Lord your Redeemer suffered death in the flesh; wherefore he suffered the pain of all men, that all men might repent and come unto him." },
            new List<object> { "Doctrine and Covenants", 18, 15, 16, "And if it so be that you should labor all your days in crying repentance unto this people, and bring, save it be one soul unto me, how great shall be your joy with him in the kingdom of my Father! And now, if your joy will be great with one soul that you have brought unto me into the kingdom of my Father, how great will be your joy if you should bring many souls unto me!" },
            new List<object> { "Doctrine and Covenants", 49, 15, 17, "And again, verily I say unto you, that whoso forbiddeth to marry is not ordained of God, for marriage is ordained of God unto man. Wherefore, it is lawful that he should have one wife, and they twain shall be one flesh, and all this that the earth might answer the end of its creation; And that it might be filled with the measure of man, according to his creation before the world was made." },
            new List<object> { "Doctrine and Covenants", 58, 42, 43, "Behold, he who has repented of his sins, the same is forgiven, and I, the Lord, remember them no more. By this ye may know if a man repenteth of his sins—behold, he will confess them and forsake them." },
            new List<object> { "Doctrine and Covenants", 64, 9, 11, "Wherefore, I say unto you, that ye ought to forgive one another; for he that forgiveth not his brother his trespasses standeth condemned before the Lord; for there remaineth in him the greater sin. I, the Lord, will forgive whom I will forgive, but of you it is required to forgive all men. And ye ought to say in your hearts—let God judge between me and thee, and reward thee according to thy deeds." },
            new List<object> { "Doctrine and Covenants", 76, 22, 24, "And now, after the many testimonies which have been given of him, this is the testimony, last of all, which we give of him: That he lives! For we saw him, even on the right hand of God; and we heard the voice bearing record that he is the Only Begotten of the Father—That by him, and through him, and of him, the worlds are and were created, and the inhabitants thereof are begotten sons and daughters unto God." },
            new List<object> { "Doctrine and Covenants", 82, 10, 0, "I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise." },
            new List<object> { "Doctrine and Covenants", 84, 20, 22, "Therefore, in the ordinances thereof, the power of godliness is manifest. And without the ordinances thereof, and the authority of the priesthood, the power of godliness is not manifest unto men in the flesh; For without this no man can see the face of God, even the Father, and live." },
            new List<object> { "Doctrine and Covenants", 88, 118, 0, "And as all have not faith, seek ye diligently and teach one another words of wisdom; yea, seek ye out of the best books words of wisdom; seek learning, even by study and also by faith." },
            new List<object> { "Doctrine and Covenants", 107, 8, 0, "The Melchizedek Priesthood holds the right of presidency, and has power and authority over all the offices in the church in all ages of the world, to administer in spiritual things." },
            new List<object> { "Doctrine and Covenants", 130, 22, 23, "The Father has a body of flesh and bones as tangible as man's; the Son also; but the Holy Ghost has not a body of flesh and bones, but is a personage of Spirit. Were it not so, the Holy Ghost could not dwell in us." },
            new List<object> { "Doctrine and Covenants", 131, 1, 4, "In the celestial glory there are three heavens or degrees; And in order to obtain the highest, a man must enter into this order of the priesthood [meaning the new and everlasting covenant of marriage]; And if he does not, he cannot obtain it. He may enter into the other, but that is the end of his kingdom; he cannot have an increase." },
        };
        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        List<object> scriptureList = scriptures[randomIndex];
        

        int enterCount = 0;
        int wordsToBeBlanked = 0;
        Reference scripReference = new Reference((string)scriptureList[bookNameIndex], (int)scriptureList[chapterNumberIndex], (int)scriptureList[startVerseIndex], (int)scriptureList[endVerseIndex]);
        Scripture scripture = new Scripture((string)scriptureList[verseIndex], scripReference);
        
        while (enterCount <= 5)
        {
            Console.Clear();
            wordsToBeBlanked = GetWordsToBeBlanked();
            scripture.MakeStringWithBlanks(wordsToBeBlanked);
            scripture.Display();

            if (enterCount == 5)
            {
                Console.WriteLine();
                Console.WriteLine("Great job! See you soon!");
                break;
            }
            Console.WriteLine();
            Console.Write("Press Enter to Continue or Type QUIT to quit: ");
            string quitQuery = Console.ReadLine();
            if (quitQuery.Trim().ToLower() == "quit")
            {
                Console.WriteLine();
                Console.WriteLine("Have a great day!");
                break;
            }
            
            enterCount++;
        }

        int GetWordsToBeBlanked()
        {
            if (enterCount == 0)
            {
                wordsToBeBlanked = 0;
            }
            else if (enterCount <= 3)
            {
                wordsToBeBlanked = scripture.GetWordCount() / 4;
            }
            else if (enterCount == 4)
            {
                wordsToBeBlanked = scripture.GetWordCount() - 3 * (scripture.GetWordCount() / 4);
            }
            else if (enterCount == 5)
            {
                wordsToBeBlanked = 0;
            }
            return wordsToBeBlanked;
        }
}
}