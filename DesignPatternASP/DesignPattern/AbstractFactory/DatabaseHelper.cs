﻿using System.Data.Common;
using System.Data;

namespace DesignPatternASP.DesignPattern.AbstractFactory
{
    public class DatabaseHelper
    {
        private IDatabaseFactory factory;
        public DatabaseHelper(IDatabaseFactory factory) 
        { 
            this.factory = factory;
        }

        public DbDataReader ExecuteSelect(string query)
        {
            DbConnection cnn = factory.GetConnection();
            cnn.ConnectionString = AppSettings.ConnectionString;
            DbCommand cmd = factory.GetCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cnn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public DbDataReader ExecuteSelect(string query, DbParameter[] parameters)
        {
            DbConnection cnn = factory.GetConnection();
            cnn.ConnectionString = AppSettings.ConnectionString;
            DbCommand cmd = factory.GetCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddRange(parameters);
            cnn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public int ExecuteAction(string query)
        {
            DbConnection cnn = factory.GetConnection();
            cnn.ConnectionString = AppSettings.ConnectionString;
            DbCommand cmd = factory.GetCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cnn.Open();
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;
        }

        public int ExecuteAction(string query, DbParameter[] parameters)
        {
            DbConnection cnn = factory.GetConnection();
            cnn.ConnectionString = AppSettings.ConnectionString;
            DbCommand cmd = factory.GetCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddRange(parameters);
            cnn.Open();
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            return i;
        }
    }
}
