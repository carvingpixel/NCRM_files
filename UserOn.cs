/* UserOn Class / user on the system
 ------------------------------------------------------------------------------------------*/

namespace NCRM
{
    public class UserOn
    {
      //PROPERTIES /---------------------------------// 
		private string _userDept;
        private string _userEmail;
        private string _userFirst;
        private int _userid;
        private string _userLast;


        //CONSTRUCTORS /-------------------------------//
        public UserOn()
        {
        } 

        public UserOn(string umail, string udept)
        {
            SetUserEmail(umail);
            SetUserDept(udept);
        }

        public UserOn(int uid, string umail, string ufirst, string ulast, string udept)
        {
            SetUid(uid);
            SetUserEmail(umail);
            SetUserFirst(ufirst);
            SetUserLast(ulast);
            SetUserDept(udept);
        }

        //METHODS /------------------------------------//
        public void SetUid(int uid)
        {
            _userid = uid;
        }

        public int GetUid()
        {
            return _userid;
        }


        public void SetUserEmail(string umail)
        {
            _userEmail = umail;
        }

        public string GetUserEmail()
        {
            return _userEmail;
        }


        public void SetUserFirst(string ufirst)
        {
            _userFirst = ufirst;
        }

        public string GetUserFirst()
        {
            return _userFirst;
        }


        public void SetUserLast(string ulast)
        {
            _userLast = ulast;
        }

        public string GetuserLast()
        {
            return _userLast;
        }


        public void SetUserDept(string udept)
        {
            _userDept = udept;
        }

        public string GetUserDept()
        {
            return _userDept;
        }
    }
}