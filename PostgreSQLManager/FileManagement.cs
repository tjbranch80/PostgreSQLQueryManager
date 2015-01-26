﻿using System;
using System.IO;

namespace PostgreSQLManager
{
    public class FileManagement
    {
        public Result SaveQueryFile(string file, string queryText)
        {
            Result result = new Result();

            try
            {
                if (!string.IsNullOrWhiteSpace(file))
                {
                    File.WriteAllText(file, queryText);
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }

            result.Success = true;
            result.Message = "Save Was Successful";

            return result;
        }

        public string OpenQueryFile(string file)
        {
            string queryText = "";

            try
            {
                if (!string.IsNullOrWhiteSpace(file))
                {
                    queryText = File.ReadAllText(file);
                }
            }
            catch (Exception ex)
            {
                queryText = ex.Message;
            }

            return queryText;
        }

        public Result SaveNewProfile()
        {
            Result result = new Result();
        }
    }
}
