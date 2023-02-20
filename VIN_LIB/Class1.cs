namespace VIN_LIB
{
  
    public class Class1
    {
        string letters = "ABCDEFGHJKLMNPRSTUVWXYZ";
        string lettersAndNumbers = "ABCDEFGHJKLMNPRSTUVWXYZ123456789"; //32

        public bool CheckVIN(string vin)
        {
            if(vin.Length != 17)
            {
                return false;
            }

            int flag = 0;

            // WMI
            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (vin[j] == letters[i])
                    {
                        flag = 1;
                        break;
                    }
                }
            }

            if (flag == 0)
                return false;

            // VDS

            if (!((Convert.ToInt32(vin[9]) >= 0 && Convert.ToInt32(vin[9]) <= 9) || vin[9] == 'X'))
            {
                return false;
            }

            // VIS

            try
            {
                for (int i = 13; i < 17; i++)
                {
                    Convert.ToInt32(vin[i]);
                }
            }
            catch
            {
                return false;
            }

            flag = 0;

            for (int i = 0; i < lettersAndNumbers.Length; i++)
            {
                if (vin[9] == letters[i])
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
                return false;

            return true;
        }
        public string GetVINCountry(string vin)
        {

            int index = -1;

            for (int i = 0; i < lettersAndNumbers.Length; i++)
            {
                if (vin[0] == lettersAndNumbers[i])
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
                return "Страна не определена";
            if (index >= 0 && index <= 7)
                return "Африка";
            else if (index >= 8 && index <= 14)
                return "Азия";
            else if (index >= 15 && index <= 22)
                return "Европа";
            else if (index >= 23 && index <= 27)
                return "Северная Америка";
            else if (index >= 28 && index <= 29)
                return "Океания";
            else if (index >= 30 && index <= 31)
                return "Южная Америка";
            else
                return "Ошибка";


        }


    }
}