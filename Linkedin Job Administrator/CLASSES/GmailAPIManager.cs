using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linkedin_Job_Administrator.CLASSES
{
    public static class GmailAPIManager
    {
        private static GmailService _gmailService;

        public static void InicializarGmailService()
        {
            // Crear servicio Gmail
            _gmailService = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = ConfigurarCredentials(),
                ApplicationName = "GmailApp",
            });
        }

        public static UserCredential ConfigurarCredentials()
        {
            UserCredential credential;
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/linkedin-gmail");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    new[] { GmailService.Scope.GmailReadonly },
                    "user",
                CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            return credential;
        }

        public static void RemoveCredentials()
        {
            string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            credPath = Path.Combine(credPath, ".credentials/linkedin-gmail");

            if (Directory.Exists(credPath))
            {
                try
                {
                    Directory.Delete(credPath, true);
                    Console.WriteLine("El archivo ha sido eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al intentar eliminar el archivo: {ex.Message}");
                }
            }
            else
                Console.WriteLine("El archivo no existe.");
        }

        //Crea la query que se enviara al Gmail para recibir los correos
        public static UsersResource.MessagesResource.ListRequest RequestGenerator(int maxResults, DateTime? afterLimit, DateTime? beforeLimit)
        {
            //from:jobs-noreply@linkedin.com after:2024/01/01 before:2024/03/01 
            UsersResource.MessagesResource.ListRequest request = _gmailService.Users.Messages.List("me");
            request.MaxResults = maxResults; // Establecer el límite de resultados
            request.Q = "from:jobs-noreply@linkedin.com -nuevos -novedades -desapercibida -completar -solicita -información";
            if(afterLimit != null)
                request.Q += $" after:{afterLimit.Value.Year}/{afterLimit.Value.Month}/{afterLimit.Value.Day}";
            if(beforeLimit != null)
                request.Q += $" before:{beforeLimit.Value.Year}/{beforeLimit.Value.Month}/{beforeLimit.Value.Day+1}";

            return request;
        }

        public static UsersResource.MessagesResource.GetRequest GetRequest(Google.Apis.Gmail.v1.Data.Message message)
        {
            return _gmailService.Users.Messages.Get("me", message.Id);
        }

        public static string GetHeaderValue(IList<MessagePartHeader> headers, string name)
        {
            foreach (var header in headers)
            {
                if (header.Name == name)
                    return header.Value;
            }
            return "";
        }

        public static string GetMessageBody(Google.Apis.Gmail.v1.Data.Message email)
        {
            string body = "";

            // Verificar si el cuerpo del mensaje está en formato MIME
            if (email.Payload.MimeType == "text/plain")
            {
                body = email.Payload.Body.Data;
            }
            else if (email.Payload.Parts != null)
            {
                // Buscar el cuerpo del mensaje en las partes del mensaje
                foreach (MessagePart part in email.Payload.Parts)
                {
                    if (part.MimeType == "text/plain")
                    {
                        body = part.Body.Data;
                        break;
                    }
                }
            }

            // Decodificar el cuerpo del mensaje
            if (!string.IsNullOrEmpty(body))
            {
                byte[] data = FromBase64ForUrlString(body);
                body = Encoding.UTF8.GetString(data);
            }

            return body;
        }

        private static byte[] FromBase64ForUrlString(string base64ForUrlInput)
        {
            string padded = base64ForUrlInput.Length % 4 == 0
                ? base64ForUrlInput : base64ForUrlInput + "====".Substring(base64ForUrlInput.Length % 4);
            string base64 = padded.Replace("_", "/")
                .Replace("-", "+");
            return Convert.FromBase64String(base64);
        }
    }
}
