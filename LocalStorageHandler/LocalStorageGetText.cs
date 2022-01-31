﻿using System;

namespace Barcelona.LocalStorageHandler
{
    public static class LocalStorageGetText
    {
        public static string GetText(int enumTab)
        {
            string text = string.Empty;

            if (enumTab == (int)Helper.enumTab.SagradaFamilia)
            {
                text = "Είναι το πιο διάσημο τουριστικό αξιοθέατο της Βαρκελώνης. Το έργο ήταν αρχικά μια ιδέα ενός Καταλανού βιβλιοπώλη, του Τζόσεπ Μαρία Μποκαμπέλα, οποίος και ξεκίνησε την κατασκευή της κρύπτης του ναού " +
                    "στις 19 Μαρτίου 1882 με αρχιτέκτονα τον Francisco de Paula del Villar. Έναν χρόνο αργότερα μπήκε στο πρότζεκτ ο Γκαουντί και το 1883 είναι πλέων αναλάβει την πλήρη ευθύνη, αλλάζοντας δραστικά τα σχέδια, " +
                    "τη μεταμόρφωσε με το αρχιτεκτονικό και μηχανικό στυλ του συνδυάζοντας το γοτθικό ρυθμό και μορφές Μοντερνισμού. Ο Γκαουντί αφιέρωσε πλήρως τα τελευταία χρόνια της ζωής του στην κατασκευή της Σαγράδα Φαμίλια " +
                    "και μέχρι το 1926 που απεβίωσε, είχε ολοκληρώσει το 15 με 25 τοις εκατό.\nΗ κατασκευή χαρακτηρίζεται από δεκάδες συμβολισμούς με χαρακτηριστικό παράδειγμα τον κεντρικό πύργο που ονομάζεται \"πύργος του Χριστού\"" +
                    " και με τα 170 μέτρα του είναι κατά 1 μέτρο μικρότερος από το λόφο Montjuïc (έναν από τους βασικούς λόφους της πόλης), καθώς ο Γκαουντί πίστευε ότι η δημιουργία του δεν πρέπει να ξεπεράσει τη " +
                    "δημιουργία του θεού.\nΊσως το πιο εντυπωσιακό χαρακτηριστικό του ναού (εκτός από το μέγεθός του) είναι ότι ακόμα κατασκευάζεται, ενώ υπάρχει μεγάλη διαμάχη για τα υλικά που χρησιμοποιούνται σήμερα με " +
                    "πολλούς να λένε ότι ο Γκαουντί δε θα τα χρησιμοποιούσε. Μη χάσετε το υπόγειο του κτιρίου, όπου υπάρχει ένα μίνι μουσείο στο οποίο θα βρείτε το αυθεντικό σχέδιο του αρχιτέκτονα, το οποίο έγινε " +
                    "με σακουλάκια από τσάι που κρέμονται ανάποδα.\nWIKIPEDIA\nελληνικά:\u00a0Βασιλική και Εξαγνιστική Εκκλησία της Αγίας Οικογενείας\nΑν και ημιτελής, η εκκλησία αποτελεί Μνημείο Παγκόσμιας Κληρονομιάς\u00a0της " +
                    "UNESCO\u00a0και το Νοέμβριο του 2010 εγκαινιάστηκε και καθαγιάστηκε από τον Πάπα Βενέδικτο ΙΣΤ’\u00a0και έγινε Βασιλική και μπορεί πλέον να τελεστεί εκεί η Θεία Λειτουργία\u00a0και να την παρακολουθήσουν οι " +
                    "πιστοί.\nΗ κατασκευή της\u00a0Σαγράδα Φαμίλια\u00a0προχώρησε με αργούς ρυθμούς καθώς βασιζόταν σε ιδιωτικές δωρεές και διακόπηκε από τον Ισπανικό Εμφύλιο όπου\u00a0τμήματα της ημιτελούς βασιλικής και τα " +
                    "μοντέλα του Γκαουντί καθώς και το εργαστήριό του καταστράφηκαν κατά τη διάρκεια του πολέμου από Καταλανούς αναρχικούς. Το σημερινό σχέδιο είναι βασισμένο σε ανακατασκευασμένες εκδοχές των χαμένων σχεδίων " +
                    "καθώς και σε μοντέρνες προσαρμογές.\u00a0 Η κατασκευή πέρασε τη μέση το 2010, με μερικές από τις μεγαλύτερες προκλήσεις να παραμένουν και μια αναμενόμενη ημερομηνία ολοκλήρωσης το 2026 - επέτειος 100 χρόνων " +
                    "από το θάνατο του Γκαουντί. Η\u00a0Σαγράδα Φαμίλια\u00a0έχει διχάσει τους πολίτες της Βαρκελώνης για τους λόγους ότι συναγωνίζεται με τον Καθεδρικό Ναό της Βαρκελώνης, για το σχέδιο του Γκαουντί και την " +
                    "πιθανότητα ότι η δουλειά που έγινε μετά το θάνατό του δεν βασίστηκε στο σχέδιό του και πιο πρόσφατα για το υπόγειο τούνελ ενός υπόγειου τραίνου της Ισπανίας που μπορεί να διαταράξει τη σταθερότητα του " +
                    "κτιρίου.\nΗ εκκλησία θα έχει τρεις μεγάλες προσόψεις: η πρόσοψη της Γέννησης προς την Ανατολή, η πρόσοψη των Παθών προς τη Δύση καθώς και η πρόσοψη της Δόξας προς το Νότο. Η πρόσοψη της Γέννησης χτίστηκε " +
                    "πριν η κατασκευή διακοπεί το 1935 και φέρει την πιο άμεση επιρροή από τον Γκαουντί. Η πρόσοψη των Παθών είναι ιδιαίτερα εντυπωσιακή για το κωδωνοστάσιό της, τους βασανισμένους χαρακτήρες που συμπεριλαμβάνουν " +
                    "και φιγούρες του Χριστού καθώς και τον Χριστό εσταυρωμένο. Αυτά τα αμφιλεγόμενα σχέδια αποτελούν δουλειά του Josep Maria Subirachs. Η πρόσοψη της Δόξας, η οποία κατασκευάζεται από το 2002, θα είναι η " +
                    "μεγαλύτερη και η πιο μνημειώδης πρόσοψη καθώς θα εκπροσωπεί την ανάβαση προς τον Θεό. Θα απεικονίζει επίσης διάφορες σκηνές όπως η Κόλαση, το Καθαρτήριο\u00a0και θα περιλαμβάνει στοιχεία από τα Επτά " +
                    "Θανάσιμα Αμαρτήματα\u00a0\u00a0και τις Επτά Ουράνιες Αρετές.";
            }
            else if (enumTab == (int)Helper.enumTab.ParkoSioutantela)
            {
                text = "Το Παρκ ντε λα Σιουταντέλα είναι ένα πανέμορφο πάρκο στο κέντρο της πόλης όπου θα βρείτε καθαρό γρασίδι για να ξαπλώσετε και να απολαύσετε το ιστορικό " +
                    "συντριβάνι που σχεδίασε ο Josep Fontserè όπως και μία μικρή λίμνη.\nΣτο Πάρκο Σιουταντέλα βρίσκεται επίσης ο\u00a0ζωολογικός κήπος της πόλης, το Καταλανικό " +
                    "Κοινοβούλιο, καθώς και το Μουσείο Φυσικών Επιστημών.\nΗ ιστορία του πάρκου ξεκινάει κατά το 1714, έτος στο οποίο ο Βασιλιάς Φίλιππος Ε΄ της Ισπανίας " +
                    "πολιόρκησε και κατέκτησε την Βαρκελώνη. Όταν η πόλη έπεσε ο βασιλιάς διέταξε την δημιουργία ενός τεράστιου φρουρίου (στα Ισπανικά Ciudadela, Καταλανικά " +
                    "Ciutadella) για να αποτρέψει πιθανές επαναστάσεις από τους Καταλανούς. Ένα σημαντικό μέρος της πόλης καταστράφηκε για να βρεθεί ο χώρος για το φρούριο, " +
                    "αφήνοντας αρκετούς ντόπιους άστεγους. Το φρούριο έγινε σύμβολο μίσους της κεντρικής Ισπανικής κυβέρνησης και έτσι το 1841 έγινε μια πρώτη απόπειρα από της " +
                    "αρχές της πόλης για να το καταστρέψουν, απόπειρα που απέτυχε καθώς ενεπλάκη η τότε βασίλισσα Μαρία Χριστίνα και το 1848 οι ζημιές αποκαταστάθηκαν. Λίγο " +
                    "αργότερα όμως και καθώς το πολιτικό κλίμα είχε φιλελευθεροποίηθει αρκετά για να το επιτρέπει το φρούριο καταστράφηκε από δυο στρατηγούς, με την οριστική " +
                    "παράδοση του φρουρίου στης αρχές της πόλης το 1869.\nTo 1872 το φρούριο είχε πλέων μετατραπεί σε ένα πανέμορφο πάρκο, τα μοναδικά σημεία που θυμίζουν την " +
                    "ταραχώδη ιστορία του είναι ένα εκκλησάκι, το παλάτι του διοικητή που σήμερα είναι σχολείο δευτεροβάθμιας εκπαίδευσης και το οπλοστάσιο που σήμερα στεγάζει " +
                    "το Καταλανικό Κοινοβούλιο. Δεκαεννιά χρόνια αργότερα πραγματοποιήθηκε η Διεθνής Έκθεση του 1888 και το πάρκο ξανα-σχεδιάστηκε, με την πρόσθεση γλυπτών " +
                    "και άλλων συμπληρωματικών έργων τέχνης ενώ το 1892 προστέθηκε και ο ζωολογικός κήπος.\nTo Πάρκο Σιουταντέλα είναι συνυφασμένο με την ιστορία της πόλης, η " +
                    "μεταμόρφωση του σφράγισε την έναρξη μια νέας εποχής για την πόλη, από την οπισθοδρομική επαρχιακή Βαρκελώνη στη δημιουργία μιας σύγχρονης κοσμοπολίτικης πόλης." +
                    "/n/nTip: Πάρτε τον σύντροφό σας ή την οικογένειά σας και πηγαίνετε βαρκάδα στη λίμνη!";
            }
            else if (enumTab == (int)Helper.enumTab.PezodromosRampla)
            {
                text = "Η πολύβουη Ράμπλα είναι ένας πεζόδρομος στην καρδιά της Βαρκελώνης που συνδέει την πλατεία της Καταλονίας με το Άγαλμα του Χριστόφορου Κολόμβου στη θάλασσα. Το μήκος του πεζόδρομου είναι 1.2 χιλιόμετρα και αποτελεί την κλασική βόλτα των τουριστών και των ντόπιων.\nΗ Ράμπλα σκεπάζεται από πανέμορφα δέντρα σε όλο το μήκος της ενώ στην πραγματικότητα La Rambla ονομάζεται το σύμπλεγμα που αποτελείται από μια σειρά από μικρότερους δρόμους, της Rambla de Canaletes, Rambla dels Estudis, Rambla de Sant Josep, Rambla dels Caputxins και την Rambla de Santa Monica ενώ από τις αρχές του 1990 κατασκευάστηκε και η γέφυρα Rambla de Mar (Ράμπλα της θάλασσας) που συνδέει τον πεζόδρομο με το λιμάνι.\nΣε μία τυπική μέρα η Ράμπλα είναι γεμάτη με κόσμο και συνήθως οι τουρίστες είναι πολλοί περισσότεροι από τους ντόπιους. Πλήθος καλλιτεχνών κάνουν υπαίθριες παραστάσεις, μερικές από τις οποίες θα σας αφήσουν άφωνους με την πρωτοτυπία τους, ενώ επίσης άλλοι καλλιτέχνες θα αναλάβουν να δημιουργήσουν το πορτρέτο σας ή θα ζωγραφίσουν ένα τατουάζ. Προσοχή στους πορτοφολάδες, καθώς το πλήθος του κόσμου δίνει την κατάλληλη κάλυψη σε ελαφροχέρηδες.\nΔιάσημα αξιοθέατα της πόλης βρίσκονται επί του πεζόδρομου της Ράμπλα, κοντά στην\u00a0Πλατεία Καταλονίας\u00a0βρίσκεται ένα περίκομψο συντριβάνι του 19ου αιώνα, το Font de Canaletes που από το 1930 αποτελεί το σημείο συνάντησης των οπαδών της ποδοσφαιρικής ομάδας της Μπαρσελόνα πριν και κυρίως μετά τον αγώνα της αγαπημένης τους ομάδας. Κάπου στη μέση βρίσκεται η\u00a0Αγορά της Μποκερία\u00a0και η\u00a0Όπερα Λισέου, ενώ κοντά στη θάλασσα θα βρείτε το\u00a0Μουσείο Σύγχρονης Τέχνης της Αγίας Μόνικα. Τέλος μην παραλείψετε να βγάλετε μια φωτογραφία στο μπαρόκ παλάτι Palau de la Virreina.";
            }
            else if (enumTab == (int)Helper.enumTab.ParkGuel)
            {
                text = "Το Πάρκ Γκουέλ βρίσκεται στο λόφο \"el Carmel\" και είναι ένα δημόσιο πάρκο που σχεδιάστηκε από τον διάσημο αρχιτέκτονα Αντόνι Γκαουντί. Το πάρκο κατασκευάστηκε μεταξύ του 1900 με 1914 και άνοιξε επίσημος ως δημόσιο πάρκο το 1926.\nΠεριέχει δημιουργήματα του Γκαουντί όπως συντριβάνια με δράκους όλα διακοσμημένα με το πολύχρωμο μαρμάρινο μωσαϊκό που χαρακτηρίζει την πόλη της Βαρκελώνης.\nΜετά τη βασική είσοδο θα βρείτε ένα τεράστιο φυσικό μπαλκόνι όπου και μπορείτε να απολαύσετε τον καφέ σας με θέα σχεδόν όλη την πόλη της Βαρκελώνης. Μέσα στο πάρκο θα βρείτε ένα μικρό σπιτάκι στο οποίο ο ίδιος ο αρχιτέκτονας έχει μείνει σε κάποιο διάστημα της ζωής του.\nΚαθώς απολαμβάνετε τη βόλτα σας μέσα στο πάρκο θα βρείτε ερασιτέχνες μουσικούς που παίζουν ζωντανά μουσική ενώ η θέα προς την πόλη είναι μαγευτική.";
            }
            else if (enumTab == (int)Helper.enumTab.StadioKabNou)
            {
                text = "Το Στάδιο Καμπ Νου, προφέρετε σωστά στα καταλανικά ως Καμπ Νόου (Καινούργιο Γήπεδο), είναι η έδρα της ποδοσφαιρικής ομάδας της Βαρκελώνης. Κατασκευάστηκε το 1957, αντικαθιστώντας το παλιό γήπεδο Λες Κορτς (Camp de les Corts), ενώ η τελευταία ανακαίνιση ολοκληρώθηκε το 2008.\nΑνήκει στην κατηγορία elite της UEFA (5 αστέρια) και με χωρητικότητα 99.354 θεατές κατατάσσεται στη 10η θέση παγκοσμίως. Το Καμπ Νου είναι ένας ναός του ποδοσφαίρου για τους φίλους του δημοφιλούς αθλήματος και αποτελεί και σημαντικό τουριστικό αξιοθέατο. Μπορείτε να επισκεφτείτε το στάδιο είτε παρακολουθώντας έναν αγώνα της Μπαρτσελόνα κάτι που είναι δύσκολο καθώς τα περισσότερα εισιτήρια προπωλούνται από την αρχή της χρονιάς και στην μαύρη αγορά είναι αρκετά ακριβά, είτε μέσω της περιήγησης στο στο μουσείο της ομάδας που περιλαμβάνει και επίσκεψη σε διάφορα σημεία του γηπέδου.";
            }
            else if (enumTab == (int)Helper.enumTab.Naos)
            {
                text = "Ο τεράστιος Γοτθικός Καθεδρικός του Τιμίου Σταυρού και της Αγίας Ευλαλίας είναι η έδρα του Αρχιεπίσκοπου της Βαρκελώνης και βρίσκεται στην καρδιά της παλιάς πόλης.\nΧτίστηκε μεταξύ του 13ου και 15ου αιώνα και είναι αφιερωμένος στην Ουλάλια της Βαρκελώνης, μία από τους πάτρωνες της πόλης. Η Ευλάλια ήταν μια νεαρή παρθένα που σύμφωνα με την Καθολική παράδοση υπέφερε μαρτύρια κατά τη Ρωμαϊκή εποχή. Τα λείψανα της Αγίας Ευλάλια βρίσκονται στην κρύπτη του καθεδρικού.\nΣτην είσοδο του ναού θα βρείτε μια μικρή πλατεία όπου πλανόδιοι καλλιτέχνες εκτελούν τα έργα τους.\nWIKIPEDIA\nκαταλανικά:\u00a0Catedral de la Santa Creu i Santa Eulàlia‎\nΟ καθεδρικός είναι αφιερωμένος στην Ευλάβια της Βαρκελώνης, πολιούχου της Βαρκελώνης, μια νεαρή παρθένα, η οποία, σύμφωνα με την καθολική παράδοση, μαρτύρησε κατά τη διάρκεια των ρωμαϊκών χρόνων στην πόλη. Μια ιστορία αναφέρει ότι παρουσιάστηκε γυμνή σε μια δημόσια πλατεία και ως εκ θαύματος μια χιονόπτωση στα μέσα της άνοιξης κάλυψε την γύμνια της. Οι εξοργισμένοι Ρωμαίοι την έβαλαν σε ένα βαρέλι με μαχαίρια κολλημένα μέσα του και το έβαλαν να κατρακυλλά στο δρόμο (σύμφωνα με την παράδοση αυτή που σήμερα αποκαλείται Μπαϊσάδα δε Σάντα Ευλάλια. Το σώμα της αγίας Ευλαλίας είναι ενταφιεσμένο στην κρύπτη του καθεδρικού.\nΈνα από τα παρεκκλήσια, αφιερωμένο στον Χριστό του Λεπάντο, περιέχει ένα σταυρό από ένα πλοίο το οποίο πολέμησε στη ναυμαρχία της Ναυπάκτου\u00a0(1571). Ένας καταλανικός μύθος αναφέρει ότι κατά τη διάρκεια της μάχης, το σώμα ως εκ θαύματος έστριψε ξαφνικά στα δεξιά ώστε να αποφύγει μία μπάλα κανονιού, ένα σημάδι από το Θεό ότι οι Οθωμανοί θα ηττηθούν. Το παρεκκλήσι του Χριστού του Λεπάντο περιλαμβάνει επίσης ένα ιερό και το τάφο του αγίου Οληγάριου, ο οποίος ήταν επίσκοπος Βαρκελώνης και αρχιεπίσκοπος της Ταρραγόνα. Ο καθεδρικός έχει ένα περίκλειστο γοτθικό πλευρικό διάδρομο όπου φυλάσσονται 13 λευκές χήνες, ένας αριθμός που εξηγείται από την εκτίμηση ότι η Ευλάλια ήταν 13 όταν μαρτύρησε.";
            }
            else if (enumTab == (int)Helper.enumTab.KazaBatlo)
            {
                text = "Το Κάζα Μπατλό (Casa Batlló) χτίστηκε το 1877 και ανακαινίστηκε από τον διάσημο αρχιτέκτονα Αντόνι Γκαουντί το 1904.\nΑρχικά ήταν ένα κλασικό κτίριο χωρίς κάτι αξιοσημείωτο σύμφωνα με την παράδοση του εκλεκτισμού του 19ου αιώνα. Το σπίτι βρίσκεται σε μια πάρα πολύ κεντρική τοποθεσία της πόλης, στην μέση της λεωφόρου Passeig de Gràcia και αγοράστηκε το 1900 από την οικογένεια Μπατλό, οι οποίοι και ανέθεσαν στον Γκαουντί να το επανασχεδιάσει ώστε να δημιουργήσει κάτι που να τραβάει την προσοχή -χωρίς κάποιο όριο στον σχεδιασμό. Το Κάζα Μπατλό ανακατασκευάστηκε με της τεχνικές του μοντερνισμού και αρτ νουβό και ξεπέρασε κάθε εκκεντρικότητα, οι ντόπιοι το ονομάζουν και Σπίτι των Οστών λόγο της εμφάνισης του.\nΤο σπίτι Μπατλό είναι σήμερα ένα από τα σημαντικότερα αξιοθέατα της πόλης μαζί με το άλλο διάσημο σπίτι που σχεδίασε ο Γκαουντί, το\u00a0Κάζα Μιλά.";
            }
            else if (enumTab == (int)Helper.enumTab.MouseioEthnikisTexnis)
            {
                text = "Το Μουσείο Εθνικής Τέχνης της Καταλονίας (συντομογραφία MNAC) βρίσκεται στον λόφο Μονζουίκ, στο τέλος της λεωφόρου Reina Maria Cristina, κοντά στην " +
                    "Πλατεία Ισπανίας. Το μουσείο είναι από τα σημαντικότερα μουσεία της Ισπανίας και είναι ιδιαιτερα γνωστό για την καταπληκτική του συλλογή από " +
                    "εκκλησιαστικούς πίνακες Ρομανικής τεχνοτροπίας καθώς και για την συλλογή Καταλανικών έργων τέχνης, από τα τέλη του 19ου με αρχές του 20ου αιώνα.\nΤο μουσείο " +
                    "στεγάζεται σε ένα τεράστιο, Ιταλικού αρχιτεκτονικού στυλ, κτίριο που ονομάζεται Παλάου Νασιονάλ (στα Καταλανικά σημαίνει \"Εθνικό Παλάτι\"). Το Παλάου " +
                    "Νασιονάλ κατασκευάστηκε για της ανάγκες της Διεθνής Έκθεσης του 1929 ενώ στεγάζει το μουσείο τέχνης της Καταλονίας από το 1934. Το 1990 το μουσείο " +
                    "χαρακτηρίστηκε ως εθνικής σημασίας και ξεκίνησε μια μεγάλη ανακαίνιση και αναβάθμιση η οποία ουσιαστικά ολοκληρώθηκε το 2004.\nTip: Μπορείτε να ανέβετε στην " +
                    "ταράτσα του μουσείου όπου θα απολαύσετε μια υπέροχη θέα της πόλης.";
            }
            else if (enumTab == (int)Helper.enumTab.ParaliaBarcheloneta)
            {
                text = "Η Μπαρτελονέτα βρίσκεται στην ομώνυμη γειτονιά της παλιάς πόλης (Ciutat Vella). Η παραλία έγινε πολύ διάσημη μετά την ανάδειξή της ως η 'καλύτερη αστική παραλία του κόσμου' από ένα ντοκιμαντέρ για τις καλύτερες παραλίες από το Discovery Channel το 2005.\nΑυτό που κάνει την παραλία να ξεχωρίζει είναι η χρυσαφένια άμμος της και τα εξαιρετικά εστιατόρια που βρίσκονται στην παραλιακή ζώνη μαζί με το μεγάλο πεζόδρομο που τους καλοκαιρινούς μήνες γίνεται το αδιαχώρητο. Στη Μπαρτελονέτα βρίσκονται επίσης μερικά από τα πιο γνωστά club για νυχτερινή διασκέδαση.\nΔεν είναι όμως και η μοναδική παραλία καθώς υπάρχουν 4.2 χμ. από παραλίες σε απόσταση ως 10 λεπτά από το κέντρο της πόλης. Άλλες παραλίες είναι οι Icaria Beach, Mar Bella Beach (παραλία γυμνιστών) και Sitges Beaches.";
            }
            else if (enumTab == (int)Helper.enumTab.AgoraBokeria)
            {
                text = "Η αγορά της Μποκερία είναι μια μεγάλη ανοιχτή αγορά και βρίσκεται στη μέση περίπου του μεγάλου πεζόδρομου Rambla κοντά στην όπερα της πόλης (Liceu) στην " +
                    "περιοχή Ciutat Vella. Η αγορά αποτελεί σημαντικό τουριστικό αξιοθέατο καθώς βρίσκεται και στην καρδιά της τουριστικής ζωής της πόλης.\nΣτην Αγορά της Μποκερία " +
                    "θα βρείτε φρούτα και λαχανικά, ψάρια και θαλασσινά, ισπανικά σαλάμια και τυροκομικά. Ακόμα και αν δεν ενδιαφέρεστε να αγοράσετε κάτι όμως μην παραλείψετε να " +
                    "γνωρίσετε τα τάπας μπαρ (μεζεδομπάρ) της Μποκερία. Αυτά τα μαγαζιά είναι οικογενειακές επιχειρήσεις όπου η μαμά, ο μπαμπάς και τα παιδιά δημιουργούν και " +
                    "σερβίρουν παραδοσιακά Καταλονικά πιάτα με τάπας (μεζέδες), ενώ οι πελάτες τα απολαμβάνουν σε μια μπάρα που παραπέμπει σε νυχτερινά μπαρ.\nΗ ιστορία της Μποκερία " +
                    "ανάγεται από το 1217 όταν αναφέρεται ότι εγκαταστάθηκαν οι πρώτοι πάγκοι που πουλούσαν κρέας. Για αιώνες η αγορά λειτουργούσε ημι-παράνομα χωρίς κάποια " +
                    "εγκατάσταση ενώ μέσα στα χρόνια εμπλουτίζονταν από νέα προϊόντα όπως ζωντανά ζώα και ψάρια. Αρκετά χρόνια αργότερα και συγκεκριμένα το 1826, η αγορά " +
                    "αναγνωρίστηκε επισήμως και το 1840 ξεκίνησε η κατασκευή του κτιρίου που τη στεγάζει. Το 1853 έγιναν τα εγκαίνια ενώ η μεταλλική σκεπή κατασκευάστηκε το " +
                    "1914./nTip: Εάν θέλετε να απολαύσετε τη βόλτα σας περισσότερο, επισκεφτείτε την αγορά μέχρι τη 1μμ καθώς αργότερα πλημμυρίζει από κόσμο.";
            }
            else if (enumTab == (int)Helper.enumTab.Ispanikoxorio)
            {
                text = "Το Ισπανικό Χωριό είναι ένα ανοιχτό μουσείο αρχιτεκτονικού και πολιτιστικού ενδιαφέροντος που βρίσκεται στο λόφο του Μονζουίκ πολύ κοντά στο Palau Nacional.  Αποτελείται από κτίρια από όλα τα μέρη της Ισπανίας με σκοπό να μπορεί ο επισκέπτης να θαυμάσει σε ένα μέρος το διαφορετικό στυλ, την αρχιτεκτονική και την κουλτούρα της κάθε τοποθεσίας, από το μεσογειακό νότο της Ανδαλουσίας στο βορρά της Γαλικίας, της Βασκονίας και της Καταλονίας με όλες τις ενδιάμεσες περιοχές της ηπειρωτικής Ισπανίας. Οι αρχιτέκτονες Francesc Folguera και Ramon Reventós κατασκεύασαν το χωριό σε 13 μήνες. Περιλαμβάνει 117 κτίρια σε μια έκταση 42.000 τ.μ. με δρόμους, πλατείες, εκκλησίες, θέατρο και εστιατόρια.";
            }
            else if (enumTab == (int)Helper.enumTab.Enudreio)
            {
                text = "Το Ενυδρείο της Βαρκελώνης είναι το μεγαλύτερο θαλάσσιο πάρκο της Μεσογείου και το δεύτερο μεγαλύτερο στον κόσμο. Στεγάζεται σε ένα πολύ όμορφο κτίριο στο οποίο φιλοξενούνται τα πλέον αντιπροσωπευτικά είδη της θαλάσσιας ζωής.\nΈχει 35 δεξαμενές, 450 διαφορετικά είδη ψαριών και θαλάσσιων φυτών, και ένα\u00a0τούνελ μήκους 80 μέτρων, όπου καρχαρίες και σκυλόψαρα κάνουν τη βόλτα τους πάνω από τα κεφάλια των επισκεπτών! Επίσης, για τους πιο τολμηρούς, με τη βοήθεια δυτών και εκπαιδευτών μπορείτε να βουτήξετε στη δεξαμενή με τους καρχαρίες και να βρεθείτε σε απόσταση αναπνοής με τα απίστευτα αυτά ψάρια.";
            }
            else if (enumTab == (int)Helper.enumTab.PlateiaKatalonias)
            {
                text = "Η Πλατεία Καταλονίας θεωρείται το κέντρο της πόλης αλλά αποτελεί και την καρδιά των συγκοινωνιών. Μερικές από τις σημαντικότερους λεωφόρους της πόλης, όπως οι Passeig de Gràcia, Rambla de Catalunya αλλά και ο πεζόδρομος La Rambla, διέρχονται από την πλατεία.\nΚαταλαμβάνει περίπου 50,000 τ.μ. και είναι διάσημη για τα συντριβάνια και τα αγάλματα της. Αποτελεί επίσης και το κέντρο της τουριστικής ζωής της πόλης ενώ είναι συνέχεια γεμάτη από περιστέρια. Η δημιουργία της ξεκίνησε στις αρχές του 20 αιώνα μετά την καταστροφή των τειχών της παλιάς πόλης.\nΣτα κτίρια που περιβάλουν την πλατεία της Καταλωνίας περιλαμβάνονται θέατρα, κεντρικά τραπεζών, εμπορικά κέντρα (εδώ θα βρείτε ένα τεράστιο εμπορικό κέντρο της διάσημης Ισπανικής El Corte Inglés), ξενοδοχεία και, φυσικά, εστιατόρια και καφετέριες όπως το ιστορικό Café Zurich.";
            }
            else if (enumTab == (int)Helper.enumTab.MnimeioKolombou)
            {
                text = "Το μνημείο αυτό είναι, όπως εύκολα φαίνεται από το όνομα του, αφιερωμένο στον διάσημο ερευνητή Χριστόφορο Κολόμβο που ανακάλυψε την Αμερική.\nΒρίσκεται στο τέλος του πεζόδρομου La Rambla και είναι ένας " +
                	"χάλκινος στύλος Κορινθιακού ρυθμού 60 μέτρων με ένα άγαλμα του Κολόμβου στην κορυφή. Στη βάση του μνημείου βρίσκονται τέσσερα αγάλματα της θεάς Νίκης που ετοιμάζονται να πετάξουν στις τέσσερις άκρες του " +
                	"κόσμου και αγάλματα με ζευγάρια από γυπαετούς ενώ στο οκτάγωνο βάθρο βρίσκονται αναπαραστάσεις από ανθρώπους σχετικούς με τον Κολόμβο και το ταξίδι του.\nΤο σημείο που στέκεται σήμερα το Μνημείο του Κολόμβου " +
                	"είναι το σημείο που επέστρεψε ο Κολόμβος μετά το πρώτο ταξίδι του στην Αμερικάνικη ήπειρο και κατέθεσε την αναφορά του για το ταξίδι στη Βασίλισσα Ιζαμπέλα.";
            }
            else if (enumTab == (int)Helper.enumTab.KazaMila)
            {
                text = "Το Κάζα Μιλά (Casa Milà), είναι γνωστό και ως \"Λα Πεδρέρα\" (La Pedrera) που σημαίνει στα καταλανικά \"το λατομείο\". Σχεδιάστηκε μεταξύ του 1906 με 1910 και ολοκληρώθηκε το 1912 για να χρησιμοποιηθεί ως κατοικία για την εύπορη οικογένεια Μιλά.\nΤο Πεδρέρα στεγάζει σήμερα ένα μουσείο αφιερωμένο στον Γκαουντί, το εκθεσιακό κέντρο του Καϊσα ντε Καταλούνια, ένα επιπλωμένο διαμέρισμα μουσείο, καθώς και ιδιωτικές κατοικίες που κατοικούνται από απογόνους των αρχικών κατοίκων.\nΥπάρχουν και άλλα σπίτια (πιο συντηρητικά) που σχεδίασε o διάσημος Καταλανός αρχιτέκτονας, όπως το\u00a0Casa Vicens\u00a0που ήταν και το πρώτο σημαντικό έργο του ή το\u00a0Casa Calvet, που όμως δεν έχουν το ίδιο τουριστικό ενδιαφέρων με τα Κάζα Μπατλό και Κάζα Μιλά.";
            }
            else if (enumTab == (int)Helper.enumTab.lofosMonzouik)
            {
                text = "Σε ελεύθερη μετάφραση ο λόφος του Μονζουίκ σημαίνει 'λόφος των Εβραίων' ή 'λόφος του Δία'. Ο λόφος είναι ένα από τα πιο χαρακτηριστικά σημεία της πόλης. Το ύψος του λόφου είναι 173 μέτρα και στο παρελθόν χρησιμοποιήθηκε ως φρούριο, φυλακές καθώς και ως κήπος για παραγωγή φαγητού για ζώα και ανθρώπους.\nΗ παγκόσμια έκθεση του 1929 έγινε η αφορμή για την πρώτη μεταμόρφωση του λόφου. Τότε φτιάχτηκε το Palau Nacional που σήμερα στεγάζει το\u00a0Μουσείο Εθνικής Τέχνης της Καταλονίας, το Ολυμπιακό Στάδιο, το συντριβάνι Font Màgica και τα επιβλητικά σκαλιά που ενώνουν το παλάτι Palau Nacional με την λεωφόρο της βασίλισσας Maria Cristina. Στο δυτικό κομμάτι του λόφου βρίσκεται το\u00a0Ανοιχτό Μουσείο «Ισπανικό Χωριό», μια σειρά από παραδοσιακά κτίρια, το καθένα με ξεχωριστή αρχιτεκτονική από όλα τα μέρη της χώρας. Στους πρόποδες του λόφου βρίσκεται το Γερμανικό κτίριο του Mies van der Rohe's που κατασκευάστηκε για τις ανάγκες της έκθεσης και κατεδαφίστηκε μόλις έναν χρόνο αργότερα για να ξαναχτιστεί τελικά το 1988.\nΟ λόφος του Μονζουίκ με το Ολυμπιακό Στάδιο αποτελούσε την καρδιά των Ολυμπιακών αγώνων του 1992. Το στάδιο ανακαινίστηκε ολοκληρωτικά και γύρω από αυτό δημιουργήθηκαν και άλλα στάδια που αποτελούσαν τον Ολυμπιακό Κύκλο.";
            }
            else if (enumTab == (int)Helper.enumTab.BarioGkotiko)
            {
                text = "Πρόκειται για την πιο ιστορική περιοχή της Βαρκελώνης, που υπάρχει από τη Ρωμαϊκή Εποχή. Βρίσκεται ανάμεσα στους διάσημους δρόμους της πόλης Las Ramblas και Via Laietana, την Πλατεία Καταλονίας στην κορυφή και το λιμάνι της πόλης στο κάτω μέρος.\nΑποτελείται από μεσαιωνικά κτίρια, με τη γοτθική αρχιτεκτονική να αποτυπώνεται σε όλα τα καφέ και εστιατόρια της περιοχής, καθώς και στα καταστήματα που βρίσκονται εκεί, στην πλειοψηφία τους αντικερί και καταστήματα ομπρελών.\nΗ Γοτθική Συνοικία μοιάζει με λαβύρινθο και έχει αρκετές ήσυχες γωνιές όπου μπορείτε να χαλαρώσετε. Στο κέντρο της δεσπόζει ο Καθεδρικός Ναός της Σάντα Εουλάλια που χτίστηκε το 1450, ενώ ένα ακόμη σημαντικό αξιοθέατο της περιοχής είναι το Ρωμαϊκό Μουσείο.\nΚάθε Κυριακή πρωί έξω από το Δημαρχείο χορεύεται η Sardana, ο εθνικός χορός των Καταλανών. Αξίζει να βρεθείτε στη συνοικία εκείνη τη στιγμή. Η συνοικία Μπάριο Γκότικο είναι ένα αγαπημένο αξιοθέατο των επισκεπτών της Βαρκελώνης, χάρη στην αξιόλογη αρχιτεκτονική της και τα σπουδαίας ιστορικής σημασίας κτίρια που φιλοξενεί.";
            }
            else if (enumTab == (int)Helper.enumTab.MouseioPikaso)
            {
                text = "Το Μουσείο του Πικάσο αποτελεί τη μεγαλύτερη συλλογή έργων τέχνης (4.249 έργα) του διάσημου ζωγράφου. Τα έργα είναι τοποθετημένα με χρονολογική σειρά από τα πρώτα έργα του Πικάσο μέχρι τα τελευταία πράγμα που δίνει την δυνατότητα στον επισκέπτη να δει την πρόοδο και την αλλαγή στην σκέψη του Πικάσο μέσα στην καλλιτεχνική του πορεία.\nΤο Μουσείο Πικάσο της Βαρκελώνης άνοιξε για το κοινό στις 9 Μαρτίου το 1963 και ήταν τότε το πρώτο μουσείο αφιερωμένο στον διάσημο ζωγράφο. Στην συλλογή του περιλαμβάνει δυο από τα πρώτα πολύ διάσημα έργα του καλλιτέχνη, το First Communion (1896) και το Science and Charity (1897).\nΗ μόνιμη συλλογή είναι οργανωμένη σε τρία τμήματα: τη ζωγραφική και το σχέδιο, την χαρακτική, και τα κεραμικά ενώ περιλαμβάνει πάνω από 3.500 έργα. Το μουσείο έχει πραγματοποιήσει και δεκάδες περιοδικές εκθέσεις, για την σχέση του Πικάσο με άλλους καλλιτέχνες της εποχής του ή με αναλύσεις για την τέχνη και τα νοήματα που προκύπτουν από τα έργα του.";
            }
            else if (enumTab == (int)Helper.enumTab.MagikoSintrivani)
            {
                text = "Το Μαγικό Συντριβάνι είναι κάτι που ίσως δεν πρέπει να χάσετε κατά την επίσκεψή σας στην Βαρκελώνη. Σχεδιάστηκε το 1928 από τον Carles Buïgas και πρόκειται " +
                    "για ένα συντριβάνι, το οποίο όμως για μια ώρα το βράδυ μετατρέπεται σε ένα πραγματικό υπερθέαμα!\n\nΤο νερό, χάρη σε ειδικούς φωτισμούς, παίρνει χρώμα και " +
                    "πληθώρα μουσικών ειδών αναπαράγονται εκπλήσοντας ευχάριστα κάθε επισκέπτη, με δυνατότητα 7 δισεκατομμυρίων συνδυασμών φωτός και χρωμάτων!\n\nΗ διαδρομή μέχρι " +
                    "εκεί είναι επίσης πολύ ενδιαφέρουσα, καθώς είναι ένας πεζόδρομος γεμάτος με μικρά πολύχρωμα μουσικά συντριβάνια.\n\nTip: Εάν θέλετε να απολαύσετε όλο το " +
                    "θέαμα, καλό είναι να πάτε μισή ώρα νωρίτερα ώστε να βρείτε θέση στα σκαλιά καθώς μαζεύει πάρα πολύ κόσμο.";
            }
            else if (enumTab == (int)Helper.enumTab.ParkoLaburinthou)
            {
                text = "Το Πάρκο του Λαβυρίνθου της Όρτα είναι ένας κήπος στο κτήμα του τότε μαρκήσιου Αντόνι Δεσβάλς. Απλώνεται σε έκταση μεγαλύτερη των 70 στρεμμάτων και " +
                    "στην πραγματικότητα πρόκειται για δυο κήπους, τον νεοκλασικό και τον ρομαντικό.\n\nΣτην είσοδο βρίσκεται το παλάτι του μαρκήσιου και ένα παρατηρητήριο. " +
                    "Το βασικό όμως στοιχείο είναι ο λαβύρινθος που υπάρχει, ύψους δυο μέτρων, ο οποίος προκαλεί τους επισκέπτες να τον διασχίσουν. Στο κέντρο του βρίσκεται " +
                    "ένα άγαλμα του Θεού Έρωτα ενώ στην έξοδό του η Ηχώ, η νύμφη των δασών. Γλυπτά υπάρχουν σε όλο τον κήπο. Για ηρεμία και χαλάρωση προσφέρεται ιδιαίτερα " +
                    "το ρομαντικό κομμάτι του, το οποίο έχει πλούσια βλάστηση με τεράστια δέντρα και έναν καταρράκτη!\n\nTip: Τις Κυριακές η είσοδος στο πάρκο είναι δωρεάν.";
            }
            else if (enumTab == (int)Helper.enumTab.ApsidaTouThriambou)
            {
                text = "Η Αψίδα του Θριάμβου της Βαρκελώνης είναι μια αψίδα που ξεχωρίζει από πολλές άλλες ευρωπαϊκές λόγω του χρώματός της, το μπορντό. Φτιαγμένη από τούβλα, " +
                    "χτίστηκε το 1888 με σκοπό να αποτελέσει την πύλη για την Παγκόσμια Έκθεση που φιλοξένησε η Βαρκελώνη εκείνη τη χρονιά.\n\nΟ αρχιτέκτονάς της Josep Vilaseca " +
                    "τη σχεδίασε με κλασικό στιλ και αναλογίες, ως αλληγορία για το σεβασμό της Βαρκελώνης προς τα έθνη και τις επαρχίες που έλαβαν μέρος στην έκθεση. Στα πλαϊνά " +
                    "της υπάρχουν γλυπτά, τα οποία μεταξύ άλλων συμβολίζουν τη γεωργία, την επιστήμη, τις τέχνες, το εμπόριο και τη βιομηχανία.\n\nTip: Μπορείτε να συνδυάσετε την " +
                    "επίσκεψή σας με βόλτα στο πάρκο Σιουταντέλα, το οποίο βρίσκεται λίγο παρακάτω. Εκεί θα σας οδηγήσει ένας πεζόδρομος γεμάτος φοίνικες, και αν είστε τυχεροί, " +
                    "μπορεί να πετύχετε τα πράσινα παπαγαλάκια που λέγεται ότι πετάνε από δέντρο σε δέντρο!";
            }
            else if (enumTab == (int)Helper.enumTab.MouseioCosmocaixa)
            {
                text = "Το μουσείο CosmoCaixa είναι ένα μουσείο φυσικής ιστορίας με προσωρινές και μόνιμες εκθέσεις που αφορούν στη φύση, στο διάστημα, στην επιστήμη και στο " +
                    "περιβάλλον. Το πιο ενδιαφέρον για το μουσείο αυτό όμως είναι ότι μπορεί να γίνει και διαδραστικό! Για παράδειγμα, υπάρχει προσομοίωση του δάσους του " +
                    "Αμαζονίου σε απόλυτα τροπικό κλίμα με την αντίστοιχη υγρασία, θερμοκρασία και τεχνητές βροχές αλλά και με την αναμενόμενη πανίδα και χλωρίδα!\n\nΧάρη " +
                    "στη φιλοσοφία του, η επιστήμη μπορεί να γίνει προσιτή σε όλους αγγίζοντας, παίζοντας και διαδρώντας με τα εκθέματα. Πήρε τον τίτλο του Ευρωπαϊκού Μουσείου " +
                    "Της Χρονιάς το 2006.\n\nTip: Στο χώρο υπάρχει επίσης ενυδρείο, βοτανικός κήπος και ένα πλανητάριο, για τις ώρες λειτουργίας του οποίου πρέπει να έχετε " +
                    "ενημερωθεί προηγουμένως.";
            }
            else if (enumTab == (int)Helper.enumTab.Tsimpidampo)
            {
                text = "Το Τιμπιδάδο είναι ένα βουνό-λόφος ύψους 512 μέτρων με θέα της πόλης και της γύρω ακτογραμμής. Στο Τιμπιδάμπο υπάρχει ο Ναός της Ιερής Καρδιάς του Ιησού, " +
                    "με μια εμφάνιση πολύ επιβλητική, γεμάτη με γλυπτά και λεπτομέρειες, σε ρυθμό νεογοτθικό.\n\nΥπάρχει επίσης και ένα πάρκο, σαν λούνα παρκ, με παιχνίδια για " +
                    "μικρούς και μεγάλους. Όποιος θέλει μπορεί να απολαύσει τον καφέ ή το φαγητό του με θέα την πόλη της Βαρκελώνης. Μπορείτε να φτάσετε εκεί με τρενάκι, τελεφερίκ " +
                    "ή λεωφορείο.";
            }

            return text;
        }

        public static string GetImageTitle(Helper.enumImages enumImage)
        {
            string text = string.Empty;

            if (enumImage == Helper.enumImages.SagradaFamilia)
            {
                text = "Η πρόσοψη της Γέννησης";
            }
            else if (enumImage == Helper.enumImages.SagradaFamiliaPathon)
            {
                text = "Η πρόσοψη της Παθών (2010)";
            }

            return text;
        }

        public static int GetImage(Helper.enumImages enumImage)
        {
            int drawable = 0;

            if (enumImage == Helper.enumImages.SagradaFamilia)
            {
                drawable = Resource.Drawable.SagradaFamilia;
            }
            else if (enumImage == Helper.enumImages.SagradaFamiliaPathon)
            {
                drawable = Resource.Drawable.SagradaFamiliaPathon;
            }

            return drawable;
        }

        public static string GetPosition(int enumTab)
        {
            var result = string.Empty;

            if (enumTab == (int)Helper.enumTab.SagradaFamilia)
            {
                result = "geo:0,0?q=la+sagrada+familia+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.ParkoSioutantela)
            {
                result = "geo:0,0?q=ciutadella+park+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.PezodromosRampla)
            {
                result = "geo:0,0?q=la+rambla+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.ParkGuel)
            {
                result = "geo:0,0?q=park+guell+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.StadioKabNou)
            {
                result = "geo:0,0?q=camp+nou+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.Naos)
            {
                result = "geo:0,0?q=cathedral+of+barcelona+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.KazaBatlo)
            {
                result = "geo:0,0?q=casa+batllo+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.MouseioEthnikisTexnis)
            {
                result = "geo:0,0?q=museu+nacional+d+art+de+catalunya+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.ParaliaBarcheloneta)
            {
                result = "geo:0,0?q=la+barceloneta+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.AgoraBokeria)
            {
                result = "geo:0,0?q=mercado+de+la+boqueria+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.Ispanikoxorio)
            {
                result = "geo:0,0?q=poble+espanyol+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.Enudreio)
            {
                result = "geo:0,0?q=aquarium+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.PlateiaKatalonias)
            {
                result = "geo:0,0?q=placa+de+catalunya+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.MnimeioKolombou)
            {
                result = "geo:0,0?q=columbus+monument+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.KazaMila)
            {
                result = "geo:0,0?q=casa+mila+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.lofosMonzouik)
            {
                result = "geo:0,0?q=montjuic+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.BarioGkotiko)
            {
                result = "geo:0,0?q=gothic+quarter+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.MouseioPikaso)
            {
                result = "geo:0,0?q=picasso+museum+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.MagikoSintrivani)
            {
                result = "geo:0,0?q=magic+fountain+of+montjuic+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.ParkoLaburinthou)
            {
                result = "geo:0,0?q=park+del+laerint+d+horta+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.ApsidaTouThriambou)
            {
                result = "geo:0,0?q=arc+de+triomf+de+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.MouseioCosmocaixa)
            {
                result = "geo:0,0?q=cosmocaixa+science+museum+barcelona";
            }
            else if (enumTab == (int)Helper.enumTab.Tsimpidampo)
            {
                result = "geo:0,0?q=tibidabo+barcelona";
            }

            return result;
        }

        public static string GetPrice(Helper.enumTab enumTab)
        {
            string text = string.Empty;

            if (enumTab == Helper.enumTab.SagradaFamilia)
            {
                text = "30,60";
            }
            else if (enumTab == Helper.enumTab.ParkoSioutantela)
            {
                text = "";
            }
            else if (enumTab == Helper.enumTab.StadioKabNou)
            {
                text = "28";
            }
            else if (enumTab == Helper.enumTab.MouseioEthnikisTexnis)
            {
                text = "12";
            }
            else if (enumTab == Helper.enumTab.Enudreio)
            {
                text = "21";
            }
            else if (enumTab == Helper.enumTab.ParkGuel)
            {
                text = "12,90";
            }
            else if (enumTab == Helper.enumTab.KazaBatlo)
            {
                text = "25";
            }
            else if (enumTab == Helper.enumTab.KazaMila)
            {
                text = "25";
            }
            else if (enumTab == Helper.enumTab.DaliTheater)
            {
                text = "16";
            }
            else if (enumTab == Helper.enumTab.MouseioPikaso)
            {
                text = "25";
            }

            return text;
        }

        public static string GetLink(Helper.enumTab enumTab)
        {
            string text = string.Empty;

            if (enumTab == Helper.enumTab.SagradaFamilia)
            {
                text = "https://www.tiqets.com/en/barcelona-c66342/sagrada-familia-fast-track-p918256";
            }
            else if (enumTab == Helper.enumTab.StadioKabNou)
            {
                text = "https://www.tiqets.com/en/barcelona-c66342/camp-nou-experience-p974062";
            }
            else if (enumTab == Helper.enumTab.MouseioEthnikisTexnis)
            {
                text = "https://www.tiqets.com/en/barcelona-c66342/museu-nacional-dart-de-catalunya-skip-the-line-rooftop-access-p974918";
            }
            else if (enumTab == Helper.enumTab.Enudreio)
            {
                text = "https://www.tiqets.com/en/barcelona-c66342/barcelona-aquarium-skip-the-line-p703295";
            }
            else if (enumTab == Helper.enumTab.ParkGuel)
            {
                text = "https://www.tiqets.com/en/barcelona-c66342/park-guell-p973888";
            }
            else if (enumTab == Helper.enumTab.KazaBatlo)
            {
                text = "https://www.tiqets.com/en/barcelona-c66342/casa-batllo-blue-p973672";
            }
            else if (enumTab == Helper.enumTab.KazaMila)
            {
                text = "https://www.tiqets.com/en/barcelona-c66342/la-pedrera-essential-skip-the-line-p973460";
            }
            else if (enumTab == Helper.enumTab.DaliTheater)
            {
                text = "https://www.tiqets.com/en/figueres-c66292/dali-theatre-museum-skip-the-line-p978141";
            }
            else if (enumTab == Helper.enumTab.MouseioPikaso)
            {
                text = "https://www.tiqets.com/en/barcelona-c66342/picasso-walking-tour-picasso-museum-skip-the-line-p977198";
            }

            return text;
        }
    }
}
