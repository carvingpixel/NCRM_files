using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NCRM
{
    public partial class ListRequests : Form, IListLoop
    {
        private const int StatusNew = 0;
        private readonly Request _mRequest = new Request();


        //ATTRIBUTES ------------------------------------------------------------// 
        private string _coordinator;

        public ListRequests()
        {
            InitializeComponent();
        }


        // INSTANT: UserOn.cs Request.cs ----------------------------------------//
        public UserOn SysUser { get; set; }


        //VOID: get requests from public list set -----------------------------//
        public void GetRequestSets(string setStatus)
        {
            lbRequests.Items.Clear();
            lbRequests.Items.Add("<< VIEWING " + setStatus + " REQUESTS >>");
            foreach (var str in _mRequest.ReqStrList)
                lbRequests.Items.Add(str);
        }


        //ONLOAD: SelectBulkDB add list strings to box--------------------------//
        private void ListRequests_Load(object sender, EventArgs e)
        {
            //Get Coordinator -----------------------------------//
            _coordinator = SysUser.GetUserEmail();

            //Get Requests New and Get string from List----------//               
            _mRequest.SelectbyCoordinator(_coordinator, StatusNew);
            GetRequestSets("NEW");
        }


        //BTN Load Request Selected /------------------------------------//
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
                var vrForm = new ViewRequest
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


        //BTN: Export to Excel  ------------------------------------------------------//
        private void btnExport_Click(object sender, EventArgs e)
        {
            // Export to Excel From Requests//
            _mRequest.ExportAllRequests();
        }


        //BTN: Load New /-----------------------------------------------------//
        private void btnGetNew_Click(object sender, EventArgs e)
        {
            //Get New Requests Iterate List ------------------//
            _mRequest.SelectbyCoordinator(_coordinator, StatusNew);
            GetRequestSets("NEW");
        }


        //BTN: Load Approved /-------------------------------------------------//
        private void btnGetApproved_Click(object sender, EventArgs e)
        {
            //Get Approved Requests Iterate List ------------//
            const int statusApproved = 1;
            _mRequest.SelectbyCoordinator(_coordinator, statusApproved);
            GetRequestSets("APPROVED");
        }


        //BTN: Load Denied /-------------------------------------------------//
        private void btnGetDenied_Click(object sender, EventArgs e)
        {
            const int statusDenied = 9;
            _mRequest.SelectbyCoordinator(_coordinator, statusDenied);
            GetRequestSets("DENIED");
        }


        //BTN: Load Completed /-------------------------------------------------//
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            const int statusCompleted = 12;
            _mRequest.SelectbyCoordinator(_coordinator, statusCompleted);
            GetRequestSets("COMPLETED");
        }


        //BTN: Quit /-------------------------------------------------//
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }


        //ENDOFLINE
    }
}