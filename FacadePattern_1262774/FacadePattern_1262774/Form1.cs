namespace FacadePattern_1262774
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMortgageApproval_Click(object sender, EventArgs e)
        {
            string reason = "";
            MortgageApplicant mapp = new MortgageApplicant
            {
                FirstName = "Bill",
                LastName = "Baker",
                BankAccountNum = 12345,
                LoanAccountNum = 12345,
                
            SSNum = "111-22-3333",
                LoanAmountAsked = 150000
            };
            MortgageFacade mf = new MortgageFacade();
            bool approved = mf.MortgageApproval(mapp, ref reason);
            if (approved == true)
                MessageBox.Show("Your application has been approved..");
            else
                MessageBox.Show("Your application has been denied..\n" +
                reason);
        }

    }
}