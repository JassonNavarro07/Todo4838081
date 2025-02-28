﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo4838081
{
    public static class Constants
    {
        public const string DatabaseFilename = "TodoSQLite.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            //open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            //create the database if it doesn`t exits
            SQLite.SQLiteOpenFlags.Create |
            //enable multi-theared database acces
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);

    }
}
