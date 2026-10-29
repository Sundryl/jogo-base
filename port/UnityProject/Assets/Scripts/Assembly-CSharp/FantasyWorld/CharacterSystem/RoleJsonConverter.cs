using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FantasyWorld.CharacterSystem
{
	public class RoleJsonConverter : JsonConverter<Role>
	{
		public override void WriteJson(JsonWriter writer, Role value, JsonSerializer serializer)
		{
		}

		public override Role ReadJson(JsonReader reader, Type objectType, Role existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return null;
		}

		private static string ReadString(JObject _jsonObject, string _primaryName, string _legacyName)
		{
			return null;
		}

		private static int ReadInt(JObject _jsonObject, string _primaryName, string _legacyName)
		{
			return 0;
		}

		private static TEnum ReadEnum<TEnum>(JObject _jsonObject, TEnum _fallback, string _primaryName, string _legacyName) where TEnum : struct
		{
			return default;
		}
	}
}
