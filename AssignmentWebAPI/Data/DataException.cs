﻿using System;

namespace AssignmentWebAPI.Data
{
    public class DataException : Exception
    {
        public DataException()
        {}

        public DataException(string message) : base(message)
        {
            
        }
    }
}