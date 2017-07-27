using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NCRM
{
    public partial class ViewRequest : Form, IReturn
    {
    
        //PROPERTIES-----------------------------------------------//
        private string _resultMsg = "";

        public ViewRequest()
        {
            InitializeComponent();
        }

        //setup Request Instance -----------------------------------//
        public Request ARequest { get; set; }
        public UserOn SysUser { get; set; }


        //IVOID: Return to List Requests  /-----------------------------------------------//
        public void ReturnListRequests()
        {
            var lrForm = new ListRequests {SysUser = SysUser};
            Close();
            lrForm.Show();
        }

        // OnLoad -------------------------------------------------//
        private void ViewRequest_Load(object sender, EventArgs e)
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
            tbCoordinator.Text = "" + ARequest.GetCoordinator() + "";
            ShowStatus(ARequest.GetStatusCode());

            // District Use Only Fields
            lbcurDate.Text = ARequest.GetReviewDate() + "";
            tbCoordinator.Text = ARequest.GetCoordinator() + "";
            cbReviewReason.DataSource = new[]
            {
                ARequest.GetReviewReason(),
                "Form Not Complete",
                "Incorrect CIP Code",
                "Incorrect Course Title",
                "Other - Contact Coordinator",
                "Not Applicable"
            };
            cbClassification.DataSource = new[]
            {
                ARequest.GetClassification(),
                "Not Applicable",
                "Honors Course 5pts",
                "Ap Course 10pts",
                "Online - All Levels",
                "DE/MOWR Course 10pts",
                "MS Advanced Course",
                "Elementary Gifted"
            };
            cbBonusPoints.DataSource = new[]
            {
                ARequest.GetBonusPoints(),
                "Yes",
                "No",
                "N/A"
            };
            cbBonusAmt.DataSource = new[]
            {
                ARequest.GetBonusAmt(),
                "5 pts",
                "10 pts",
                "N/A"
            };
            cbCIPSubCode.DataSource = new[]
            {
                ARequest.GetCIPSubCode(),
                ".0 - General",
                ".1 - Remedial",
                ".2 - Gifted",
                ".3 - Online",
                ".4 -1 Hour lab",
                ".5 - 2 Hour lab",
                ".6 - 3 Hour lab",
                ".7 - Work Based Learning",
                ".8 - ESEP Small Group"
            };
            cbCIPSubCode2.DataSource = new[]
            {
                ARequest.GetCIPSubCode2(),
                ".0 - General",
                ".1 - Remedial",
                ".2 - Gifted",
                ".3 - Online",
                ".4 -1 Hour lab",
                ".5 - 2 Hour lab",
                ".6 - 3 Hour lab",
                ".7 - Work Based Learning",
                ".8 - ESEP Small Group",
                "Not Applicable"
            };
        }


        //Method: ShowStatus as STR ---------------------------------//
        private void ShowStatus(int thisStatus)
        {
            if (thisStatus == 0) lbCurrStatus.Text = @"New/Working";
            else if (thisStatus == 1) lbCurrStatus.Text = @"Approved";
            else if (thisStatus == 9) lbCurrStatus.Text = @"Denied";
            else lbCurrStatus.Text = @"Unknown";
        }


        //Method: Radio If Check for Status -----------------------------------//
        private int CheckFinalized()
        {
            if (rbApproved.Checked)
            {
                ARequest.SetStatusCode(1);
                return 1;
            }
            if (rbDenied.Checked)
            {
                ARequest.SetStatusCode(9);
                return 9;
            }
            if (rbWorking.Checked)
            {
                ARequest.SetStatusCode(0);
                return 0;
            }
            ARequest.SetStatusCode(0);
            return 0;
        }



        //Method: CB Notify call email  ///-----------------------------------//
        private void CheckNotify(int sc)
        {
            var sendEmail = new EmailNotify();

            string notifySubmitter;
            string setSubmitterBody;
            const string resultMsg = @"Processing All Email Notifications; Please Standby Momentarily.";

            if (cbNotify.Checked && sc == 1) // request approved email registration and submitter
            {
                //collect request data to send principals --
                var eCourseTitle = ARequest.GetHsCourseTitle();
                var eCoordinator = ARequest.GetCoordinator();
                var eClassification = ARequest.GetClassification();

                // Set Emails for notify --//
                notifySubmitter = llEmail.Text;
                const string notifyRegistrar = "HIDDENRESOURCE"; //var notifyRegistrar = ARequest.GetRegistrar();
                const string notifySchools   = "HIDDENRESOURCE"; // MS Exchange Distribution List for HIDDENRESOURCE

                // Set Email Body email notify --//
                setSubmitterBody = "Your Course Request titled (" + eCourseTitle + ") HIDDENRESOURCE.";
                var approvedText = "A new (" + eClassification + ") Course titled (" + eCourseTitle + ") submitted by " + notifySubmitter + " has been approved by " + eCoordinator + ".\n\n";
                var setRegistrarBody = approvedText + "Please Access HIDDENRESOURCE for futher details.";
                var setAPBody = approvedText + "This HIDDENRESOURCE.";

                //  MessageBox --//
                MessageBox.Show(resultMsg); // + notifySubmitter + @" & " + notifyRegistrar

                // WaitCurser and email both --//
                Cursor.Current = Cursors.WaitCursor;
                sendEmail.EmailNotification(notifySubmitter, setSubmitterBody);
                sendEmail.EmailNotification(notifyRegistrar, setRegistrarBody);
                sendEmail.EmailNotification(notifySchools, setAPBody);
            }
            else if (cbNotify.Checked && sc == 9) // request denied email submitter only
            {
                // Set Email for email notify --//
                notifySubmitter = llEmail.Text;

                // Set Email Body email notify --//
                setSubmitterBody = "Your HIDDENRESOURCE. ";

                // MessageBox --//
                MessageBox.Show(resultMsg);

                // WaitCurser and email denied --//
                Cursor.Current = Cursors.WaitCursor;
                sendEmail.EmailNotification(notifySubmitter, setSubmitterBody);
            }
            //else nothing
        }

      


        //Method: Update Request Shared with two clicks -------------------------//
        private void UpdateRequest()
        {
            // Grab the ID from existing Request Object
            var getId = ARequest.GetRequestId();
            var curDate = DateTime.Now;

            // DATE -------//
            ARequest.SetReviewDate(curDate + "");

            ARequest.SetCoordinator(tbCoordinator.Text);
            ARequest.SetReviewReason(cbReviewReason.Text);
            ARequest.SetClassification(cbClassification.Text);
            ARequest.SetBonusPoints(cbBonusPoints.Text);
            ARequest.SetBonusAmt(cbBonusAmt.Text);
            ARequest.SetCIPSubCode(cbCIPSubCode.Text);
            ARequest.SetCIPSubCode2(cbCIPSubCode2.Text);

            // Call UpdateRequest from Request Class to use new attributs--//
            _resultMsg = ARequest.UpdateRequest(getId);
            MessageBox.Show(_resultMsg);
        }





        //BTN: Basic Update  /-----------------------------------------------//
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ARequest.SetStatusCode(0);
                UpdateRequest();
                ReturnListRequests();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(@"Error Updating Record");
            }
        }


        //BTN: Finalize Update --------------------------------------------//
        private void btnFinalize_Click(object sender, EventArgs e)
        {
            try
            {
                var statusCode = CheckFinalized();
                CheckNotify(statusCode);
                UpdateRequest();
                ReturnListRequests();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Error Updating Record");
                Console.WriteLine(exception);
            }
        }


        //BTN: Escape -----------------------------------------------------//
        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnListRequests();
        }


        //LINK: Email Submitter -------------------------------------------------//
        private void llEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llEmail.LinkVisited = true;
            var getContact = llEmail.Text;
            //Console.WriteLine(getContact);
            Process.Start("mailto:" + getContact);
        }





        //ENDOFLINE
    }
}