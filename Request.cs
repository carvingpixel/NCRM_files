using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Spire.Xls;

namespace NCRM
{
    public class Request
    {
        //private string Registrar = "HIDDENRESOURCE";
        private const string Registrar = "HIDDENRESOURCE";

        //MySqlConnection
        private readonly MySqlConnection _con =
            new MySqlConnection("host=HIDDENRESOURCE;");

        private string _sql;

        //LIST: Bulk Select Strings -----------------------------//
        public List<string> ReqStrList = new List<string>();


        //Constructors /--------------------------------------------------------------//
        public Request()
        {
        } // no args constructor

        public Request(int rid)
        {
            SetRequestId(rid);
        }

        public Request(int rid, string e, string s, string hst, string pd, int sc)
        {
            SetRequestId(rid);
            SetContactEmail(e);
            SetSchool(s);
            SetHsCourseTitle(hst);
            SetPostDate(pd);
            SetStatusCode(sc);
        }

        public Request(int rid, string email, string school, string hsTitle, string scipcode, string credtype,
            string cctitle, string cccode, string csystem, string term,
            string sctype, string mowr, string bapp, string aapp, string tbtitle, string tbpub, string sprov,
            string postdate, string rresult, string rreason, string rdate,
            string cclass, string bpts, string bamt, string cipcode, string cipcode2, string coord, int status)
        {
            SetRequestId(rid);
            SetContactEmail(email);
            SetSchool(school);
            SetHsCourseTitle(hsTitle);
            SetStateCIPCode(scipcode);
            SetCreditType(credtype);
            SetCollegeCTitle(cctitle);
            SetCollegeCCode(cccode);
            SetCollegeSystem(csystem);
            SetTerm(term);
            SetScheduleType(sctype);
            SetMOWR(mowr);
            SetBApproved(bapp);
            SetAApproved(aapp);
            SetTbTitle(tbtitle);
            SetTbPublisher(tbpub);
            SetSyllabusProvided(sprov);
            SetPostDate(postdate);
            SetReviewResult(rresult);
            SetReviewReason(rreason);
            SetReviewDate(rdate);
            SetClassification(cclass);
            SetBonusPoints(bpts);
            SetBonusAmt(bamt);
            SetCIPSubCode(cipcode);
            SetCIPSubCode2(cipcode2);
            SetCoordinator(coord);
            SetStatusCode(status);
            StatusCode = status;
        } // overloaded constructor all 
        //PROPERTIES-----------------------------------------------//
        private int RequestId { get; set; }
        private string Email { get; set; }
        private string School { get; set; }
        private string HsCourseTitle { get; set; }
        private string StateCIPCode { get; set; }
        private string CreditType { get; set; }
        private string CollegeCTitle { get; set; }
        private string CollegeCCode { get; set; }
        private string CollegeSystem { get; set; }
        private string Term { get; set; }
        private string ScheduleType { get; set; }
        private string MOWR { get; set; }
        private string BApproved { get; set; }
        private string AApproved { get; set; }
        private string TbTitle { get; set; }
        private string TbPublisher { get; set; }
        private string SyllabusProvided { get; set; }
        private string PostDate { get; set; }
        private string ReviewResult { get; set; }
        private string ReviewReason { get; set; }
        private string ReviewDate { get; set; }
        private string Classification { get; set; }
        private string BonusPoints { get; set; }
        private string BonusAmt { get; set; }
        private string CIPSubCode { get; set; }
        private string CIPSubCode2 { get; set; }   
        private string Coordinator { get; set; }
        private int StatusCode { get; set; }


        //Methods /------------------------------------------------------------------------------//

        // RequestID
        public void SetRequestId(int data)
        {
            RequestId = data;
        }

        public int GetRequestId()
        {
            return RequestId;
        }

        //ContactEmail
        public void SetContactEmail(string data)
        {
            Email = data;
        }

        public string GetContactEmail()
        {
            return Email;
        }

        //School
        public void SetSchool(string data)
        {
            School = data;
        }

        public string GetSchool()
        {
            return School;
        }

        //HsCourseTitle
        public void SetHsCourseTitle(string data)
        {
            HsCourseTitle = data;
        }

        public string GetHsCourseTitle()
        {
            return HsCourseTitle;
        }

        //StateCIPCode
        public void SetStateCIPCode(string data)
        {
            StateCIPCode = data;
        }

        public string GetStateCIPCode()
        {
            return StateCIPCode;
        }

        //CreditType
        public void SetCreditType(string data)
        {
            CreditType = data;
        }

        public string GetCreditType()
        {
            return CreditType;
        }

        //CollegeCCode
        public void SetCollegeCCode(string data)
        {
            CollegeCCode = data;
        }

        public string GetCollegeCCode()
        {
            return CollegeCCode;
        }

        //CollegeCTitle
        public void SetCollegeCTitle(string data)
        {
            CollegeCTitle = data;
        }

        public string GetCollegeCTitle()
        {
            return CollegeCTitle;
        }

        //CollegeSystem
        public void SetCollegeSystem(string data)
        {
            CollegeSystem = data;
        }

        public string GetCollegeSystem()
        {
            return CollegeSystem;
        }

        //Term
        public void SetTerm(string data)
        {
            Term = data;
        }

        public string GetTerm()
        {
            return Term;
        }

        //ScheduleType
        public void SetScheduleType(string data)
        {
            ScheduleType = data;
        }

        public string GetScheduleType()
        {
            return ScheduleType;
        }

        //MOWR
        public void SetMOWR(string data)
        {
            MOWR = data;
        }

        public string GetMOWR()
        {
            return MOWR;
        }

        //BApproved
        public void SetBApproved(string data)
        {
            BApproved = data;
        }

        public string GetBApproved()
        {
            return BApproved;
        }

        //AApproved
        public void SetAApproved(string data)
        {
            AApproved = data;
        }

        public string GetAApproved()
        {
            return AApproved;
        }

        //TbTitle
        public void SetTbTitle(string data)
        {
            TbTitle = data;
        }

        public string GetTbTitle()
        {
            return TbTitle;
        }

        //TbPublisher
        public void SetTbPublisher(string data)
        {
            TbPublisher = data;
        }

        public string GetTbPublisher()
        {
            return TbPublisher;
        }

        // SyllabusProvided 
        public void SetSyllabusProvided(string data)
        {
            SyllabusProvided = data;
        }

        public string GetSyllabusProvided()
        {
            return SyllabusProvided;
        }

        // PostDate
        public void SetPostDate(string date)
        {
            PostDate = date;
        }

        public string GetPostDate()
        {
            return PostDate;
        }

        //ReviewResult
        public void SetReviewResult(string data)
        {
            ReviewResult = data;
        }

        public string GetReviewResult()
        {
            return ReviewResult;
        }

        //ReviewReason 
        public void SetReviewReason(string data)
        {
            ReviewReason = data;
        }

        public string GetReviewReason()
        {
            return ReviewReason;
        }

        //ReviewDate
        public void SetReviewDate(string data)
        {
            ReviewDate = data;
        }

        public string GetReviewDate()
        {
            return ReviewDate;
        }

        //Classification
        public void SetClassification(string data)
        {
            Classification = data;
        }

        public string GetClassification()
        {
            return Classification;
        }

        //BonusPoints
        public void SetBonusPoints(string data)
        {
            BonusPoints = data;
        }

        public string GetBonusPoints()
        {
            return BonusPoints;
        }

        //BonusAmt 
        public void SetBonusAmt(string data)
        {
            BonusAmt = data;
        }

        public string GetBonusAmt()
        {
            return BonusAmt;
        }

        //CIPSubCode 
        public void SetCIPSubCode(string data)
        {
            CIPSubCode = data;
        }

        public string GetCIPSubCode()
        {
            return CIPSubCode;
        }

        //CPISubCode
        public void SetCIPSubCode2(string data)
        {
            CIPSubCode2 = data;
        }

        public string GetCIPSubCode2()
        {
            return CIPSubCode2;
        }

        //Coordinator 
        public void SetCoordinator(string data)
        {
            Coordinator = data;
        }

        public string GetCoordinator()
        {
            return Coordinator;
        }

        //StatusCode 
        public void SetStatusCode(int data)
        {
            StatusCode = data;
        }

        public int GetStatusCode()
        {
            return StatusCode;
        }

        //Registrar 
        public string GetRegistrar()
        {
            return Registrar;
        }


        // Select by Coordinator Filter -----------------------------------------------------------------------//
        public void SelectbyCoordinator(string coordinator, int ticketState)
        {
            _sql = "SELECT HIDDENRESOURCE " +
                   ticketState;
            SelectBulkDb();
        }


        // Select by Registration Filter  -----------------------------------------------------------------------//
        public void SelectAll(int ticketState)
        {
            _sql = "SELECT * FROM HIDDENRESOURCE order by requestID DESC";
            Console.WriteLine(_sql);
            SelectBulkDb();
        }


        //  Select Bulk Method -----------------------------------------------------------------------//
        private void SelectBulkDb()
        {
            ReqStrList.Clear();
            try
            {
                var cmd = new MySqlCommand(_sql, _con);
                _con.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    SetRequestId(reader.GetInt32("RequestId"));
                    SetContactEmail(reader.GetString("email"));
                    SetSchool(reader.GetString("school"));
                    SetHsCourseTitle(reader.GetString("hscoursetitle"));
                    SetPostDate(reader.GetString("postdate"));
                    SetStatusCode(reader.GetInt32("statuscode"));
                    var requestRecord = GetRequestId() + ", " + GetContactEmail() + ", " + GetSchool() + ", " +
                                        GetHsCourseTitle() + ", " + GetPostDate();

                    //REVIST LISTS AGAIN -----------------------------//
                    ReqStrList.Add(requestRecord);
                }
                _con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
            }
        }


        // select A db /--------------------------------------------------//
        public void SelectRecord(int reqid)
        {
            try
            {
                _sql = "SELECT * FROM HIDDENRESOURCE where requestID = @reqid";          
                var cmd = new MySqlCommand(_sql, _con);

                // BIND PARAMETERS ------------------------------------//
                cmd.Parameters.AddWithValue("@reqid", reqid);

                _con.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    SetRequestId(reader.GetInt32("RequestId"));
                    SetContactEmail(reader.GetString("email"));
                    SetSchool(reader.GetString("school"));
                    SetHsCourseTitle(reader.GetString("hscoursetitle"));
                    SetStateCIPCode(reader.GetString("statecipcode"));
                    SetCreditType(reader.GetString("credittype"));
                    SetCollegeCTitle(reader.GetString("collegectitle"));
                    SetCollegeCCode(reader.GetString("collegeccode"));
                    SetCollegeSystem(reader.GetString("collegesystem"));
                    SetTerm(reader.GetString("term"));
                    SetScheduleType(reader.GetString("scheduletype"));
                    SetMOWR(reader.GetString("mowr"));
                    SetBApproved(reader.GetString("bapproved"));
                    SetAApproved(reader.GetString("aapproved"));
                    SetTbTitle(reader.GetString("tbtitle"));
                    SetTbPublisher(reader.GetString("tbpublisher"));
                    SetSyllabusProvided(reader.GetString("syllabusprovided"));
                    SetPostDate(reader.GetString("postdate"));
                    SetReviewResult(reader.GetString("reviewresult"));
                    SetReviewReason(reader.GetString("reviewreason"));
                    SetReviewDate(reader.GetString("reviewdate"));
                    SetClassification(reader.GetString("classification"));
                    SetBonusPoints(reader.GetString("bonuspoints"));
                    SetBonusAmt(reader.GetString("bonusamt"));
                    SetCIPSubCode(reader.GetString("cipsubcode"));
                    SetCIPSubCode2(reader.GetString("cipsubcode2"));
                    SetCoordinator(reader.GetString("coordinator"));
                    SetStatusCode(reader.GetInt32("statuscode"));
                } //while
                _con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        }


        // update db /--------------------------------------------------//
        public string UpdateRequest(int reqid)
        {
            var statusMsg = "Unable to Udpate at this time";
            try
            {
                _sql = "UPDATE HIDDENRESOURCE SET" +
                       " reviewResult = @reviewResult," +
                       " reviewReason = @reviewReason," +
                       " reviewDate = @reviewDate," +
                       " classification = @classification," +
                       " bonusPoints = @bonusPoints," +
                       " bonusAmt = @bonusAmt," +
                       " CIPSubCode = @CIPSubCode," +
                       " CIPSubCode2 = @CIPSubCode2," +
                       " coordinator = @Coordinator," +
                       " statusCode = @StatusCode" +
                       " WHERE requestID = @reqid";
                //Console.WriteLine(_sql);

                // connection and execute -----------------------------//
                //connect database mysql ------------------------------------//

             
                var cmd = new MySqlCommand(_sql, _con);

                // BIND PARAMETERS ------------------------------------//
                cmd.Parameters.AddWithValue("@reviewResult", GetReviewResult());
                cmd.Parameters.AddWithValue("@reviewReason", GetReviewReason());
                cmd.Parameters.AddWithValue("@reviewDate", GetReviewDate());
                cmd.Parameters.AddWithValue("@classification", GetClassification());
                cmd.Parameters.AddWithValue("@bonusPoints", GetBonusPoints());
                cmd.Parameters.AddWithValue("@bonusAmt", GetBonusAmt());
                cmd.Parameters.AddWithValue("@CIPSubCode", GetCIPSubCode());
                cmd.Parameters.AddWithValue("@CIPSubCode2", GetCIPSubCode2());
                cmd.Parameters.AddWithValue("@Coordinator", GetCoordinator());
                cmd.Parameters.AddWithValue("@StatusCode", GetStatusCode());
                cmd.Parameters.AddWithValue("@reqid", reqid);

                //OPEN, EXECUTE, CLOSE ------------------------------------//
                _con.Open();

                var iSuccess = cmd.ExecuteNonQuery();
                statusMsg = iSuccess == 1 ? "Process Complete, Thank you!" : "Error Processing Request contact HIDDENRESOURCE";
                _con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(statusMsg);
            return statusMsg;
        }


        //Call Excel Report Passing Approved Select from viewApproved.cs --------------------//
        public void ExportApproved()
        { 
            _sql = "SELECT * FROM HIDDENRESOURCE where coordinator <> 'HIDDENRESOURCE' and statuscode = 1";
            ExcelReport(_sql);
        }


        ///Call Excel Report Passing ALL Select from ListRequests.cs -------------------------//
        public void ExportAllRequests()
        {
            _sql = "SELECT * FROM HIDDENRESOURCE where coordinator <> 'HIDDENRESOURCE' and statuscode <> 12";
            ExcelReport(_sql);
        }


        // Shared private method dbconnect and process excel report --------------------------//
        private void ExcelReport(string query)
        {
            try
            {

                //relate dataset to mysqladapter and fill dataset------------//
                var dataSet = new DataSet();
                var dataAdapter = new MySqlDataAdapter(query, _con);
                _con.Open();
                dataAdapter.Fill(dataSet);
                var t = dataSet.Tables[0];

                //export datatable to excel --------------------------------//
                // using Spire.Xls //
                var book = new Workbook();
                var sheet = book.Worksheets[0];
                sheet.InsertDataTable(t, true, 1, 1);
                book.SaveToFile("NCRM_Excel.xls", ExcelVersion.Version97to2003);
                Process.Start("NCRM_Excel.xls");
                _con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(@"Error Opening Excel, Please Close Existing Sessions if Applicable");
            }
        }

    }
}