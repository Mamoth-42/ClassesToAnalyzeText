﻿using ClassesToAnalyzeText;
var textCh = new TextChars();
string input = """
        1/1993 Sb.
    ÚSTAVA
    ČESKÉ REPUBLIKY
    ze dne 16. prosince 1992
    Změna: 347/1997 Sb.
    Změna: 300/2000 Sb.
    Změna: 448/2001 Sb.
    Změna: 395/2001 Sb.
    Změna: 515/2002 Sb.
    Změna: 319/2009 Sb.
    Změna: 71/2012 Sb.
    Změna: 71/2012 Sb. (část)
    Změna: 98/2013 Sb.
    Česká národní rada se usnesla na tomto ústavním zákoně:
    PREAMBULE
    My, občané České republiky v Čechách, na Moravě a ve Slezsku,
    v čase obnovy samostatného českého státu,
    věrni všem dobrým tradicím dávné státnosti zemí Koruny české i státnosti československé,
    odhodláni budovat, chránit a rozvíjet Českou republiku v duchu nedotknutelných hodnot lidské důstojnosti a svobody
    jako vlast rovnoprávných, svobodných občanů, kteří jsou si vědomi svých povinností vůči druhým a zodpovědnosti vůči celku,
    jako svobodný a demokratický stát, založený na úctě k lidským právům a na zásadách občanské společnosti,
    jako součást rodiny evropských a světových demokracií,
    odhodláni společně střežit a rozvíjet zděděné přírodní a kulturní, hmotné a duchovní bohatství,
    odhodláni řídit se všemi osvědčenými principy právního státu,
    prostřednictvím svých svobodně zvolených zástupců přijímáme tuto Ústavu České republiky
    HLAVA PRVNÍ
    Základní ustanovení
    Čl.1
    (1) Česká republika je svrchovaný, jednotný a demokratický právní stát založený na úctě k právům a svobodám
    člověka a občana.
    (2) Česká republika dodržuje závazky, které pro ni vyplývají z mezinárodního práva.
    Čl.2
    (1) Lid je zdrojem veškeré státní moci; vykonává ji prostřednictvím orgánů moci zákonodárné, výkonné a soudní.
    (2) Ústavní zákon může stanovit, kdy lid vykonává státní moc přímo.
    (3) Státní moc slouží všem občanům a lze ji uplatňovat jen v případech, v mezích a způsoby, které stanoví zákon.
    (4) Každý občan může činit, co není zákonem zakázáno, a nikdo nesmí být nucen činit, co zákon neukládá.
    Čl.3
    Součástí ústavního pořádku České republiky je Listina základních práv a svobod.
    Čl.4
    Základní práva a svobody jsou pod ochranou soudní moci.
    Čl.5
    Politický systém je založen na svobodném a dobrovolném vzniku a volné soutěži politických stran respektujících
    základní demokratické principy a odmítajících násilí jako prostředek k prosazování svých zájmů.
    Čl.6
    Politická rozhodnutí vycházejí z vůle většiny vyjádřené svobodným hlasováním. Rozhodování většiny dbá ochrany
    menšin.
    Čl.7
    Stát dbá o šetrné využívání přírodních zdrojů a ochranu přírodního bohatství.
    Čl.8
    Zaručuje se samospráva územních samosprávných celků.
    Čl.9
    (1) Ústava může být doplňována či měněna pouze ústavními zákony.
    (2) Změna podstatných náležitostí demokratického právního státu je nepřípustná.
    (3) Výkladem právních norem nelze oprávnit odstranění nebo ohrožení základů demokratického státu.
    Čl.10
    Vyhlášené mezinárodní smlouvy, k jejichž ratifikaci dal Parlament souhlas a jimiž je Česká republika vázána, jsou
    součástí právního řádu; stanoví-li mezinárodní smlouva něco jiného než zákon, použije se mezinárodní smlouva.
    Čl.10a
    (1) Mezinárodní smlouvou mohou být některé pravomoci orgánů České republiky přeneseny na mezinárodní
    organizaci nebo instituci.
    (2) K ratifikaci mezinárodní smlouvy uvedené v odstavci 1 je třeba souhlasu Parlamentu, nestanoví-li ústavní zákon,
    že k ratifikaci je třeba souhlasu daného v referendu.
    Čl.10b
    (1) Vláda pravidelně a předem informuje Parlament o otázkách souvisejících se závazky vyplývajícími z členství
    České republiky v mezinárodní organizaci nebo instituci uvedené v čl. 10a.
    (2) Komory Parlamentu se vyjadřují k připravovaným rozhodnutím takové mezinárodní organizace nebo instituce
    způsobem, který stanoví jejich jednací řády.
    (3) Zákon o zásadách jednání a styku obou komor mezi sebou, jakož i navenek, může svěřit výkon působnosti komor
    podle odstavce 2 společnému orgánu komor.
    Čl.11
    Území České republiky tvoří nedílný celek, jehož státní hranice mohou být měněny jen ústavním zákonem.
    Čl.12
    (1) Nabývání a pozbývání státního občanství České republiky stanoví zákon.
    (2) Nikdo nemůže být proti své vůli zbaven státního občanství.
    Čl.13
    Hlavním městem České republiky je Praha.
    Čl.14
    (1) Státními symboly České republiky jsou velký a malý státní znak, státní barvy, státní vlajka, vlajka prezidenta
    republiky, státní pečeť a státní hymna.
    (2) Státní symboly a jejich používání upraví zákon.
    HLAVA DRUHÁ
    Moc zákonodárná
    Čl.15
    (1) Zákonodárná moc v České republice náleží Parlamentu.
    (2) Parlament je tvořen dvěma komorami, a to Poslaneckou sněmovnou a Senátem.
    Čl.16
    (1) Poslanecká sněmovna má 200 poslanců, kteří jsou voleni na dobu čtyř let.
    (2) Senát má 81 senátorů, kteří jsou voleni na dobu šesti let. Každé dva roky se volí třetina senátorů.
    Čl.17
    (1) Volby do obou komor se konají ve lhůtě počínající třicátým dnem před uplynutím volebního období a končící dnem
    jeho uplynutí.
    (2) Byla-li Poslanecká sněmovna rozpuštěna, konají se volby do šedesáti dnů po jejím rozpuštění.
    Čl.18
    (1) Volby do Poslanecké sněmovny se konají tajným hlasováním na základě všeobecného, rovného a přímého
    volebního práva, podle zásad poměrného zastoupení.
    (2) Volby do Senátu se konají tajným hlasováním na základě všeobecného, rovného a přímého volebního práva,
    podle zásad většinového systému.
    (3) Právo volit má každý občan České republiky, který dosáhl věku 18 let.
    Čl.19
    (1) Do Poslanecké sněmovny může být zvolen každý občan České republiky, který má právo volit a dosáhl věku 21
    let.
    (2) Do Senátu může být zvolen každý občan České republiky, který má právo volit a dosáhl věku 40 let.
    (3) Mandát poslance nebo senátora vzniká zvolením.
    Čl.20
    Další podmínky výkonu volebního práva, organizaci voleb a rozsah soudního přezkumu stanoví zákon.
    Čl.21
    Nikdo nemůže být současně členem obou komor Parlamentu.
    Čl.22
    (1) S funkcí poslance nebo senátora je neslučitelný výkon úřadu prezidenta republiky, funkce soudce a další funkce,
    které stanoví zákon.
    (2) Dnem, kdy se poslanec nebo senátor ujal úřadu prezidenta republiky, nebo dnem, kdy se ujal funkce soudce nebo
    jiné funkce neslučitelné s funkcí poslance nebo senátora, zaniká jeho mandát poslance nebo senátora.
    Čl.23
    (1) Poslanec složí slib na první schůzi Poslanecké sněmovny, které se zúčastní.
    (2) Senátor složí slib na první schůzi Senátu, které se zúčastní.
    (3) Slib poslance a senátora zní: "Slibuji věrnost České republice. Slibuji, že budu zachovávat její Ústavu a zákony.
    Slibuji na svou čest, že svůj mandát budu vykonávat v zájmu všeho lidu a podle svého nejlepšího vědomí a svědomí.".
    Čl.24
    Poslanec nebo senátor se může svého mandátu vzdát prohlášením učiněným osobně na schůzi komory, jejímž je
    členem. Brání-li mu v tom závažné okolnosti, učiní tak způsobem stanoveným zákonem.
    Čl.25
    Mandát poslance nebo senátora zaniká
    a) odepřením slibu nebo složením slibu s výhradou,
    b) uplynutím volebního období,
    c) vzdáním se mandátu,
    d) ztrátou volitelnosti,
    e) u poslanců rozpuštěním Poslanecké sněmovny,
    f) vznikem neslučitelnosti funkcí podle čl. 22.
    Čl.26
    Poslanci a senátoři vykonávají svůj mandát osobně v souladu se svým slibem a nejsou přitom vázáni žádnými
    příkazy.
    Čl.27
    (1) Poslance ani senátora nelze postihnout pro hlasování v Poslanecké sněmovně nebo Senátu nebo jejich orgánech.
    (2) Za projevy učiněné v Poslanecké sněmovně nebo Senátu nebo v jejich orgánech nelze poslance nebo senátora
    trestně stíhat. Poslanec nebo senátor podléhá jen disciplinární pravomoci komory, jejímž je členem.
    (3) Za přestupky poslanec nebo senátor podléhá jen disciplinární pravomoci komory, jejímž je členem, pokud zákon
    nestanoví jinak.
    (4) Poslance ani senátora nelze trestně stíhat bez souhlasu komory, jejímž je členem. Odepře-li komora souhlas, je
    trestní stíhání po dobu trvání mandátu vyloučeno.
    (5) Poslance nebo senátora lze zadržet, jen byl-li dopaden při spáchání trestného činu nebo bezprostředně poté.
    Příslušný orgán je povinen zadržení ihned oznámit předsedovi komory, jejímž je zadržený členem; nedá-li předseda komory do
    24 hodin od zadržení souhlas k odevzdání zadrženého soudu, je příslušný orgán povinen ho propustit. Na své první následující
    schůzi komora rozhodne o přípustnosti stíhání s konečnou platností.
    Čl.28
    Poslanec i senátor má právo odepřít svědectví o skutečnostech, které se dozvěděl v souvislosti s výkonem svého
    mandátu, a to i poté, kdy přestal být poslancem nebo senátorem.
    Čl.29
    (1) Poslanecká sněmovna volí a odvolává předsedu a místopředsedy Poslanecké sněmovny.
    (2) Senát volí a odvolává předsedu a místopředsedy Senátu.
    Čl.30
    (1) Pro vyšetření věci veřejného zájmu může Poslanecká sněmovna zřídit vyšetřovací komisi, navrhne-li to nejméně
    pětina poslanců.
    (2) Řízení před komisí upraví zákon.
    Čl.31
    (1) Komory zřizují jako své orgány výbory a komise.
    (2) Činnost výborů a komisí upraví zákon.
    Čl.32
    Poslanec nebo senátor, který je členem vlády, nemůže být předsedou či místopředsedou Poslanecké sněmovny nebo
    Senátu ani členem parlamentních výborů, vyšetřovací komise nebo komisí.
    Čl.33
    (1) Dojde-li k rozpuštění Poslanecké sněmovny, přísluší Senátu přijímat zákonná opatření ve věcech, které nesnesou
    odkladu a vyžadovaly by jinak přijetí zákona.
    (2) Senátu však nepřísluší přijímat zákonné opatření ve věcech Ústavy, státního rozpočtu, státního závěrečného účtu,
    volebního zákona a mezinárodních smluv podle čl. 10.
    (3) Zákonné opatření může Senátu navrhnout jen vláda.
    (4) Zákonné opatření Senátu podepisuje předseda Senátu, prezident republiky a předseda vlády; vyhlašuje se stejně
    jako zákony.
    (5) Zákonné opatření Senátu musí být schváleno Poslaneckou sněmovnou na její první schůzi. Neschválí-li je
    Poslanecká sněmovna, pozbývá další platnosti.
    Čl.34
    (1) Zasedání komor jsou stálá. Zasedání Poslanecké sněmovny svolává prezident republiky tak, aby bylo zahájeno
    nejpozději třicátý den po dni voleb; neučiní-li tak, sejde se Poslanecká sněmovna třicátý den po dni voleb.
    (2) Zasedání komory může být usnesením přerušeno. Celková doba, po kterou může být zasedání přerušeno, nesmí
    překročit sto dvacet dnů v roce.
    (3) V době přerušení zasedání může předseda Poslanecké sněmovny nebo Senátu svolat komoru ke schůzi před
    stanoveným termínem. Učiní tak vždy, požádá-li jej o to prezident republiky, vláda nebo nejméně pětina členů komory.
    (4) Zasedání Poslanecké sněmovny končí uplynutím jejího volebního období nebo jejím rozpuštěním.
    Čl.35
    (1) Poslaneckou sněmovnu může rozpustit prezident republiky, jestliže
    a) Poslanecká sněmovna nevyslovila důvěru nově jmenované vládě, jejíž předseda byl prezidentem republiky jmenován na
    návrh předsedy Poslanecké sněmovny,
    b) Poslanecká sněmovna se neusnese do tří měsíců o vládním návrhu zákona, s jehož projednáním spojila vláda otázku
    důvěry,
    c) zasedání Poslanecké sněmovny bylo přerušeno po dobu delší, než je přípustné,
    d) Poslanecká sněmovna nebyla po dobu delší tří měsíců způsobilá se usnášet, ačkoliv nebylo její zasedání přerušeno a
    ačkoliv byla v té době opakovaně svolána ke schůzi.
    (2) Prezident republiky Poslaneckou sněmovnu rozpustí, navrhne-li mu to Poslanecká sněmovna usnesením, s nímž
    vyslovila souhlas třípětinová většina všech poslanců.
    (3) Poslaneckou sněmovnu nelze rozpustit tři měsíce před skončením jejího volebního období.
    Čl.36
    Schůze komor jsou veřejné. Veřejnost může být vyloučena jen za podmínek stanovených zákonem.
    Čl.37
    (1) Společnou schůzi komor svolává předseda Poslanecké sněmovny.
    (2) Pro jednání společné schůze komor platí jednací řád Poslanecké sněmovny.
    Čl.38
    (1) Člen vlády má právo účastnit se schůzí obou komor, jejich výborů a komisí. Udělí se mu slovo, kdykoliv o to
    požádá.
    (2) Člen vlády je povinen osobně se dostavit do schůze Poslanecké sněmovny na základě jejího usnesení. To platí i o
    schůzi výboru, komise nebo vyšetřovací komise, kde však se člen vlády může dát zastupovat svým náměstkem nebo jiným
    členem vlády, není-li výslovně požadována jeho osobní účast.
    Čl.39
    (1) Komory jsou způsobilé se usnášet za přítomnosti alespoň jedné třetiny svých členů.
    (2) K přijetí usnesení komory je třeba souhlasu nadpoloviční většiny přítomných poslanců nebo senátorů, nestanoví-li
    Ústava jinak.
    (3) K přijetí usnesení o vyhlášení válečného stavu a k přijetí usnesení o souhlasu s vysláním ozbrojených sil České
    republiky mimo území České republiky nebo s pobytem ozbrojených sil jiných států na území České republiky, jakož i k přijetí
    usnesení o účasti České republiky v obranných systémech mezinárodní organizace, jíž je Česká republika členem, je třeba
    souhlasu nadpoloviční většiny všech poslanců a nadpoloviční většiny všech senátorů.
    (4) K přijetí ústavního zákona a souhlasu k ratifikaci mezinárodní smlouvy uvedené v čl. 10a odst. 1 je třeba souhlasu
    třípětinové většiny všech poslanců a třípětinové většiny přítomných senátorů.
    Čl.40
    K přijetí volebního zákona a zákona o zásadách jednání a styku obou komor mezi sebou, jakož i navenek a zákona o
    jednacím řádu Senátu je třeba, aby byl schválen Poslaneckou sněmovnou a Senátem.
    Čl.41
    (1) Návrhy zákonů se podávají Poslanecké sněmovně.
    (2) Návrh zákona může podat poslanec, skupina poslanců, Senát, vláda nebo zastupitelstvo vyššího územního
    samosprávného celku.
    Čl.42
    (1) Návrh zákona o státním rozpočtu a návrh státního závěrečného účtu podává vláda.
    (2) Tyto návrhy projednává na veřejné schůzi a usnáší se o nich jen Poslanecká sněmovna.
    Čl.43
    (1) Parlament rozhoduje o vyhlášení válečného stavu, je-li Česká republika napadena, nebo je-li třeba plnit
    mezinárodní smluvní závazky o společné obraně proti napadení.
    (2) Parlament rozhoduje o účasti České republiky v obranných systémech mezinárodní organizace, jíž je Česká
    republika členem.
    (3) Parlament vyslovuje souhlas
    a) s vysláním ozbrojených sil České republiky mimo území České republiky,
    b) s pobytem ozbrojených sil jiných států na území České republiky,
    nejsou-li taková rozhodnutí vyhrazena vládě.
    (4) Vláda rozhoduje o vyslání ozbrojených sil České republiky mimo území České republiky a o pobytu ozbrojených
    sil jiných států na území České republiky, a to nejdéle na dobu 60 dnů, jde-li o
    a) plnění závazků z mezinárodních smluv o společné obraně proti napadení,
    b) účast na mírových operacích podle rozhodnutí mezinárodní organizace, jíž je Česká republika členem, a to se souhlasem
    přijímajícího státu,
    c) účast na záchranných pracích při živelních pohromách, průmyslových nebo ekologických haváriích.
    (5) Vláda dále rozhoduje
    a) o průjezdu ozbrojených sil jiných států přes území České republiky nebo o jejich přeletu nad územím České republiky,
    b) o účasti ozbrojených sil České republiky na vojenských cvičeních mimo území České republiky a o účasti ozbrojených sil
    jiných států na vojenských cvičeních na území České republiky.
    (6) O rozhodnutích podle odstavců 4 a 5 informuje vláda neprodleně obě komory Parlamentu. Parlament může
    rozhodnutí vlády zrušit; ke zrušení rozhodnutí vlády postačuje nesouhlasné usnesení jedné z komor přijaté nadpoloviční
    většinou všech členů komory.
    Čl.44
    (1) Vláda má právo vyjádřit se ke všem návrhům zákonů.
    (2) Nevyjádří-li se vláda do třiceti dnů od doby, kdy jí byl návrh zákona doručen, platí, že se vyjádřila kladně.
    (3) Vláda je oprávněna žádat, aby Poslanecká sněmovna skončila projednávání vládního návrhu zákona do tří
    měsíců od jeho předložení, pokud s tím vláda spojí žádost o vyslovení důvěry.
    Čl.45
    Návrh zákona, se kterým Poslanecká sněmovna vyslovila souhlas, postoupí Poslanecká sněmovna Senátu bez
    zbytečného odkladu.
    Čl.46
    (1) Senát projedná návrh zákona a usnese se k němu do třiceti dnů od jeho postoupení.
    (2) Senát svým usnesením návrh zákona schválí nebo zamítne nebo vrátí Poslanecké sněmovně s pozměňovacími
    návrhy anebo vyjádří vůli nezabývat se jím.
    (3) Jestliže se Senát nevyjádří ve lhůtě podle odstavce 1, platí, že je návrh zákona přijat.
    Čl.47
    (1) Jestliže Senát návrh zákona zamítne, hlasuje o něm Poslanecká sněmovna znovu. Návrh zákona je přijat, jestliže
    je schválen nadpoloviční většinou všech poslanců.
    (2) Jestliže Senát návrh zákona vrátí Poslanecké sněmovně s pozměňovacími návrhy, hlasuje o něm Poslanecká
    sněmovna ve znění schváleném Senátem. Jejím usnesením je návrh zákona přijat.
    (3) Jestliže Poslanecká sněmovna neschválí návrh zákona ve znění schváleném Senátem, hlasuje znovu o návrhu
    zákona ve znění, ve kterém byl postoupen Senátu. Návrh zákona je přijat, jestliže je schválen nadpoloviční většinou všech
    poslanců.
    (4) Pozměňovací návrhy nejsou při projednávání zamítnutého nebo vráceného návrhu zákona v Poslanecké
    sněmovně přípustné.
    Čl.48
    Jestliže Senát vyjádří vůli nezabývat se návrhem zákona, je tímto usnesením návrh zákona přijat.
    Čl.49
    K ratifikaci mezinárodních smluv
    a) upravujících práva a povinnosti osob,
    b) spojeneckých, mírových a jiných politických,
    c) z nichž vzniká členství České republiky v mezinárodní organizaci,
    d) hospodářských, jež jsou všeobecné povahy,
    e) o dalších věcech, jejichž úprava je vyhrazena zákonu,
    je třeba souhlasu obou komor Parlamentu.
    Čl.50
    (1) Prezident republiky má právo vrátit přijatý zákon s výjimkou zákona ústavního, s odůvodněním do patnácti dnů
    ode dne, kdy mu byl postoupen.
    (2) O vráceném zákonu hlasuje Poslanecká sněmovna znovu. Pozměňovací návrhy nejsou přípustné. Jestliže
    Poslanecká sněmovna setrvá na vráceném zákonu nadpoloviční většinou všech poslanců, zákon se vyhlásí. Jinak platí, že
    zákon nebyl přijat.
    Čl.51
    Přijaté zákony podepisuje předseda Poslanecké sněmovny, prezident republiky a předseda vlády.
    Čl.52
    (1) K platnosti zákona je třeba, aby byl vyhlášen.
    (2) Způsob vyhlášení zákona a mezinárodní smlouvy stanoví zákon.
    Čl.53
    (1) Každý poslanec má právo interpelovat vládu nebo její členy ve věcech jejich působnosti.
    (2) Interpelovaní členové vlády odpovědí na interpelaci do třiceti dnů ode dne jejího podání.
    HLAVA TŘETÍ
    Moc výkonná
    Prezident republiky
    Čl.54
    (1) Prezident republiky je hlavou státu.
    (2) Prezident republiky je volen v přímých volbách.
    (3) Prezident republiky není z výkonu své funkce odpovědný.
    Čl.55
    Prezident republiky se ujímá úřadu složením slibu. Volební období prezidenta republiky trvá pět let a začíná dnem
    složení slibu.
    Čl.56
    (1) Volba prezidenta republiky se koná tajným hlasováním na základě všeobecného, rovného a přímého volebního
    práva.
    (2) Prezidentem republiky je zvolen kandidát, který obdržel nadpoloviční většinu platných hlasů oprávněných voličů.
    Není-li takový kandidát, koná se za čtrnáct dnů po začátku prvního kola volby druhé kolo volby, do kterého postupují dva
    nejúspěšnější kandidáti z prvního kola volby. Při rovnosti hlasů postupují do druhého kola volby všichni kandidáti, kteří v prvním
    kole volby získali nejvyšší počet platných hlasů oprávněných voličů, a nejsou-li takoví kandidáti alespoň dva, postupují i
    kandidáti, kteří obdrželi druhý nejvyšší počet platných hlasů oprávněných voličů.
    (3) Prezidentem republiky je zvolen kandidát, který obdržel ve druhém kole volby nejvyšší počet platných hlasů
    oprávněných voličů. Je-li takových kandidátů více, prezident republiky není zvolen a do deseti dnů se vyhlásí nová volba
    prezidenta republiky.
    (4) Pokud kandidát, který postoupil do druhého kola volby, přestane být volitelný za prezidenta republiky před druhým
    kolem volby anebo se práva kandidovat vzdá, postupuje do druhého kola volby kandidát, který v prvním kole volby získal další
    nejvyšší počet platných hlasů oprávněných voličů. Druhé kolo volby se koná i tehdy, účastní-li se ho pouze jeden kandidát.
    (5) Navrhovat kandidáta je oprávněn každý občan České republiky, který dosáhl věku 18 let, podpoří-li jeho návrh
    petice podepsaná nejméně 50 000 občany České republiky oprávněnými volit prezidenta republiky. Navrhovat kandidáta je
    oprávněno nejméně dvacet poslanců nebo nejméně deset senátorů.
    (6) Právo volit má každý občan České republiky, který dosáhl věku 18 let.
    (7) Volba prezidenta republiky se koná v posledních šedesáti dnech volebního období úřadujícího prezidenta
    republiky, nejpozději však třicet dnů před uplynutím volebního období úřadujícího prezidenta republiky. Uvolní-li se úřad
    prezidenta republiky, koná se volba prezidenta republiky do devadesáti dnů.
    (8) Volbu prezidenta republiky vyhlašuje předseda Senátu nejpozději devadesát dnů před jejím konáním. Uvolní-li se
    úřad prezidenta republiky, vyhlásí předseda Senátu volbu prezidenta republiky nejpozději do deseti dnů poté a zároveň
    nejpozději osmdesát dnů před jejím konáním.
    (9) Není-li funkce předsedy Senátu obsazena, vyhlašuje volbu prezidenta republiky předseda Poslanecké sněmovny.
    Čl.57
    (1) Prezidentem republiky může být zvolen občan, který je volitelný do Senátu.
    (2) Nikdo nemůže být zvolen více než dvakrát za sebou.
    Čl.58
    Další podmínky výkonu volebního práva při volbě prezidenta republiky, jakož i podrobnosti navrhování kandidátů na
    funkci prezidenta republiky, vyhlašování a provádění volby prezidenta republiky a vyhlašování jejího výsledku a soudní přezkum
    stanoví zákon.
    Čl.59
    (1) Prezident republiky složí slib do rukou předsedy Senátu na společné schůzi obou komor.
    (2) Slib prezidenta republiky zní: "Slibuji věrnost České republice. Slibuji, že budu zachovávat její Ústavu a zákony.
    Slibuji na svou čest, že svůj úřad budu zastávat v zájmu všeho lidu a podle svého nejlepšího vědomí a svědomí.".
    Čl.60
    Odmítne-li prezident republiky složit slib nebo složí-li slib s výhradou, hledí se na něho, jako by nebyl zvolen.
    Čl.61
    Prezident republiky se může vzdát svého úřadu do rukou předsedy Senátu.
    Čl.62
    Prezident republiky
    a) jmenuje a odvolává předsedu a další členy vlády a přijímá jejich demisi, odvolává vládu a přijímá její demisi,
    b) svolává zasedání Poslanecké sněmovny,
    c) rozpouští Poslaneckou sněmovnu,
    d) pověřuje vládu, jejíž demisi přijal nebo kterou odvolal, vykonáváním jejích funkcí prozatímně až do jmenování nové vlády,
    e) jmenuje soudce Ústavního soudu, jeho předsedu a místopředsedy,
    f) jmenuje ze soudců předsedu a místopředsedy Nejvyššího soudu,
    g) odpouští a zmírňuje tresty uložené soudem a zahlazuje odsouzení,
    h) má právo vrátit Parlamentu přijatý zákon s výjimkou zákona ústavního,
    i) podepisuje zákony,
    j) jmenuje prezidenta a viceprezidenta Nejvyššího kontrolního úřadu,
    k) jmenuje členy Bankovní rady České národní banky.
    Čl.63
    (1) Prezident republiky dále
    a) zastupuje stát navenek,
    b) sjednává a ratifikuje mezinárodní smlouvy; sjednávání mezinárodních smluv může přenést na vládu nebo s jejím souhlasem
    na její jednotlivé členy,
    c) je vrchním velitelem ozbrojených sil,
    d) přijímá vedoucí zastupitelských misí,
    e) pověřuje a odvolává vedoucí zastupitelských misí,
    f) vyhlašuje volby do Poslanecké sněmovny a do Senátu,
    g) jmenuje a povyšuje generály,
    h) propůjčuje a uděluje státní vyznamenání, nezmocní-li k tomu jiný orgán,
    i) jmenuje soudce,
    j) nařizuje, aby se trestní řízení nezahajovalo, a bylo-li zahájeno, aby se v něm nepokračovalo,
    k) má právo udělovat amnestii.
    (2) Prezidentovi republiky přísluší vykonávat i pravomoci, které nejsou výslovně v ústavním zákoně uvedeny, stanoví-
    li tak zákon.
    (3) Rozhodnutí prezidenta republiky vydané podle odstavců 1 a 2 vyžaduje ke své platnosti spolupodpis předsedy
    vlády nebo jím pověřeného člena vlády.
    (4) Za rozhodnutí prezidenta republiky, které vyžaduje spolupodpis předsedy vlády nebo jím pověřeného člena vlády,
    odpovídá vláda.
    Čl.64
    (1) Prezident republiky má právo účastnit se schůzí obou komor Parlamentu, jejich výborů a komisí. Udělí se mu
    slovo, kdykoliv o to požádá.
    (2) Prezident republiky má právo účastnit se schůzí vlády, vyžádat si od vlády a jejích členů zprávy a projednávat s
    vládou nebo s jejími členy otázky, které patří do jejich působnosti.
    Čl.65
    (1) Prezidenta republiky nelze po dobu výkonu jeho funkce zadržet, trestně stíhat ani stíhat pro přestupek nebo jiný
    správní delikt.
    (2) Senát může se souhlasem Poslanecké sněmovny podat ústavní žalobu proti prezidentu republiky k Ústavnímu
    soudu, a to pro velezradu nebo pro hrubé porušení Ústavy nebo jiné součásti ústavního pořádku; velezradou se rozumí jednání
    prezidenta republiky směřující proti svrchovanosti a celistvosti republiky, jakož i proti jejímu demokratickému řádu. Ústavní soud
    může na základě ústavní žaloby Senátu rozhodnout o tom, že prezident republiky ztrácí prezidentský úřad a způsobilost jej
    znovu nabýt.
    (3) K přijetí návrhu ústavní žaloby Senátem je třeba souhlasu třípětinové většiny přítomných senátorů. K přijetí
    souhlasu Poslanecké sněmovny s podáním ústavní žaloby je třeba souhlasu třípětinové většiny všech poslanců; nevysloví-li
    Poslanecká sněmovna souhlas do tří měsíců ode dne, kdy o něj Senát požádal, platí, že souhlas nebyl dán.
    Čl.66
    Uvolní-li se úřad prezidenta republiky a nový prezident republiky ještě není zvolen nebo nesložil slib, rovněž nemůže-
    li prezident republiky svůj úřad ze závažných důvodů vykonávat a usnese-li se na tom Poslanecká sněmovna a Senát, přísluší
    výkon funkcí podle čl. 63 odst. 1 písm. a) až e) a h) až k) a čl. 63 odst. 2 předsedovi vlády. Předsedovi Poslanecké sněmovny
    přísluší v době, kdy předseda vlády vykonává vymezené funkce prezidenta republiky, výkon funkcí prezidenta republiky podle
    čl. 62 písm. a) až e) a k) a dále čl. 63 odst. 1 písm. f), jde-li o vyhlášení voleb do Senátu; uvolní-li se úřad prezidenta republiky v
    době, kdy je Poslanecká sněmovna rozpuštěna, přísluší výkon těchto funkcí předsedovi Senátu, kterému též přísluší v době,
    kdy předseda vlády vykonává vymezené funkce prezidenta republiky, výkon funkce prezidenta republiky podle čl. 63 odst. 1
    písm. f), jde-li o vyhlášení voleb do Poslanecké sněmovny.
    Vláda
    Čl.67
    (1) Vláda je vrcholným orgánem výkonné moci.
    (2) Vláda se skládá z předsedy vlády, místopředsedů vlády a ministrů.
    Čl.68
    (1) Vláda je odpovědna Poslanecké sněmovně.
    (2) Předsedu vlády jmenuje prezident republiky a na jeho návrh jmenuje ostatní členy vlády a pověřuje je řízením
    ministerstev nebo jiných úřadů.
    (3) Vláda předstoupí do třiceti dnů po svém jmenování před Poslaneckou sněmovnu a požádá ji o vyslovení důvěry.
    (4) Pokud nově jmenovaná vláda nezíská v Poslanecké sněmovně důvěru, postupuje se podle odstavců 2 a 3.
    Jestliže ani takto jmenovaná vláda nezíská důvěru Poslanecké sněmovny, jmenuje prezident republiky předsedu vlády na návrh
    předsedy Poslanecké sněmovny.
    (5) V ostatních případech prezident republiky jmenuje a odvolává na návrh předsedy vlády ostatní členy vlády a
    pověřuje je řízením ministerstev nebo jiných úřadů.
    Čl.69
    (1) Člen vlády skládá slib do rukou prezidenta republiky.
    (2) Slib člena vlády zní: "Slibuji věrnost České republice. Slibuji, že budu zachovávat její Ústavu a zákony a uvádět je
    v život. Slibuji na svou čest, že budu zastávat svůj úřad svědomitě a nezneužiji svého postavení.".
    Čl.70
    Člen vlády nesmí vykonávat činnosti, jejichž povaha odporuje výkonu jeho funkce. Podrobnosti stanoví zákon.
    Čl.71
    Vláda může předložit Poslanecké sněmovně žádost o vyslovení důvěry.
    Čl.72
    (1) Poslanecká sněmovna může vyslovit vládě nedůvěru.
    (2) Návrh na vyslovení nedůvěry vládě projedná Poslanecká sněmovna, jen je-li podán písemně nejméně padesáti
    poslanci. K přijetí návrhu je třeba souhlasu nadpoloviční většiny všech poslanců.
    Čl.73
    (1) Předseda vlády podává demisi do rukou prezidenta republiky. Ostatní členové vlády podávají demisi do rukou
    prezidenta republiky prostřednictvím předsedy vlády.
    (2) Vláda podá demisi, jestliže Poslanecká sněmovna zamítla její žádost o vyslovení důvěry nebo jestliže jí vyslovila
    nedůvěru. Vláda podá demisi vždy po ustavující schůzi nově zvolené Poslanecké sněmovny.
    (3) Podá-li vláda demisi podle odstavce 2, prezident republiky demisi přijme.
    Čl.74
    Prezident republiky odvolá člena vlády, jestliže to navrhne předseda vlády.
    Čl.75
    Prezident republiky odvolá vládu, která nepodala demisi, ačkoliv ji byla povinna podat.
    Čl.76
    (1) Vláda rozhoduje ve sboru.
    (2) K přijetí usnesení vlády je třeba souhlasu nadpoloviční většiny všech jejích členů.
    Čl.77
    (1) Předseda vlády organizuje činnost vlády, řídí její schůze, vystupuje jejím jménem a vykonává další činnosti, které
    jsou mu svěřeny Ústavou nebo jinými zákony.
    (2) Předsedu vlády zastupuje místopředseda vlády nebo jiný pověřený člen vlády.
    Čl.78
    K provedení zákona a v jeho mezích je vláda oprávněna vydávat nařízení. Nařízení podepisuje předseda vlády a
    příslušný člen vlády.
    Čl.79
    (1) Ministerstva a jiné správní úřady lze zřídit a jejich působnost stanovit pouze zákonem.
    (2) Právní poměry státních zaměstnanců v ministerstvech a jiných správních úřadech upravuje zákon.
    (3) Ministerstva, jiné správní úřady a orgány územní samosprávy mohou na základě a v mezích zákona vydávat
    právní předpisy, jsou-li k tomu zákonem zmocněny.
    Čl.80
    (1) Státní zastupitelství zastupuje veřejnou žalobu v trestním řízení; vykonává i další úkoly, stanoví-li tak zákon.
    (2) Postavení a působnost státního zastupitelství stanoví zákon.
    HLAVA ČTVRTÁ
    Moc soudní
    Čl.81
    Soudní moc vykonávají jménem republiky nezávislé soudy.
    Čl.82
    (1) Soudci jsou při výkonu své funkce nezávislí. Jejich nestrannost nesmí nikdo ohrožovat.
    (2) Soudce nelze proti jeho vůli odvolat nebo přeložit k jinému soudu; výjimky vyplývající zejména z kárné
    odpovědnosti stanoví zákon.
    (3) Funkce soudce není slučitelná s funkcí prezidenta republiky, člena Parlamentu ani s jakoukoli funkcí ve veřejné
    správě; zákon stanoví, se kterými dalšími činnostmi je výkon soudcovské funkce neslučitelný.
    Ústavní soud
    Čl.83
    Ústavní soud je soudním orgánem ochrany ústavnosti.
    Čl.84
    (1) Ústavní soud se skládá z 15 soudců, kteří jsou jmenováni na dobu deseti let.
    (2) Soudce Ústavního soudu jmenuje prezident republiky se souhlasem Senátu.
    (3) Soudcem Ústavního soudu může být jmenován bezúhonný občan, který je volitelný do Senátu, má vysokoškolské
    právnické vzdělání a byl nejméně deset let činný v právnickém povolání.
    Čl.85
    (1) Složením slibu do rukou prezidenta republiky se soudce Ústavního soudu ujímá své funkce.
    (2) Slib soudce Ústavního soudu zní: "Slibuji na svou čest a svědomí, že budu chránit neporušitelnost přirozených
    práv člověka a práv občana, řídit se ústavními zákony a rozhodovat podle svého nejlepšího přesvědčení nezávisle a
    nestranně.".
    (3) Odmítne-li soudce složit slib nebo složí-li slib s výhradou, hledí se na něho, jako by nebyl jmenován.
    Čl.86
    (1) Soudce Ústavního soudu nelze trestně stíhat bez souhlasu Senátu. Odepře-li Senát souhlas, je trestní stíhání po
    dobu trvání funkce soudce Ústavního soudu vyloučeno.
    (2) Soudce Ústavního soudu lze zadržet jen, byl-li dopaden při spáchání trestného činu, anebo bezprostředně poté.
    Příslušný orgán je povinen zadržení ihned oznámit předsedovi Senátu. Nedá-li předseda Senátu do 24 hodin od zadržení
    souhlas k odevzdání zadrženého soudu, je příslušný orgán povinen ho propustit. Na své první následující schůzi Senát
    rozhodne o přípustnosti trestního stíhání s konečnou platností.
    (3) Soudce Ústavního soudu má právo odepřít svědectví o skutečnostech, které se dozvěděl v souvislosti s výkonem
    své funkce, a to i poté, kdy přestal být soudcem Ústavního soudu.
    Čl.87
    (1) Ústavní soud rozhoduje
    a) o zrušení zákonů nebo jejich jednotlivých ustanovení, jsou-li v rozporu s ústavním pořádkem,
    b) o zrušení jiných právních předpisů nebo jejich jednotlivých ustanovení, jsou-li v rozporu s ústavním pořádkem nebo zákonem,
    c) o ústavní stížnosti orgánů územní samosprávy proti nezákonnému zásahu státu,
    d) o ústavní stížnosti proti pravomocnému rozhodnutí a jinému zásahu orgánů veřejné moci do ústavně zaručených základních
    práv a svobod,
    e) o opravném prostředku proti rozhodnutí ve věci ověření volby poslance nebo senátora,
    f) v pochybnostech o ztrátě volitelnosti a o neslučitelnosti výkonu funkcí poslance nebo senátora podle čl. 25,
    g) o ústavní žalobě Senátu proti prezidentu republiky podle čl. 65 odst. 2,
    h) o návrhu prezidenta republiky na zrušení usnesení Poslanecké sněmovny a Senátu podle čl. 66,
    i) o opatřeních nezbytných k provedení rozhodnutí mezinárodního soudu, které je pro Českou republiku závazné, pokud je
    nelze provést jinak,
    j) o tom, zda rozhodnutí o rozpuštění politické strany nebo jiné rozhodnutí týkající se činnosti politické strany je ve shodě s
    ústavními nebo jinými zákony,
    k) spory o rozsah kompetencí státních orgánů a orgánů územní samosprávy, nepřísluší-li podle zákona jinému orgánu.
    (2) Ústavní soud dále rozhoduje o souladu mezinárodní smlouvy podle čl. 10a a čl. 49 s ústavním pořádkem, a to
    před její ratifikací. Do rozhodnutí Ústavního soudu nemůže být smlouva ratifikována.
    (3) Zákon může stanovit, že namísto Ústavního soudu rozhoduje Nejvyšší správní soud
    a) o zrušení právních předpisů nebo jejich jednotlivých ustanovení, jsou-li v rozporu se zákonem,
    b) spory o rozsah kompetencí státních orgánů a orgánů územní samosprávy, nepřísluší-li podle zákona jinému orgánu.
    Čl.88
    (1) Zákon stanoví, kdo a za jakých podmínek je oprávněn podat návrh na zahájení řízení a další pravidla o řízení před
    Ústavním soudem.
    (2) Soudci Ústavního soudu jsou při svém rozhodování vázáni pouze ústavním pořádkem a zákonem podle odstavce
    1.
    Čl.89
    (1) Rozhodnutí Ústavního soudu je vykonatelné, jakmile bylo vyhlášeno způsobem stanoveným zákonem, pokud
    Ústavní soud o jeho vykonatelnosti nerozhodl jinak.
    (2) Vykonatelná rozhodnutí Ústavního soudu jsou závazná pro všechny orgány i osoby.
    (3) Rozhodnutí Ústavního soudu, kterým byl podle čl. 87 odst. 2 vysloven nesoulad mezinárodní smlouvy s ústavním
    pořádkem, brání ratifikaci smlouvy do doby, než bude nesoulad odstraněn.
    Soudy
    Čl.90
    Soudy jsou povolány především k tomu, aby zákonem stanoveným způsobem poskytovaly ochranu právům. Jen soud
    rozhoduje o vině a trestu za trestné činy.
    Čl.91
    (1) Soustavu soudů tvoří Nejvyšší soud, Nejvyšší správní soud, vrchní, krajské a okresní soudy. Zákon může stanovit
    jejich jiné označení.
    (2) Působnost a organizaci soudů stanoví zákon.
    Čl.92
    Nejvyšší soud je vrcholným soudním orgánem ve věcech patřících do pravomoci soudů s výjimkou záležitostí, o nichž
    rozhoduje Ústavní soud nebo Nejvyšší správní soud.
    Čl.93
    (1) Soudce je jmenován do funkce prezidentem republiky bez časového omezení. Své funkce se ujímá složením
    slibu.
    (2) Soudcem může být jmenován bezúhonný občan, který má vysokoškolské právnické vzdělání. Další předpoklady a
    postup stanoví zákon.
    Čl.94
    (1) Zákon stanoví případy, kdy soudci rozhodují v senátu a jaké je jeho složení. V ostatních případech rozhodují jako
    samosoudci.
    (2) Zákon může stanovit, ve kterých věcech a jakým způsobem se na rozhodování soudů podílejí vedle soudců i další
    občané.
    Čl.95
    (1) Soudce je při rozhodování vázán zákonem a mezinárodní smlouvou, která je součástí právního řádu; je oprávněn
    posoudit soulad jiného právního předpisu se zákonem nebo s takovou mezinárodní smlouvou.
    (2) Dojde-li soud k závěru, že zákon, jehož má být při řešení věci použito, je v rozporu s ústavním pořádkem, předloží
    věc Ústavnímu soudu.
    Čl.96
    (1) Všichni účastníci řízení mají před soudem rovná práva.
    (2) Jednání před soudem je ústní a veřejné; výjimky stanoví zákon. Rozsudek se vyhlašuje vždy veřejně.
    HLAVA PÁTÁ
    Nejvyšší kontrolní úřad
    Čl.97
    (1) Nejvyšší kontrolní úřad je nezávislý orgán. Vykonává kontrolu hospodaření se státním majetkem a plnění státního
    rozpočtu.
    (2) Prezidenta a viceprezidenta Nejvyššího kontrolního úřadu jmenuje prezident republiky na návrh Poslanecké
    sněmovny.
    (3) Postavení, působnost, organizační strukturu a další podrobnosti stanoví zákon.
    HLAVA ŠESTÁ
    Česká národní banka
    Čl.98
    (1) Česká národní banka je ústřední bankou státu. Hlavním cílem její činnosti je péče o cenovou stabilitu; do její
    činnosti lze zasahovat pouze na základě zákona.
    (2) Postavení, působnost a další podrobnosti stanoví zákon.
    HLAVA SEDMÁ
    Územní samospráva
    Čl.99
    Česká republika se člení na obce, které jsou základními územními samosprávnými celky, a kraje, které jsou vyššími
    územními samosprávnými celky.
    Čl.100
    (1) Územní samosprávné celky jsou územními společenstvími občanů, která mají právo na samosprávu. Zákon
    stanoví, kdy jsou správními obvody.
    (2) Obec je vždy součástí vyššího územního samosprávného celku.
    (3) Vytvořit nebo zrušit vyšší územní samosprávný celek lze jen ústavním zákonem.
    Čl.101
    (1) Obec je samostatně spravována zastupitelstvem.
    (2) Vyšší územní samosprávný celek je samostatně spravován zastupitelstvem.
    (3) Územní samosprávné celky jsou veřejnoprávními korporacemi, které mohou mít vlastní majetek a hospodaří podle
    vlastního rozpočtu.
    (4) Stát může zasahovat do činnosti územních samosprávných celků, jen vyžaduje-li to ochrana zákona, a jen
    způsobem stanoveným zákonem.
    Čl.102
    (1) Členové zastupitelstev jsou voleni tajným hlasováním na základě všeobecného, rovného a přímého volebního
    práva.
    (2) Funkční období zastupitelstva je čtyřleté. Zákon stanoví, za jakých podmínek se vyhlásí nové volby zastupitelstva
    před uplynutím jeho funkčního období.
    Čl.103
    zrušen
    Čl.104
    (1) Působnost zastupitelstev může být stanovena jen zákonem.
    (2) Zastupitelstvo obce rozhoduje ve věcech samosprávy, pokud nejsou zákonem svěřeny zastupitelstvu vyššího
    územního samosprávného celku.
    (3) Zastupitelstva mohou v mezích své působnosti vydávat obecně závazné vyhlášky.
    Čl.105
    Výkon státní správy lze svěřit orgánům samosprávy jen tehdy, stanoví-li to zákon.
    HLAVA OSMÁ
    Přechodná a závěrečná ustanovení
    Čl.106
    (1) Dnem účinnosti této Ústavy se Česká národní rada stává Poslaneckou sněmovnou, jejíž volební období skončí
    dnem 6. června 1996.
    (2) Do doby zvolení Senátu podle Ústavy vykonává funkce Senátu Prozatímní Senát. Prozatímní Senát se ustaví
    způsobem, který stanoví ústavní zákon. Do nabytí účinnosti tohoto zákona vykonává funkce Senátu Poslanecká sněmovna.
    (3) Poslaneckou sněmovnu nelze rozpustit, dokud vykonává funkci Senátu podle odstavce 2.
    (4) Do přijetí zákonů o jednacím řádu komor se postupuje v jednotlivých komorách podle jednacího řádu České
    národní rady.
    Čl.107
    (1) Zákon o volbách do Senátu stanoví, jakým způsobem se při prvních volbách do Senátu určí třetina senátorů,
    jejichž volební období bude dvouleté, a třetina senátorů, jejichž volební období bude čtyřleté.
    (2) Zasedání Senátu svolá prezident republiky tak, aby bylo zahájeno nejpozději třicátý den po dni voleb; neučiní-li
    tak, sejde se Senát třicátý den po dni voleb.
    Čl.108
    Vláda České republiky jmenovaná po volbách v roce 1992 a vykonávající svou funkci ke dni účinnosti Ústavy se
    považuje za vládu jmenovanou podle této Ústavy.
    Čl.109
    Do doby zřízení státního zastupitelství vykonává jeho funkce prokuratura České republiky.
    Čl.110
    Do 31. prosince 1993 tvoří soustavu soudů též vojenské soudy.
    Čl.111
    Soudci všech soudů České republiky vykonávající funkci soudce ke dni nabytí účinnosti této Ústavy se považují za
    soudce jmenované podle Ústavy České republiky.
    Čl.112
    (1) Ústavní pořádek České republiky tvoří tato Ústava, Listina základních práv a svobod, ústavní zákony přijaté podle
    této Ústavy a ústavní zákony Národního shromáždění Československé republiky, Federálního shromáždění Československé
    socialistické republiky a České národní rady upravující státní hranice České republiky a ústavní zákony České národní rady
    přijaté po 6. červnu 1992.
    (2) Zrušují se dosavadní Ústava, ústavní zákon o československé federaci, ústavní zákony, které je měnily a
    doplňovaly, a ústavní zákon České národní rady č. 67/1990 Sb., o státních symbolech České republiky.
    (3) Ostatní ústavní zákony platné na území České republiky ke dni účinnosti této Ústavy mají sílu zákona.
    Čl.113
    Tato Ústava nabývá účinnosti dnem 1. ledna 1993.
    Uhde v. r.
    Klaus v. r.
    """;
Console.WriteLine(textCh.Analysis(input, true));