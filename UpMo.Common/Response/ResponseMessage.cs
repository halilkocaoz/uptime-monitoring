namespace UpMo.Common.Response
{
    public static class ResponseMessage
    {
        #region private consts
        private const string notFoundStarting = "Not Found";
        #endregion

        #region
        public static readonly string Forbid = "Forbid";
        public static readonly string Internal = "Internal Server Error";
        public static readonly string InvalidCredentials = "Invalid Credentials";
        #endregion


        #region Not Found
        public static readonly string NotFoundOrganization = $"{notFoundStarting} Organization";
        #endregion
    }
}