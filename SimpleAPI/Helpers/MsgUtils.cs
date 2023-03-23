namespace SimpleAPI.Helpers
{
    public class MsgUtils

    {
        protected MsgUtils()
        {

        }
        public static readonly string Status_Code200 = "OK";
        public static readonly string Status_Code204 = "No Content";
        public static readonly string Status_Code202 = "Accepted";

        public static readonly string Status_Code307 = "Temporary Redirect";
        public static readonly string Status_Code308 = "Permanent Redirect";
        public static readonly string Status_Code304 = "Not Modified";
        public static readonly string Status_Code302 = "Found";

        public static readonly string Status_Code400 = "Bad Request";
        public static readonly string Status_Code401 = "Unauthorized";
        public static readonly string Status_Code402 = "Payement Required";
        public static readonly string Status_Code403 = "Forbidden";
        public static readonly string Status_Code404 = "Not Found";
        public static readonly string Status_Code408 = "Request Time Out";


        public static readonly string Status_Code500 = "Internal Server Error";
        public static readonly string Status_Code511 = "Network Authentication Required";
        public static readonly string Status_Code599 = "Network Connect Timeout Error";


        public static readonly string EMPTY_FILE = "server.msg.empty_file";
        public static readonly string OK = "server.msg.ok";
        public static readonly string OK_BUT_NO_MESSAGE_SEND = "server.msg.ok_but_no_message_send";
        public static readonly string OPERATION_GET_DOCUMENT_TYPE_LIST_OK = "server.msg.operation_get_document_type_list_ok";
        public static readonly string OPERATION_GET_DOCUMENT_TYPE_LIST_FAIL = "server.msg.operation_get_document_type_list_fail";
        public static readonly string OPERATION_DELETE_DOCUMENT_OK = "server.msg.operation_delete_document_ok";
        public static readonly string OPERATION_DELETE_DOCUMENT_FAIL = "server.msg.operation_delete_document_fail";
        public static readonly string LOGOUT_OK = "server.msg.logout.success";
        public static readonly string OPERATION_FAILED = "server.msg.process_error";
        public static readonly string PASSWD_DO_NOT_MATCH = "server.msg.passwd_do_not_match";
        public static readonly string INVALID_USER_EMAIL = "server.msg.invalid_user_email";
        public static readonly string INVALID_USER_PASSWD = "server.msg.invalid_user_passwd";
        public static readonly string INVALID_USER_ID = "server.msg.invalid_user_id";
        public static readonly string INVALID_SPECIALITY_ID = "server.msg.invalid_speciality_id";
        public static readonly string INVALID_DOCUMENT_ID = "server.msg.invalid_document_id";
        public static readonly string INVALID_SESSION_MONTH = "server.msg.invalid_session_month";
        public static readonly string INVALID_ROLE_ID = "server.msg.invalid_role_id";
        public static readonly string INVALID_ROLE_NAME = "server.msg.invalid_role_name";
        public static readonly string FIRST_REMOVE_USER_FROM_ROLE = "server.msg.first_remove_user_from_role";

        public static readonly string BAD_PARAMETERS = "server.msg.bad_parameter";
        public static readonly string REQUIRED_MANDATORIES_PARAMTERS = "server.msg.required_mandatories_params";
        public static readonly string NOT_REFERENTIAL_DATA_IN = "server.msg.not_referential_data_in";
        public static readonly string BAD_PASSWORD_PARAMETERS = "server.msg.bad_password_parameter";
        public static readonly string INVALID_AMOUNT = "server.msg.invalid_amount";
        public static readonly string INVALID_PERIODICITY = "server.msg.invalid_periodicity";
        public static readonly string INVALID_USER = "server.msg.invalid_user";
        public static readonly string USER_ID_REQUIRED = "server.msg.user_id_required";
        public static readonly string USER_USER_NOT_ACTIVE = "server.msg.user_not_active";
        public static readonly string INVALID_MODEL = "server.msg.model";
        public static readonly string INVALID_SPECIALITY_CODE_LIST = "specility_code_can't_not_be_null";


        public static readonly string INVALID_DOCUMENT_TYP = "server.msg.invalid_document_typ";
        public static readonly string INVALID_NATIONALITY = "server.msg.invalid_nationality";
        public static readonly string INVALID_REGION = "server.msg.invalid_region";
        public static readonly string INVALID_DEPARTEMENT = "server.msg.invalid_departement";
        public static readonly string INVALID_SEX = "server.msg.invalid_sex";
        public static readonly string INVALID_CANDIDATE = "server.msg.invalid_candidate";
        public static readonly string INVALID_INCIDENT = "server.msg.invalid_incident";
        public static readonly string INVALID_INCIDENT_TYP = "server.msg.invalid_incident_typ";
        public static readonly string INVALID_INCIDENT_FILTER = "server.msg.invalid_incident_filter";

        public static readonly string EMPTY_ROLE = "server.msg.empty_role";

        public static readonly string CANDIDATE_STILL_CONFIRM = "server.msg.candidate_stil_confirm";
        public static readonly string CANDIDATE_STILL_NOT_CONFIRM = "server.msg.candidate_stil_not_confirm";
        public static readonly string CANDIDATE_STILL_EXIST = "server.msg.candidate_stil_exist";
        public static readonly string DIPLOMA_STILL_EXIST = "server.msg.diploma_stil_exist";

        public static readonly string INVALID_ID = "server.msg.invalid_id";
        public static readonly string NOT_FOUND = "server.msg.not_found";
        public static readonly string EXPIRED_SESSION = "server.msg.expire_session";
        public static readonly string INVALID_SESSION = "server.msg.invalid_session";
        public static readonly string FORBIDDEN = "server.msg.forbidden";

        public static readonly string OPERATION_NOT_ALLOWED = "server.msg.operation_not_allowed";

        public static readonly string INVALID_ACCOUNT = "server.msg.invalid_account";
        public static readonly string INVALID_VERBAL_TRIAL = "server.msg.invalid_verbal_trial";
        public static readonly string INVALID_DOCUMENT = "server.msg.invalid_document";
        public static readonly string INVALID_PV = "server.msg.invalid_pv";


        public static readonly string INVALID_ACCOUNT_NUMBER = "server.msg.invalid_account_number";
        public static readonly string INVALID_AlERT = "server.msg.invalid_alert_number";

        public static readonly string REJECT_REASON_REQUIRED = "server.msg.reject_reason_required";
        public static readonly string INVALID_DATA = "server.msg.invalid_data";
        public static readonly string NO_BINDING_MODEL = "server.msg.no_binding_model";
        public static readonly string NO_DATA = "server.msg.no_data_in_data_base";
        public static readonly string REQUIRED_PRIVILEGED = "server.msg.required_privileged";
        public static readonly string NO_DATA_TO_UPDATE = "server.msg.no_data_to_update";
        public static readonly string INVALID_DIPLOMA_ID = "server.msg.invalid_diploma_id";
        public static readonly string UNKNOWN_STEP = "server.msg.unknown_step";
        public static readonly string STEP_ALREADY_VALIDATED = "server.msg.step_already_validated";
        public static readonly string STEP_ALREADY_INVALIDATED = "server.msg.step_already_invalidated";

        public static readonly string INVALID_ROLE = "server.msg.invalid_role";
        public static readonly string INVALID_USER_INFORMATIONS = "server.msg.invalid_user_informations";
        public static readonly string INVALID_AUTHENTICATION_REQUEST_CODE = "server.msg.invalid_authentication_request_code";

        public static readonly string CREATE_CHAT_ROOM_FAILED = "server.msg.create_chat_room_failed";

        public static readonly string GET_TEACHING_UNIT_FAILED = "server.msg.get_teaching_unit_failed";
        public static readonly string GET_TEACHING_UNIT_BY_ID_FAILED = "server.msg.get_teaching_unit_by_id_failed";
        public static readonly string TEACHING_UNIT_NO_EXIST = "server.msg.no_existing_teaching_unit";

        internal static readonly string INVALID_MODULE = "server.msg.invalid_module";
        internal static readonly string INVALID_DEPARTMENTSCHOOL = "server.msg.invalid_departmentschool";
        internal static readonly string INVALID_EVALUATION_TYPE = "server.msg.invalid_evaluation_type";



        public static readonly string INVALID_PROPERTIES = "server.msg.invalid_properties";
        public static readonly string INTERNAL_SERVER_ERROR = "server.msg.internal_server_error";


        public static readonly string BAD_ID = "server.msg.bad.id";
        public static readonly string LOGIN_FAILED = "server.msg.login_failed";
        public static readonly string REACTIVATE_USER_FAILED = "server.msg.reactivate_user_failed";
        public static readonly string DELETE_USER_FAILED = "server.msg.delete_user_failed";

        public static readonly string EMPTY_USER = "server.msg.empty_user";


        public static readonly string GET_CURRENT_USER_FAILED = "server.msg.get_current_user_failed";
        public static readonly string GET_ALL_USERS_FAILED = "server.msg.get_all_users_failed";

        public static readonly string GET_USER_FILTER_FAILED = "server.msg.get_user_filter_failed";
        /// <summary>
        /// lease exception
        /// </summary>
        public static readonly string FILE_SIZE_INVALID = "server.msg.file_size_is_invalid_sent_file_between_[1,300_KB]";
        public static readonly string CONTRACT_ID_INVALID = "server.msg.contract_id_is_not active";
        public static readonly string LODGER_ID_INVALID = "server.msg.contract_id_is_not active";
        public static readonly string LANDLORD_ID_INVALID = "server.msg.contract_id_is_not active";
        public static readonly string LODGING_ID_INVALID = "server.msg.contract_id_is_not active";
        public static readonly string ALREADY_SIGNED = "server.msg.contract_is_already_signed";
        public static readonly string ANY_PAYMENT = "server.msg.any_payment_have_not_be_done_on_this_payment";
        public static readonly string PAYMENT_NOT_CORRESPONDING_TO_THE_DESIRED_AMOUNT = "server.msg.payment_not_corresponding_to_the_desired_amount";
        public static readonly string PAYMENT_HAVE_NOT_BE_VALIDATED = "server.msg.payment_have_not_be_validated";






        public static readonly string EMPTY_UNITY = "server.msg.empty_unity";

        public static readonly string EMPTY_LIST = "server.msg.empty_list";

        public static readonly string EXISTED_ELEMENTS = "server.msg.existed_elements";
        public static readonly string NOT_EXISTED_ELEMENTS = "server.msg.not_existed_elements";
        public static readonly string NOTHING_HAS_BEEN_RECORDED_IN_DATABASE = "server.msg.nothing_recorded_in_database";

        public static readonly string INVALID_CLAIMS = "server.msg.inexisted_elements";
        public static readonly string REGISTER_USER_FAILED = "server.msg.register_user_failed";

        public static readonly string EMPTY_ROOM = "server.msg.empty_room";

        public static readonly string EMPTY_SICKPOST = "server.msg.empty_sickpost";

        public static readonly string EMPTY_PLANNING = "server.msg.empty_planning";

        public static readonly string CONTRACT_CREATED = "Bonjour !\nLe contrat {0} \nvient d'être créé sur le logement numéro {1} \nde l'immeuble {2}." +
                "\n\tNom du locataire : {3}\n\tNom du bailleur : {4}\n";

        public static readonly string LANDLORD_OR_LODGER_CREATED = "Bonjour {0}!\nVous venez d'etre enregistré dans l'application RENTAL.\n" +
                "Vos informations de connexion à votre compte sont les suivantes:\n- Username: {1}" +
                "\n- Mot de passe: {2}\nPar mesure de securité veuillez changer votre" +
                " mot de passe dès votre première connexion à l'application.\nMerci.";


        public static string RegisterAlert(string? lodgerName, string? landlordName, string? email, string? contractCode, int? lodgingNumber, string? buildingName)
        {
            if (string.IsNullOrEmpty(buildingName) && string.IsNullOrEmpty(lodgingNumber.ToString()))
                return string.Format(LANDLORD_OR_LODGER_CREATED, lodgerName, email, "Admin1*");
            else
                return string.Format(CONTRACT_CREATED, contractCode, lodgingNumber, buildingName, lodgerName, landlordName);
        }

        /// <summary>
        /// HTTP STATUS CODE 
        /// USE TO MANAGE HTTP SERVICES STATUS RESPONSES
        /// </summary>
        public static readonly int HTTP_200 = 200; // OK
        public static readonly int HTTP_201 = 201; // CREATED
        public static readonly int HTTP_202 = 202; // NOT AUTHORITATIVE INFORMATIONS
        public static readonly int HTTP_204 = 204; // NO CONTENT RECORDED

        public static readonly int HTTP_400 = 400; // BADREQUEST 
        public static readonly int HTTP_401 = 401; // UNAUTHORIZED
        public static readonly int HTTP_403 = 403; // FORBIDDEN
        public static readonly int HTTP_404 = 404; // NOT_FOUND
        public static readonly int HTTP_407 = 407; // PROXY AUTHENITICATION REQUIRED

        public static readonly int HTTP_500 = 500; // INTERNAL SERVER ERROR
        public static readonly int HTTP_501 = 501; // NOT IMPLEMENTED
        public static readonly int HTTP_502 = 502; // BAD GATEWAY
        public static readonly int HTTP_503 = 503; // SERVICE UNVAILABLE





    }
}
