using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace pwd_manager
{
    class XOR
    {
        public byte [] data { get; set; }
        public byte [] password { get; set; }

        public XOR()
        {

        }
        
        public XOR(byte [] _d, byte [] _p)
        {
            data = _d;
            password = _p;
        }
        public string decrypt(byte[] _data, byte[] _key)
        {
            BitArray decode_date_result = new BitArray(_data);
            BitArray decode_key_result = new BitArray(_key);
            int count = 0;

            for (int i = 0; i < decode_date_result.Length; i++)
            {
                decode_date_result[i] = decode_date_result[i] ^ decode_key_result[count];
                count++;
                if (count > decode_key_result.Length - 1)
                {
                    count = 0;
                }
            }
            byte[] encode_data = new byte[decode_date_result.Length / 8];
            decode_date_result.CopyTo(encode_data, 0);
            string abc = Convert.ToBase64String(encode_data);
            return abc;

        }
        
        public string encrypt(byte[] _data, byte[] _key)
        {
            BitArray decode_date_result = new BitArray(_data);
            BitArray decode_key_result = new BitArray(_key);
            int count = 0;

            for (int i = 0; i < decode_date_result.Length; i++)
            {
                decode_date_result[i] = decode_date_result[i] ^ decode_key_result[count];
                count++;
                if (count > decode_key_result.Length - 1)
                {
                    count = 0;
                }
            }
            byte[] encode_data = new byte[decode_date_result.Length / 8];
            decode_date_result.CopyTo(encode_data, 0);
            string abc = Encoding.UTF8.GetString(encode_data);
            return abc;
        }
    
    }
}
