namespace KelimeBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GameManeger gManeger = new GameManeger();
        private void Form1_Load(object sender, EventArgs e)
        {
            gameStart();
            this.Text = "Kelime Bulma Oyunu [" + gManeger.getDbKeywordsList() + " Mevcut Kelime]";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (IsItLetter_Word(txtWord.Text))
            {
                gManeger.findWords(txtWord.Text.ToUpper());
                lblWord.Text = "";
                lblWord.Text = gManeger.addFoundKeyword();
            }
            else
            {
                if (gManeger.getHeart() > 0)
                {
                    if (gManeger.isItWordInGuess(txtWord.Text.ToUpper()))
                    {
                        MessageBox.Show("Tebrikler kelimeyi buldunuz");
                        lblWord.Text = gManeger.getKeywords();

                        btnRestEnablade(false); ;
                    }
                    else
                    {
                        MessageBox.Show("Yanlış tahmin");
                        gManeger.decreaseHeart();
                    }
                }
                else
                {
                    MessageBox.Show("Hakkınız kalmadı, kaybettiniz");
                    lblWord.Text = gManeger.getKeywords();

                    btnRestEnablade(false);
                }
            }

            lblHeart.Text = gManeger.getHeart().ToString() + "x";
            lstHistory.Items.Add(txtWord.Text.ToUpper());
            txtWord.Clear();
        }

        private bool IsItLetter_Word(string text)
        {
            if (text.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnRestEnablade(bool x)
        {
            txtWord.Enabled = x;
            btnEnter.Enabled = x;
            btnRest.Visible = !x;
        }

        private void gameStart()
        {
            btnRestEnablade(true);
            gManeger.startGame();
            lblWord.Text = gManeger.censeredKeyword();
            lblKeywords.Text = "Hile Aktif : " + gManeger.getKeywords();
            lblHeart.Text = gManeger.getHeart().ToString() + "x";
            lstHistory.Items.Clear();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            gameStart();
        }
        byte hack = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (hack++ > 6)
            {
                if (!lblKeywords.Visible)
                {
                    lblKeywords.Visible = true;
                }
                else
                {
                    lblKeywords.Visible = false;
                }
                hack = 0;
            }
        }
    }
}