using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MyNextPet.Core.Models.Enums;


namespace MyNextPet.Core.Helpers;
public class PetfinderStringEnumConverter : JsonConverterFactory
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(Color) || objectType == typeof(Coat) || objectType == typeof(Gender);
    }

    public static T ToEnum<T>(string str)
    {
        var enumType = typeof(T);
        var fields = enumType.GetFields();
        if (enumType == typeof(Gender) || enumType == typeof(Coat) || fields.Where(f => f.Name == str).Count() > 0)        {
            return (T)Enum.Parse(enumType, str);
        }
        if (fields.Where(f => f.Name == str).Count() > 0)
        {
            
        }
        foreach (var field in fields)
        {
            var enumMemberAttributes = ((EnumMemberAttribute[])enumType.GetField(field.Name).GetCustomAttributes(typeof(EnumMemberAttribute), true));
            if (enumMemberAttributes.Length > 0)
            {
                if (enumMemberAttributes.Single().Value == str) return (T)Enum.Parse(enumType, field.Name);
            }
        }

        return default(T);
    }

    public override JsonConverter CreateConverter(Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
    {

        JsonConverter converter = null;
        if (typeToConvert == typeof(Color))
        {

            converter = (JsonConverter)Activator.CreateInstance(
            typeof(PetfinderColorToEnumConverter),
            BindingFlags.Instance | BindingFlags.Public,
            binder: null,
            args: new object[] { options },
            culture: null);
        }
        else if (typeToConvert == typeof(Coat))
        {

            converter = (JsonConverter)Activator.CreateInstance(
            typeof(PetfinderCoatToEnumConverter),
            BindingFlags.Instance | BindingFlags.Public,
            binder: null,
            args: new object[] { options },
            culture: null);
        }
        else if(typeToConvert == typeof(Gender))
        {
            converter = (JsonConverter)Activator.CreateInstance(
            typeof(PetfinderGenderToEnumConverter),
            BindingFlags.Instance | BindingFlags.Public,
            binder: null,
            args: new object[] { options },
            culture: null);
        }


        return converter;

    }


    private class PetfinderColorToEnumConverter : JsonConverter<Color>
    {
        public PetfinderColorToEnumConverter(JsonSerializerOptions options)
        {

        }


        public override Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return ToEnum<Color>(reader.GetString());
        }
        public override void Write(Utf8JsonWriter writer, Color value, JsonSerializerOptions options) => throw new NotImplementedException();
    }

    private class PetfinderCoatToEnumConverter : JsonConverter<Coat>
    {
        public PetfinderCoatToEnumConverter(JsonSerializerOptions options)
        {

        }


        public override Coat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return ToEnum<Coat>(reader.GetString());
        }
        public override void Write(Utf8JsonWriter writer, Coat value, JsonSerializerOptions options) => throw new NotImplementedException();
    }

    private class PetfinderGenderToEnumConverter : JsonConverter<Gender>
    {
        public PetfinderGenderToEnumConverter(JsonSerializerOptions options)
        {

        }


        public override Gender Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return ToEnum<Gender>(reader.GetString());
        }
        public override void Write(Utf8JsonWriter writer, Gender value, JsonSerializerOptions options) => throw new NotImplementedException();
    }


}


