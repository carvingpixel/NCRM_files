using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NCRM
{
    public partial class RegViewRequest : Form, IReturn
    {
        private readonly DateTime _curDate = DateTime.Now;
        private int _getId;

        //PROPERTIES-----------------------------------------------//
        private string _notifySubmitter = "";
        private string _resultMsg = "";
        private string _setSubmitterBody = "";

        public RegViewRequest()
        {
            InitializeComponent();
        }

        //setup Request Instance -----------------------------------//
        public Request ARequest { get; set; }
        public UserOn SysUser { get; set; }


        //IVOID: Return to Reg View Requests /-----------------------------------------------//
        public void ReturnListRequests()
        {
            var vaForm = new ViewApproved {SysUser = SysUser};
            vaForm.Show();
            Close();
        }


        private void RegViewRequest_Load(object sender, EventArgs e)
        {
            //Request Properties Set Via btn load on ListRequests//
            lbRequestId.Text = ARequest.GetRequestId() + "";
            llEmail.Text = ARequest.GetContactEmail() + "";
            lbSchool.Text = ARequest.GetSchool() + "";
            lbhsCourseTitle.Text = ARequest.GetHsCourseTitle() + "";
            lbPostDate.Text = ARequest.GetPostDate() + "";
            lbStateCipCode.Text = ARequest.GetStateCIPCode() + "";
            lbCreditType.Text = ARequest.GetCreditType() + "";
            lbCollegeCTitle.Text = ARequest.GetCollegeCTitle() + "";
            lbCollegeCCode.Text = ARequest.GetCollegeCCode() + "";
            lbCollegeSystem.Text = ARequest.GetCollegeSystem() + "";
            lbTerm.Text = ARequest.GetTerm() + "";
            lbScheduleType.Text = ARequest.GetScheduleType() + "";
            lbMOWR.Text = ARequest.GetMOWR() + "";
            lbBApproved.Text = ARequest.GetBApproved() + "";
            lbPApproved.Text = ARequest.GetAApproved() + "";
            lbTBTitle.Text = ARequest.GetTbTitle() + "";
            lbTBPub.Text = ARequest.GetTbPublisher() + "";
            lbSyllabusProvided.Text = ARequest.GetSyllabusProvided() + "";
            ShowStatus(ARequest.GetStatusCode());

            // District Use Only Fields
            lbcurDate.Text = ARequest.GetReviewDate() + "";
            llCoordinator.Text = ARequest.GetCoordinator() + "";
            lbReviewReason.Text = ARequest.GetReviewReason() + "";
            lbClassification.Text = ARequest.GetClassification() + "";
            lbBonusPoints.Text = ARequest.GetBonusPoints() + "";
            lbBonusAmt.Text = ARequest.GetBonusAmt() + "";
            lbCIPSubCode.Text = ARequest.GetCIPSubCode() + "";
            lbCIPSubCode2.Text = ARequest.GetCIPSubCode2() + "";
        }


        //Method: ShowStatus as STR ---------------------------------//
        private void ShowStatus(int thisStatus)
        {
            if (thisStatus == 0) lbCurrStatus.Text = @"New/Working";
            else if (thisStatus == 1) lbCurrStatus.Text = @"Approved";
            else if (thisStatus == 9) lbCurrStatus.Text = @"Denied";
            else lbCurrStatus.Text = @"Unknown";
        }


        //Method: Update Request Shared with two clicks -------------------------//
        private void ResolveRequest()
        {
            try
            {
                //set status - touch date - update -----------------//
                ARequest.SetStatusCode(12);
                _getId = ARequest.GetRequestId();
                ARequest.SetReviewDate(_curDate + "");
                ARequest.UpdateRequest(_getId);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(@"Error Updating Record");
            }
        }


        //BTN: Confirm  -----------------------------------------------------//
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Call Resolve Request  ----------------//
            ResolveRequest();

            //Get Contact Email ----------------//          
            _notifySubmitter = ARequest.GetContactEmail();
            _resultMsg = "Request Set As Completed, Notifying " + _notifySubmitter;
            _setSubmitterBody = "Your HIDDENRESOURCE Has Been Added by HIDDENRESOURCE";

            MessageBox.Show(_resultMsg);
            Cursor.Current = Cursors.WaitCursor;

            var sendEmail = new EmailNotify();
            sendEmail.EmailNotification(_notifySubmitter, _setSubmitterBody);

            //Return to List ----------------//
            ReturnListRequests();
        }


        // LINK Email Submitter  -------------------------------------------------//
        private void llEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llEmail.LinkVisited = true;
            var getContact = llEmail.Text;
            //Console.WriteLine(getContact);
            Process.Start("mailto:" + getContact);
        }


        // LINK Email Coordinators -------------------------------------------------//
        private void llCoordinator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llEmail.LinkVisited = true;
            var getContact = llCoordinator.Text;
            //Console.WriteLine(getContact);
            Process.Start("mailto:" + getContact);
        }


        //BTN: Escape -----------------------------------------------------//
        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            ReturnListRequests();
        }

   


        //ENDOFLINE
    }
}