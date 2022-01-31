using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Barcelona.UI;

namespace Barcelona
{
    [Activity(Label = "Barcelona", MainLauncher = true, Icon = "@drawable/first")]
    public class MainActivity : Activity
    {
        Button naosButton, paraliaButton, ispanikoXorioButton, mnimeioKolombouButton, lofosMonzouikButton, mparioGotikoButton;

        ImageButton sagradaFamilia, casaBatlo, agora, casaMila, magikoSintrivani, mouseioPikaso, mouseioTexnis, parko, parkoLaburinthou, campNou, parkoGuel, plateiaKatalonias;
        ImageButton menuApsida, mouseioCosmocaisa, tsimpidampo, enudreio, rambla;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            InitializeLayout();

            ShowCountdown();
        }

        private void InitializeLayout()
        {
            #region hide
            naosButton = FindViewById<Button>(Resource.Id.button_Naos);
            paraliaButton = FindViewById<Button>(Resource.Id.button_ParaliaBarcheloneta);
            ispanikoXorioButton = FindViewById<Button>(Resource.Id.button_Ispanikoxorio);
            mnimeioKolombouButton = FindViewById<Button>(Resource.Id.button_MnimeioKolombou);
            lofosMonzouikButton = FindViewById<Button>(Resource.Id.button_lofosMonzouik);
            mparioGotikoButton = FindViewById<Button>(Resource.Id.button_BarioGkotiko);

            naosButton.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.Naos, "Γοτθικός Καθεδρικός Ναός της Βαρκελώνης");
            };
            paraliaButton.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.ParaliaBarcheloneta, "Παραλία Μπαρτσελονέτα");
            };
            ispanikoXorioButton.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.Ispanikoxorio, "Ανοιχτό Μουσείο “Ισπανικό Χωριό”");
            };
            mnimeioKolombouButton.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.MnimeioKolombou, "Μνημείο του Κολόμβου");
            };
            lofosMonzouikButton.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.lofosMonzouik, "Λόφος Μονζουίκ");
            };
            mparioGotikoButton.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.BarioGkotiko, "Γοτθική Συνοικία “Μπάριο Γκότικο”");
            };
            #endregion

            sagradaFamilia = FindViewById<ImageButton>(Resource.Id.button_image1);
            sagradaFamilia.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.SagradaFamilia, "Σαγράδα Φαμίλια");
            };

            casaBatlo = FindViewById<ImageButton>(Resource.Id.button_image2);
            casaBatlo.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.KazaBatlo, "Κάζα Μπατλό");
            };

            agora = FindViewById<ImageButton>(Resource.Id.button_image3);
            agora.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.AgoraBokeria, "Αγορά της Μποκερία");
            };

            mouseioTexnis = FindViewById<ImageButton>(Resource.Id.button_image4);
            mouseioTexnis.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.MouseioEthnikisTexnis, "Μουσείο Εθνικής Τέχνης της Καταλονίας");
            };

            casaMila = FindViewById<ImageButton>(Resource.Id.button_image5);
            casaMila.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.KazaMila, "Κάζα Μιλά");
            };

            magikoSintrivani = FindViewById<ImageButton>(Resource.Id.button_image6);
            magikoSintrivani.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.MagikoSintrivani, "Μαγικό Συντριβάνι");
            };

            mouseioPikaso = FindViewById<ImageButton>(Resource.Id.button_image7);
            mouseioPikaso.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.MouseioPikaso, "Μουσείο Πικάσο");
            };

            parko = FindViewById<ImageButton>(Resource.Id.button_image8);
            parko.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.ParkoSioutantela, "Πάρκο Σιουταντέλα");
            };

            parkoLaburinthou = FindViewById<ImageButton>(Resource.Id.button_image9);
            parkoLaburinthou.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.ParkoLaburinthou, "Πάρκο του Λαβυρίνθου της Όρτα");
            };

            campNou = FindViewById<ImageButton>(Resource.Id.button_image10);
            campNou.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.StadioKabNou, "Στάδιο Καμπ Νόου");
            };

            parkoGuel = FindViewById<ImageButton>(Resource.Id.button_image11);
            parkoGuel.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.ParkGuel, "Πάρκ Γκουέλ");
            };

            plateiaKatalonias = FindViewById<ImageButton>(Resource.Id.button_image12);
            plateiaKatalonias.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.PlateiaKatalonias, "Πλατεία Καταλονίας");
            };

            menuApsida = FindViewById<ImageButton>(Resource.Id.button_image13);
            menuApsida.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.ApsidaTouThriambou, "Αψίδα του Θριάμβου");
            };

            mouseioCosmocaisa = FindViewById<ImageButton>(Resource.Id.button_image14);
            mouseioCosmocaisa.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.MouseioCosmocaixa, "Μουσείο CosmoCaixa");
            };

            tsimpidampo = FindViewById<ImageButton>(Resource.Id.button_image15);
            tsimpidampo.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.Tsimpidampo, "Τιμπιδάμπο");
            };

            enudreio = FindViewById<ImageButton>(Resource.Id.button_image16);
            enudreio.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.Enudreio, "Ενυδρείο Βαρκελώνης");
            };

            rambla = FindViewById<ImageButton>(Resource.Id.button_image17);
            rambla.Click += (sender, e) =>
            {
                OpenTabActivity((int)Helper.enumTab.PezodromosRampla, "Πεζόδρομος Ράμπλα");
            };
        }

        private void OpenTabActivity(int enumTab, string title)
        {
            Intent intent = new Intent(this, typeof(TabActivity));
            intent.PutExtra("enumTab", enumTab);
            intent.PutExtra("title", title);
            StartActivity(intent);
        }

        private void ShowCountdown()
        {
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            CountdownDialogFragment dialog = new CountdownDialogFragment();
            dialog.Show(transaction, "Countdown");
        }
    }
}

