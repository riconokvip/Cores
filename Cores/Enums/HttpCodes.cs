namespace Cores.Enums
{
    public enum HttpCodes
    {
        OK = 200,

        BAD_REQUEST = 400,

        UNAUTHORIZED = 401,

        FOR_BIDDEN = 403,

        NOT_FOUND = 404,

        METHOD_NOT_ALLOWED = 405,

        CONFLICT = 409,

        PAYLOAD_TOO_LARGE = 413,

        UNSUPPORTED_MEDIA_TYPE = 415,

        LOCKED = 423,

        TOO_MANY_REQUEST = 429,

        INTERNAL_SERVER_ERROR = 500,

        SERVER_NOT_RESPONSE = 504
    }
}
