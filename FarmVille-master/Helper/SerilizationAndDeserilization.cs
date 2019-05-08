using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Helper
{
    public static class SerilizationAndDeserilization
    {

        #region Binary
        public static byte[] BinarySerialize(this object dataToSerialize)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            byte[] dataSerialized = new byte[1];
            try
            {
                formatter.Serialize(stream, dataToSerialize);
                dataSerialized = stream.GetBuffer();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                stream.Dispose();
                stream.Close();
            }

            return dataSerialized;
        }

        public static object BinaryDeserialize(this byte[] dataToSerialize)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            object dataDeserialized = new object();
            try
            {
                stream = new MemoryStream(dataToSerialize);
                dataDeserialized = formatter.Deserialize(stream);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                stream.Dispose();
                stream.Close();
            }

            return dataDeserialized;
        }
        #endregion

        #region Xml
        public static int XmlSerialization(this object dataToSerialize, string filePath)
        {

            FileStream stream = null;
            int result = 0;
            try
            {
                Type type = dataToSerialize.GetType();

                XmlSerializer xmlSerializer = new XmlSerializer(type);
                stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);

                xmlSerializer.Serialize(stream, dataToSerialize);
                result = 1;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                stream.Dispose();
                stream.Close();
            }

            return result;
        }

        public static object XmlDeserialization(this object dataToDeserialize, string filePath)
        {

            FileStream stream = null;
            try
            {
                Type type = dataToDeserialize.GetType();

                XmlSerializer xmlSerializer = new XmlSerializer(type);
                stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                dataToDeserialize = xmlSerializer.Deserialize(stream);
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                stream.Dispose();
                stream.Close();
            }

            return dataToDeserialize;
        }
        #endregion

    }
}

