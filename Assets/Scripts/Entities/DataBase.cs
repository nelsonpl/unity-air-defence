using System;
using System.Collections.Generic;
//using System.Data;
using System.Linq;
using System.Text;
//using Mono.Data.Sqlite;
using UnityEngine;

namespace Assets.Scripts.Entities
{
    internal static class DataBase
    {
        //readonly static string StringConnection = string.Format("URI=file:{0}/AirDefenceDB.db", Application.dataPath);
        internal static int Score
        {
            get
            {
                int score = PlayerPrefs.GetInt("SCORE", 0);
                //using (var connection = (IDbConnection)new SqliteConnection(StringConnection))
                //{
                //    connection.Open();
                //    var command = connection.CreateCommand();
                //    command.CommandText = "select score from config";
                //    score = Convert.ToInt32(command.ExecuteScalar());
                //    command.Dispose();
                //}

                return score;
            }
            set
            {
                PlayerPrefs.SetInt("SCORE", value);
                PlayerPrefs.Save();
                //using (var connection = (IDbConnection)new SqliteConnection(StringConnection))
                //{
                //    connection.Open();
                //    var command = connection.CreateCommand();
                //    command.CommandText = "update config set score = " + value;
                //    command.ExecuteNonQuery();
                //    command.Dispose();
                //}
            }
        }
        internal static int Sound
        {
            get
            {
                int sound = PlayerPrefs.GetInt("SOUND", 1);
                PlayerPrefs.Save();
                //using (var connection = (IDbConnection)new SqliteConnection(StringConnection))
                //{
                //    connection.Open();
                //    var command = connection.CreateCommand();
                //    command.CommandText = "select sound from config";
                //    sound = Convert.ToInt32(command.ExecuteScalar());
                //    command.Dispose();
                //}
                return sound;
            }
            set
            {
                PlayerPrefs.SetInt("SOUND", value);
                //using (var connection = (IDbConnection)new SqliteConnection(StringConnection))
                //{
                //    connection.Open();
                //    var command = connection.CreateCommand();
                //    command.CommandText = "update config set sound = " + value;
                //    command.ExecuteNonQuery();
                //    command.Dispose();
                //}
            }
        }

    }
}
