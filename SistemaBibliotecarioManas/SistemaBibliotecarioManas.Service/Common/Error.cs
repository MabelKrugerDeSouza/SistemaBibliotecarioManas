namespace SistemaBibliotecarioManas.Application.Common
{
    public class Error
    {
        public string FieldName { get; set; }
        public string Message { get; set; }

        public Error(string fieldName, string message)
        {
            FieldName = fieldName;
            Message = message;
        }

        public Error()
        {
        }

        public Error(string fieldName)
        {
            FieldName = fieldName;
        }
    }
}
