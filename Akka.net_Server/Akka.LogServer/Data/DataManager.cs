﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Akka.LogServer
{
    public class DataManager
    {
        public static void Init()
        {
            //최초 로드하고 싶은게 있다면
        }
        // Loader 인터페이스 사용하는데 Json파일에 Loader이름 있을 경우
        public static Loader? LoadJson<Loader>(string path) where Loader : ILoader, new()
        {
            string jsonString = ReadJsonFile(path);

            if (string.IsNullOrEmpty(jsonString))
                return default(Loader);

            if (IsValidJson(jsonString) == false)
            {
                string propertyName = typeof(Loader).GetFields().FirstOrDefault()?.Name ??
               throw new Exception("No properties found in Loader class.");

                jsonString = ConvertToJson(jsonString, $"{propertyName}");
            }

            //protobuf TimeStamp 파싱을 위한 커스텀
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new TimeStampContractResolver()
            };

            return JsonConvert.DeserializeObject<Loader>(jsonString, settings);
        }
        public static bool IsValidJson(string jsonString)
        {
            // JSON 형식이 유무
            try
            {
                JToken.Parse(jsonString);
                return true;
            }
            catch (JsonReaderException)
            {
                return false;
            }
        }
        static string ReadJsonFile(string path)
        {
            // JSON 파일 유무
            string filePath = $"{ConfigManager.Config.logPath}/{path}.json";

            if (!File.Exists(filePath))
                return string.Empty;

            string jsonString;

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader reader = new StreamReader(fs))
            {
                jsonString = reader.ReadToEnd();
            }

            return jsonString;
        }
        private static string ConvertToJson(string jsonString, string objectName)
        {
            //json 형식이 아니라면 Loader의 첫 필드와 파싱시킴
            string pattern = @"\{[^}]+\}";
            MatchCollection matches = Regex.Matches(jsonString, pattern);

            StringBuilder sb = new StringBuilder();

            sb.Append($"{{\"{objectName}\":[");

            for (int i = 0; i < matches.Count; i++)
            {
                sb.Append(matches[i].Value);
                if (i < matches.Count - 1)
                {
                    sb.Append(",");
                }
            }

            return sb.Append("]}").ToString();
        }
    }
}
