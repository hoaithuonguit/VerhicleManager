namespace Data.Infrastructure
{
    public class Constant
    {
        // DATE FORMAT
        public static string FORMAT_DATETIME { get { return "dd/MM/yyyy hh:MM"; } }
        public static string FORMAT_DATE { get { return "dd/MM/yyyy"; } }

        // TYPE OF PRODUCT
        public static string TYPE_VEHICLE
        {
            get { return "01"; }
        }
        public static string TYPE_ACCESSORY
        {
            get { return "02"; }
        }

        // MESSAGE OF ACTION WITH DATABASE
        public static string MESSAGE_SUCCESS
        {
            get { return "Success"; }
        }
        public static string MESSAGE_ERROR
        {
            get { return "Error occur"; }
        }

        // STATUS OF ORDER DETAIL

        public static string STATUS_CENSORRED
        {
            get { return "01"; }
        }
        public static string STATUS_WAITING
        {
            get { return "02"; }
        }


    }
}
