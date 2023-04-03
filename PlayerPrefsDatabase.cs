using UnityEngine;

namespace Databases
{
    public class PlayerPrefsDatabase : IDatabase
    {
        public string Query(string key)
        {
            return PlayerPrefs.GetString(key);
        }

        public void Update(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
        }
    }
}