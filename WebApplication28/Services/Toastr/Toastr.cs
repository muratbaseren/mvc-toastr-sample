namespace WebApplication28
{
    public class Toastr
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public ToastrType Type { get; set; }

        public Toastr()
        {

        }

        public Toastr(string message, string title = "Information", ToastrType type = ToastrType.Info)
        {
            this.Message = message;
            this.Title = title;
            this.Type = type;
        }

        public string ToJavascript()
        {
            switch (Type)
            {
                case ToastrType.Info:
                    return $"toastr.info('{Message}','{Title}');";
                case ToastrType.Success:
                    return $"toastr.success('{Message}','{Title}');";
                case ToastrType.Warning:
                    return $"toastr.warning('{Message}','{Title}');";
                case ToastrType.Error:
                    return $"toastr.error('{Message}','{Title}');";
                default:
                    return $"toastr.info('{Message}','{Title}');";
            }
        }
    }
}