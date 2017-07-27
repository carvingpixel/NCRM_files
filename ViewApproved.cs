using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NCRM
{
    public partial class ViewApproved : Form, IListLoop
    {
        //ATTRIBUTES ------------------------------------------------------------//
        private const int StatusApproved = 1;
        private const int StatusCompleted = 12;
        private readonly Request _mRequest = new Request();

        public ViewApproved()
        {
            InitializeComponent();
        }


        // INSTANT: UserOn.cs Request.cs ----------------------------------------//
        public UserOn SysUser { get; set; }


        // METHODS //

        //METHOD: get requests and loop list -----------------------------//
        public void GetRequestSets(string setStatus)
        {
            lbRequests.Items.Clear();
            lbRequests.Items.Add("<< VIEWING " + setStatus + " REQUESTS >>");
            foreach (var str in _mRequest.ReqStrList)
                lbRequests.Items.Add(str);
        }


        // Get requests and loop list -----------------------------//
        private void ViewApproved_Load(object sender, EventArgs e)
        {
            //  _registrar = SysUser.GetUserEmail();
            //fubard
            _mRequest.SelectAll(StatusApproved);
            GetRequestSets("APPROVED");
        }


        // BUTTONS //

        //BTN: Load Request Selected  -----------------------------------------//
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                //Extract INT FROM LABEL ----------------------------//
                var selectedRequest = lbRequests.SelectedItem.ToString();
                var resultString = Regex.Match(selectedRequest, @"\d+").Value;
                var reqid = int.Parse(resultString);

                //Select Record using above int---------------------//
                _mRequest.SelectRecord(reqid);

                //New ViewRequests pass request --------------------//
                var vrForm = new RegViewRequest
                {
                    ARequest = _mRequest,
                    SysUser = SysUser
                };
                vrForm.Show();
                Close();
            }
            catch (Exception loadEx)
            {
                Console.WriteLine(loadEx);
                MessageBox.Show(@"Please select a request to load.");
            }
        }


        //BTN: Get Approved list Iterate  ------------//
        private void btnGetApproved_Click(object sender, EventArgs e)
        {
            _mRequest.SelectAll(StatusApproved);
            GetRequestSets("APPROVED");
        }


        //BTN: Get completed list Iterate  ------------//
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            //Get Approved Requests Iterate List ------------//
            _mRequest.SelectAll(StatusCompleted);
            GetRequestSets("COMPLETED");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Export to Excel From Requests//
            _mRequest.ExportApproved();
        }


        //ENDOFLINE//
    }
}